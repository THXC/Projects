#ifndef HBridgeI2C_h
#define HBridgeI2C_h

#define HBridgeI2C_Addr					0x38		//default addr for i2c when using pcf8574ap and A0 A1 A2 are connected to GND
#define HBridgeI2C_Resset				0x00		//resets ports
#define HBridgeI2C_EA_I1				0x11		//Enable A or 1 and Set Input1 to HIGH and Input2 to LOW
#define HBridgeI2C_EA_I2				0x12		//Enable A or 1 and Set Input2 to HIGH and Input1 to LOW
#define HBridgeI2C_EB_I3				0x24		//Enable A or 2 and Set Input3 to HIGH and Input4 to LOW
#define HBridgeI2C_EB_I4				0x28		//Enable A or 2 and Set Input4 to HIGH and Input3 to LOW
#define HBridgeI2C_EA_I1_EB_I3			0x35		//Enable A and B or 1 and 2 and Set Input1 and Input3 to HIGH
#define HBridgeI2C_EA_I2_EB_I3			0x36		//Enable A and B or 1 and 2 and Set Input2 and Input3 to HIGH
#define HBridgeI2C_EA_I1_EB_I4			0x39		//Enable A and B or 1 and 2 and Set Input1 and Input4 to HIGH
#define HBridgeI2C_EA_I2_EB_I4			0x3A		//Enable A and B or 1 and 2 and Set Input2 and Input4 to HIGH

class HBridgeI2C {

public:

	void begin(uint8_t addr);
	void begin(void);

	//move
	void motorAForward();
	void motorBForward();
	void motorForward();
	void motorABackward();
	void motorBBackward();
	void motorBackward();

	//move A left and B right /-/ A right and B left
	void turnALeft();
	void turnBLeft();
	void turnARight();
	void turnBRight();

	//move AB left or right
	void Left();
	void Right();
	void Stop();

private:

    uint8_t hbi2caddr;

};

#endif
/****************************************************************************************************
*****************************************************************************************************
*****************************************************************************************************
											Version v1.00									
*****************************************************************************************************
*****************************************************************************************************
*****************************************************************************************************/