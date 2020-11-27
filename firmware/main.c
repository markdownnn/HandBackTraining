// 8-2 TP3,5,6의 data를 ADC하여 PC로 전송하기

#include <msp430x16x.h>
#include <stdio.h>

// Constants, macros and .... **************************************************************************
#define 	LED1ON			(P3OUT &= (~BIT0))
#define 	LED1OFF 		        (P3OUT |= BIT0)
#define 	IsLED1OFF		(P3OUT & BIT0)
#define 	LED2ON			(P3OUT &= (~BIT1))
#define 	LED2OFF 		        (P3OUT |= BIT1)
#define 	IsLED2OFF		(P3OUT & BIT1)

unsigned int adc1,adc2,adc3,adc4,adc5,adc6;
int input;
int count = 0;

unsigned char Packet[13];
unsigned char state;
unsigned char before_state;

unsigned int flex_threshold[5]= {35800, 35800, 35000, 35800, 35000};     //처음 calibration에서 설정한 손가락 구부림 기준값.
int finger[5]={0,0,0,0,0}; // 손이 굽었는지 확인하는 변수
int button = 1; // 엄지랑 검지 스위치를 확인하는 변수


void translator(int statement);
void threshold();
int action(); // 상황에 맞는 해당 동작이 어떤것인지를 출력하는 함수.

void ReadAdc12 (void);      // Read data from internal 12 bits ADC

void main(void)
{
    unsigned int i;

//  Set basic clock and timer
	
    WDTCTL = WDTPW + WDTHOLD;                 // Stop WDT
	BCSCTL1 &= ~XT2OFF;                       // // XT2 on
	do{
           IFG1 &=~OFIFG;                    // Clear oscillator flag
           for(i=0;i<0xFF;i++);              // Delay for OSC to stabilize
	}while((IFG1&OFIFG));  

	BCSCTL2 |= SELM_2;                        // MCLK =XT2CLK=6Mhz
	BCSCTL2 |= SELS;                          // SMCLK=XT2CLK=6Mhz

// Set Port  
	P3SEL = BIT4|BIT5;                            // P3.4,5 = USART0 TXD/RXD
	P6SEL = 0x3f;	P6DIR=0x3f;	P6OUT=0x00;  
        
        P3SEL &= ~(BIT0 | BIT1);			// set P3.0,1 to GPIO
	P3DIR |= (BIT0 | BIT1); 			// set direction of P3.0,1 as output
        
        P1SEL &= ~(BIT4 | BIT5 | BIT6);		// set P1.4,5,6 to GPIO
	P1DIR &= ~(BIT4 | BIT5 | BIT6);		// set direction of P1.4,5,6 as input
        P1IE |= BIT4 | BIT5 | BIT6;			// enable interrupt of P1.4,5,6
	P1IFG &= ~(BIT4 | BIT5 | BIT6);		// reset interrupt flag of P1.4,5,6
        
        P2SEL &= ~(BIT4 | BIT5 | BIT6);		// set P2.4,5,6 to GPIO
	P2DIR &= ~(BIT4 | BIT5 | BIT6);		// set direction of P2.4,5,6 as input
        P2IE |= BIT4 | BIT5 | BIT6;			// enable interrupt of P2.4,5,6
	P2IFG &= ~(BIT4 | BIT5 | BIT6);		// reset interrupt flag of P2.4,5,6
        
        _EINT();

//Set UART0  
	ME1 |= UTXE0 + URXE0;                     // Enable USART0 TXD/RXD
	UCTL0 |= CHAR;                            // 8-bit character
	UTCTL0 |= SSEL0|SSEL1;                    // UCLK= SMCLK
	UBR00 = 0x34;                             // 6MHz 115200
	UBR10 = 0x00;                             // 6MHz 115200
	UMCTL0 = 0x00;                            // 6MHz 115200 modulation
	UCTL0 &= ~SWRST;                          // Initialize USART state machine

//  Set 12bit internal ADC
	ADC12CTL0 = ADC12ON | REFON | REF2_5V;                // ADC on, 2.5 V reference on
	ADC12CTL0 |= MSC;                                     // multiple sample and conversion
	ADC12CTL1 = ADC12SSEL_3 | ADC12DIV_7 | CONSEQ_1;      // SMCLK, /8, sequence of channels
	ADC12CTL1 |= SHP;      

	ADC12MCTL0 = SREF_0 | INCH_0;
	ADC12MCTL1 = SREF_0 | INCH_1;
	ADC12MCTL2 = SREF_0 | INCH_2;
	ADC12MCTL3 = SREF_0 | INCH_3;
	ADC12MCTL4 = SREF_0 | INCH_4;
	ADC12MCTL5 = SREF_0 | INCH_5 | EOS;

	ADC12CTL0 |= ENC;                                     // enable conversion

//  SetTimerA,B
	TACTL=TASSEL_2+MC_1;                        // clock source and mode(UP) select
	TACCTL0=CCIE;
	TACCR0=24000;                         // 6M/24000=250hz

  _BIS_SR(LPM0_bits + GIE);                 // Enter LPM0 w/ interrupt  
  while(1){}

}


