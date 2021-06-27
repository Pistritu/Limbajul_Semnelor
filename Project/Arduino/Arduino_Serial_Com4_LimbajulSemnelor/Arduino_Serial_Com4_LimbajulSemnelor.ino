#include "Ardunity.h"
#include "AnalogInput.h"
#include "MPUSeries.h"

AnalogInput aInput2(2, A2);
AnalogInput aInput5(5, A5);
AnalogInput aInput3(3, A3);
AnalogInput aInput4(4, A4);
AnalogInput aInput1(1, A1);
signed char orient_mpu6050_0[9] = { 1, 0, 0, 0, -1, 0, 0, 0, -1 };
MPUSeries mpu6050_0(0, MPU6050, false, orient_mpu6050_0);

void setup()
{
  ArdunityApp.attachController((ArdunityController*)&aInput2);
  ArdunityApp.attachController((ArdunityController*)&aInput5);
  ArdunityApp.attachController((ArdunityController*)&aInput3);
  ArdunityApp.attachController((ArdunityController*)&aInput4);
  ArdunityApp.attachController((ArdunityController*)&aInput1);
  ArdunityApp.attachController((ArdunityController*)&mpu6050_0);
  ArdunityApp.resolution(1024, 4096);
  ArdunityApp.timeout(5000);
  ArdunityApp.begin(115200);
}

void loop()
{
  ArdunityApp.process();
}
