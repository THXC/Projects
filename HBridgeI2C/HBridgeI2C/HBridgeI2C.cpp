#include <HBridgeI2CI2C.h>
#include "Arduino.h"
#include "Wire.h"

#if ARDUINO >= 100
 #include "Arduino.h"
#else
 #include "WProgram.h"
#endif

// minihelper
static inline void ww(uint8_t x) {
#if ARDUINO >= 100
  Wire.write((uint8_t)x);
#else
  Wire.send(x);
#endif
}

void HBridgeI2C::begin(uint8_t addr) {
  hbi2caddr = addr;
  Wire.begin();  
  // set defaults!
  Wire.beginTransmission(HBridgeI2C_Addr | hbi2caddr);
  ww(0xFF);  // all ports are set to HIGH
  Wire.endTransmission();
}

void HBridgeI2C::begin(void){
	begin(0);
}

/***************************************************************************************************/

/*
stop
*/
void HBridgeI2C::Stop(){
	Wire.beginTransmission(HBridgeI2C_Addr | hbi2caddr);
	ww(HBridgeI2C_Resset);
	Wire.endTransmission();
}

/*
forward A
*/
void HBridgeI2C::motorAForward(){
	Wire.beginTransmission(HBridgeI2C_Addr | hbi2caddr);
	ww(HBridgeI2C_EA_I1);
	Wire.endTransmission();
}

/*
forward B
*/
void HBridgeI2C::motorBForward(){
	Wire.beginTransmission(HBridgeI2C_Addr | hbi2caddr);
	ww(HBridgeI2C_EB_I3);
	Wire.endTransmission();
}

/*
forward AB
*/
void HBridgeI2C::motorForward(){
	Wire.beginTransmission(HBridgeI2C_Addr | hbi2caddr);
	ww(HBridgeI2C_EA_I1_EB_I3);
	Wire.endTransmission();
}

/*
backward A
*/
void HBridgeI2C::motorABackward(){
	Wire.beginTransmission(HBridgeI2C_Addr | hbi2caddr);
	ww(HBridgeI2C_EA_I2);
	Wire.endTransmission();
}

/*
backward B
*/
void HBridgeI2C::motorBBackward(){
	Wire.beginTransmission(HBridgeI2C_Addr | hbi2caddr);
	ww(HBridgeI2C_EB_I4);
	Wire.endTransmission();
}

/*
backward AB
*/
void HBridgeI2C::motorBackward(){
	Wire.beginTransmission(HBridgeI2C_Addr | hbi2caddr);
	ww(HBridgeI2C_EA_I2_EB_I4);
	Wire.endTransmission();
}

/*
turn A left
*/
void HBridgeI2C::turnALeft(){
	Wire.beginTransmission(HBridgeI2C_Addr | hbi2caddr);
	ww(HBridgeI2C_EA_I1);
	Wire.endTransmission();
}

/*
turn B left
*/
void HBridgeI2C::turnBLeft(){
	Wire.beginTransmission(HBridgeI2C_Addr | hbi2caddr);
	ww(HBridgeI2C_EB_I3);
	Wire.endTransmission();
}

/*
turn A Right
*/
void HBridgeI2C::turnARight(){
	Wire.beginTransmission(HBridgeI2C_Addr | hbi2caddr);
	ww(HBridgeI2C_EA_I2);
	Wire.endTransmission();
}

/*
turn B Right
*/
void HBridgeI2C::turnBRight(){
	Wire.beginTransmission(HBridgeI2C_Addr | hbi2caddr);
	ww(HBridgeI2C_EB_I4);
	Wire.endTransmission();
}

/*
turn left
*/
void HBridgeI2C::Left(){
	Wire.beginTransmission(HBridgeI2C_Addr | hbi2caddr);
	ww(HBridgeI2C_EA_I2_EB_I3);
	Wire.endTransmission();
}

/*
turn right
*/
void HBridgeI2C::Right(){
	Wire.beginTransmission(HBridgeI2C_Addr | hbi2caddr);
	ww(HBridgeI2C_EA_I1_EB_I4);
	Wire.endTransmission();
}

/****************************************************************************************************
*****************************************************************************************************
*****************************************************************************************************
											Version v1.00											
*****************************************************************************************************
*****************************************************************************************************
*****************************************************************************************************/