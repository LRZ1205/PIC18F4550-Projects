
_interrupt:

;Bobinadora.c,11 :: 		void interrupt(){
;Bobinadora.c,12 :: 		Usb_Interrupt_Proc();              //Mantiene viva la comunicacion
	CALL        _USB_Interrupt_Proc+0, 0
;Bobinadora.c,14 :: 		}
L_end_interrupt:
L__interrupt16:
	RETFIE      1
; end of _interrupt

_Lee_pin:

;Bobinadora.c,17 :: 		void Lee_pin()
;Bobinadora.c,19 :: 		Escribir_USB[1] = PORTD;
	MOVF        PORTD+0, 0 
	MOVWF       1345 
;Bobinadora.c,20 :: 		while(!HID_Write(&Escribir_USB, 64));
L_Lee_pin0:
	MOVLW       _Escribir_USB+0
	MOVWF       FARG_HID_Write_writebuff+0 
	MOVLW       hi_addr(_Escribir_USB+0)
	MOVWF       FARG_HID_Write_writebuff+1 
	MOVLW       64
	MOVWF       FARG_HID_Write_len+0 
	CALL        _HID_Write+0, 0
	MOVF        R0, 1 
	BTFSS       STATUS+0, 2 
	GOTO        L_Lee_pin1
	GOTO        L_Lee_pin0
L_Lee_pin1:
;Bobinadora.c,21 :: 		}
L_end_Lee_pin:
	RETURN      0
; end of _Lee_pin

_main:

;Bobinadora.c,22 :: 		void main()
;Bobinadora.c,26 :: 		TRISA = 255; //Entrada
	MOVLW       255
	MOVWF       TRISA+0 
;Bobinadora.c,27 :: 		TRISB= 0x00;
	CLRF        TRISB+0 
;Bobinadora.c,28 :: 		PORTB= 0x00;
	CLRF        PORTB+0 
;Bobinadora.c,29 :: 		TRISD= 0;
	CLRF        TRISD+0 
;Bobinadora.c,30 :: 		PORTD= 0x00;
	CLRF        PORTD+0 
;Bobinadora.c,31 :: 		TRISC= 0;
	CLRF        TRISC+0 
;Bobinadora.c,32 :: 		PORTC= 0x00;
	CLRF        PORTC+0 
;Bobinadora.c,34 :: 		PWM1_Init(3000);
	BSF         T2CON+0, 0, 0
	BSF         T2CON+0, 1, 0
	MOVLW       104
	MOVWF       PR2+0, 0
	CALL        _PWM1_Init+0, 0
;Bobinadora.c,35 :: 		PWM1_Set_Duty(0);
	CLRF        FARG_PWM1_Set_Duty_new_duty+0 
	CALL        _PWM1_Set_Duty+0, 0
;Bobinadora.c,36 :: 		PWM2_Init(3000);
	BSF         T2CON+0, 0, 0
	BSF         T2CON+0, 1, 0
	MOVLW       104
	MOVWF       PR2+0, 0
	CALL        _PWM2_Init+0, 0
;Bobinadora.c,37 :: 		PWM2_Set_Duty(0);
	CLRF        FARG_PWM2_Set_Duty_new_duty+0 
	CALL        _PWM2_Set_Duty+0, 0
;Bobinadora.c,38 :: 		ADC_Init();
	CALL        _ADC_Init+0, 0
;Bobinadora.c,40 :: 		HID_Enable(&Leer_USB,&Escribir_USB);
	MOVLW       _Leer_USB+0
	MOVWF       FARG_HID_Enable_readbuff+0 
	MOVLW       hi_addr(_Leer_USB+0)
	MOVWF       FARG_HID_Enable_readbuff+1 
	MOVLW       _Escribir_USB+0
	MOVWF       FARG_HID_Enable_writebuff+0 
	MOVLW       hi_addr(_Escribir_USB+0)
	MOVWF       FARG_HID_Enable_writebuff+1 
	CALL        _HID_Enable+0, 0
;Bobinadora.c,42 :: 		while(1)
L_main2:
;Bobinadora.c,45 :: 		analogVal = ADC_get_sample(1);
	MOVLW       1
	MOVWF       FARG_ADC_Get_Sample_channel+0 
	CALL        _ADC_Get_Sample+0, 0
	MOVF        R0, 0 
	MOVWF       main_analogVal_L0+0 
	MOVF        R1, 0 
	MOVWF       main_analogVal_L0+1 
;Bobinadora.c,46 :: 		Escribir_USB[2] =  Hi(analogVal);
	MOVF        main_analogVal_L0+1, 0 
	MOVWF       1346 