#pragma vector = TIMERA0_VECTOR
__interrupt void TimerA0_interrupt()
{
	ReadAdc12();
        threshold();
        
        translator(action());
        
	Packet[0]=(unsigned char)0x81;
	__no_operation();

	Packet[1]=(unsigned char)state&0x7F;
	Packet[2]=(unsigned char)state&0x7F;
  
	
	Packet[3]=(unsigned char)(adc1>>7)&0x7F;
	Packet[4]=(unsigned char)adc1&0x7F;
  
	Packet[5]=(unsigned char)(adc6>>7)&0x7F;
	Packet[6]=(unsigned char)adc6&0x7F;  
      
      
	for(int j=0;j<4;j++){
		while (!(IFG1 & UTXIFG0));                // USART0 TX buffer ready?
		TXBUF0=Packet[j];
	}
        
        count++;
        if(count > 750)
        {
          input = 0;
          count = 0;
        }
}
void ReadAdc12 (void)
{
	// read ADC12 result from ADC12 conversion memory
	// start conversion and store result without CPU intervention
	adc1 = (unsigned int)( (long)ADC12MEM0 * 9000 / 4096 * 5);             // adc0 voltage in [mV]
	adc2 = (unsigned int)( (long)ADC12MEM1 * 9000 / 4096 * 5); 
	adc3 = (unsigned int)( (long)ADC12MEM2 * 9000 / 4096 * 5); 
	adc4 = (unsigned int)( (long)ADC12MEM3 * 9000 / 4096 * 5); 
	adc5 = (unsigned int)( (long)ADC12MEM4 * 9000 / 4096 * 5); 
	adc6 = (unsigned int)( (long)ADC12MEM5 * 9000 / 4096 * 5); 
        printf("%u %u %u %u %u\n", adc5, adc4, adc3, adc2, adc1);
            
	ADC12CTL0|=ADC12SC;                                               // start conversion
}
void translator(int statement)
{
  
  switch(statement)
  {
	case 0:
		state=0x00;
		break;
	case 1:
		state&=BIT6;
                state|=BIT0;
		break;
	case 2:
		state&=BIT6;
                state|=BIT1;
		break;
	case 3:
		state&=BIT6;
                state|=BIT2;
		break;
	case 4:
		state&=BIT6;
                state|=BIT3;
		break;
	case 5:
		state&=BIT6;
                state|=BIT4;
		break;
	case 6:
		state&=BIT6;
                state|=BIT5;
		break;
	case 7:		//interrupt
		state|=BIT6;
		break;
	default:
		state&=BIT6|0x00;
		break;
  }
  return;
}
void threshold()
{
  if(adc1>flex_threshold[4])
  {
    finger[4]=1;
  }
  else
  {
    finger[4]=0;
  }
  if(adc2>flex_threshold[3])
  {
    finger[3]=1;
  }
  else
  {
    finger[3]=0;
  }
  if(adc3>flex_threshold[2])
  {
    finger[2]=1;
  }
  else
  {
    finger[2]=0;
  }
  if(adc4>flex_threshold[1])
  {
    finger[1]=1;
  }
  else
  {
    finger[1]=0;
  }
  if(adc5>flex_threshold[0])
  {
    finger[0]=1;
  }
  else
  {
    finger[0]=0;
  }
  return;
}
int action()
{
  int sum = 0;
  
  for (int i=0;i<5;i++)
  {
    sum += finger[i];
  }
  switch(sum)
  {
  case 0:
      return 1;
  case 1:
      if (finger[0]==1) return 5; // 행동은 슬라이드에 있던거 왼쪽이 1 마지막이 6 그리고 모르면 0이다.
      else return 0;
  case 2:
      if (finger[1]&&finger[2]) return 3;
      else if (finger[0]&&finger[4]) return 6;
      else return 0;
  case 3:
      if (button&&finger[2]&&finger[3]&&finger[4]) return 4;
      else return 0;
  case 5:
      return 2;
  default:
      return 0;
  }
}
#pragma vector = PORT1_VECTOR
__interrupt void P1ExtInt()
{
	if(P1IFG & BIT4)
	{
                input = 1;
		LED1ON;
		LED2OFF;
                count = 0;
	}
	else if(P1IFG & BIT5)
	{
		input = 2;
		LED1OFF;
		LED2ON;
                count = 0;
	}
	else if(P1IFG & BIT6)
	{
		input = 3;
		LED1ON;
		LED2ON;
                count = 0;
	}
	P1IFG = 0x00;
}
#pragma vector = PORT2_VECTOR
__interrupt void P2ExtInt()
{
	if(P2IFG & BIT4)
	{
		input=7;
                count = 0;
	}
	else if(P2IFG & BIT5)
	{
		button = 1;
	}
	else if(P2IFG & BIT6)
	{
                button = 1;
	}
	P2IFG = 0x00;
}
