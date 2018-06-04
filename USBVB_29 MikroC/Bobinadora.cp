#line 1 "C:/Users/Luis/Documents/MikroC/Bobinadora/Bobinadora.c"
#line 1 "c:/program files/mikroc pro for pic/include/built_in.h"
#line 5 "C:/Users/Luis/Documents/MikroC/Bobinadora/Bobinadora.c"
unsigned char num;
unsigned char Leer_USB[64] absolute 0x500;
unsigned char Escribir_USB[64] absolute 0x540;
unsigned char Reservar_USB[256] absolute 0x400;
unsigned char dato_USB= 0;

void interrupt(){
 Usb_Interrupt_Proc();

}

void Lee_pin();
void Lee_pin()
{
 Escribir_USB[1] = PORTD;
 while(!HID_Write(&Escribir_USB, 64));
}
void main()
{
unsigned int analogVal;
char dato;
TRISA = 255;
TRISB= 0x00;
PORTB= 0x00;
TRISD= 0;
PORTD= 0x00;
TRISC= 0;
PORTC= 0x00;

PWM1_Init(3000);
PWM1_Set_Duty(0);
PWM2_Init(3000);
PWM2_Set_Duty(0);
ADC_Init();

HID_Enable(&Leer_USB,&Escribir_USB);

while(1)
 {

 analogVal = ADC_get_sample(1);
 Escribir_USB[2] =  ((char *)&analogVal)[1] ;
 Escribir_USB[3] =  ((char *)&analogVal)[0] ;
 Lee_pin();
 dato = HID_Read();
 if(dato != 0)
 {
 dato = 0;

 if((Leer_USB[1])==0x01)
 {
 PWM2_Stop();
 PWM1_Start();
 PWM1_Set_Duty(Leer_USB[2]);
 }
 else if ((Leer_USB[1])==0x02)
 {
 PWM1_Stop();
 PWM2_Start();
 PWM2_Set_Duty(Leer_USB[2]);
 }
 else if((Leer_USB[1])==0x00)
 {
 PWM1_Stop();
 PWM2_Stop();
 }
 else if ((Leer_USB[1])==0x05)
 {
 PORTB = 0x00;
 }
 }
 while(!HID_Write(&Escribir_USB, 64));
 delay_ms(100);
 }
}