;Bobinadora.c,47 :: 		Escribir_USB[3] =  Lo(analogVal);
	MOVF        main_analogVal_L0+0, 0 
	MOVWF       1347 
;Bobinadora.c,48 :: 		Lee_pin();
	CALL        _Lee_pin+0, 0
;Bobinadora.c,49 :: 		dato = HID_Read();              //  Devuelve el numero de bytes recibidos
	CALL        _HID_Read+0, 0
;Bobinadora.c,50 :: 		if(dato != 0)
	MOVF        R0, 0 
	XORLW       0
	BTFSC       STATUS+0, 2 
	GOTO        L_main4
;Bobinadora.c,54 :: 		if((Leer_USB[1])==0x01)
	MOVF        1281, 0 
	XORLW       1
	BTFSS       STATUS+0, 2 
	GOTO        L_main5
;Bobinadora.c,56 :: 		PWM2_Stop();
	CALL        _PWM2_Stop+0, 0
;Bobinadora.c,57 :: 		PWM1_Start();
	CALL        _PWM1_Start+0, 0
;Bobinadora.c,58 :: 		PWM1_Set_Duty(Leer_USB[2]);
	MOVF        1282, 0 
	MOVWF       FARG_PWM1_Set_Duty_new_duty+0 
	CALL        _PWM1_Set_Duty+0, 0
;Bobinadora.c,59 :: 		}
	GOTO        L_main6
L_main5:
;Bobinadora.c,60 :: 		else if ((Leer_USB[1])==0x02)
	MOVF        1281, 0 
	XORLW       2
	BTFSS       STATUS+0, 2 
	GOTO        L_main7
;Bobinadora.c,62 :: 		PWM1_Stop();
	CALL        _PWM1_Stop+0, 0
;Bobinadora.c,63 :: 		PWM2_Start();
	CALL        _PWM2_Start+0, 0
;Bobinadora.c,64 :: 		PWM2_Set_Duty(Leer_USB[2]);
	MOVF        1282, 0 
	MOVWF       FARG_PWM2_Set_Duty_new_duty+0 
	CALL        _PWM2_Set_Duty+0, 0
;Bobinadora.c,65 :: 		}
	GOTO        L_main8
L_main7:
;Bobinadora.c,66 :: 		else if((Leer_USB[1])==0x00)
	MOVF        1281, 0 
	XORLW       0
	BTFSS       STATUS+0, 2 
	GOTO        L_main9
;Bobinadora.c,68 :: 		PWM1_Stop();
	CALL        _PWM1_Stop+0, 0
;Bobinadora.c,69 :: 		PWM2_Stop();
	CALL        _PWM2_Stop+0, 0
;Bobinadora.c,70 :: 		}
	GOTO        L_main10
L_main9:
;Bobinadora.c,71 :: 		else if ((Leer_USB[1])==0x05)
	MOVF        1281, 0 
	XORLW       5
	BTFSS       STATUS+0, 2 
	GOTO        L_main11
;Bobinadora.c,73 :: 		PORTB = 0x00;
	CLRF        PORTB+0 
;Bobinadora.c,74 :: 		}
L_main11:
L_main10:
L_main8:
L_main6:
;Bobinadora.c,75 :: 		}
L_main4:
;Bobinadora.c,76 :: 		while(!HID_Write(&Escribir_USB, 64));
L_main12:
	MOVLW       _Escribir_USB+0
	MOVWF       FARG_HID_Write_writebuff+0 
	MOVLW       hi_addr(_Escribir_USB+0)
	MOVWF       FARG_HID_Write_writebuff+1 
	MOVLW       64
	MOVWF       FARG_HID_Write_len+0 
	CALL        _HID_Write+0, 0
	MOVF        R0, 1 
	BTFSS       STATUS+0, 2 
	GOTO        L_main13
	GOTO        L_main12
L_main13:
;Bobinadora.c,77 :: 		delay_ms(100);
	MOVLW       3
	MOVWF       R11, 0
	MOVLW       138
	MOVWF       R12, 0
	MOVLW       85
	MOVWF       R13, 0
L_main14:
	DECFSZ      R13, 1, 1
	BRA         L_main14
	DECFSZ      R12, 1, 1
	BRA         L_main14
	DECFSZ      R11, 1, 1
	BRA         L_main14
	NOP
	NOP
;Bobinadora.c,78 :: 		}
	GOTO        L_main2
;Bobinadora.c,79 :: 		}
L_end_main:
	GOTO        $+0
; end of _main
