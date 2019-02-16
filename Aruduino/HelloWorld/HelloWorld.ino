/*
  Hello World.ino
  2013 Copyright (c) Seeed Technology Inc.  All right reserved.

  Author:Loovee
  2013-9-18

  Grove - Serial LCD RGB Backlight demo.

  This library is free software; you can redistribute it and/or
  modify it under the terms of the GNU Lesser General Public
  License as published by the Free Software Foundation; either
  version 2.1 of the License, or (at your option) any later version.

  This library is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
  Lesser General Public License for more details.

  You should have received a copy of the GNU Lesser General Public
  License along with this library; if not, write to the Free Software
  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

#include <Wire.h>
#include "rgb_lcd.h"

rgb_lcd lcd;

const int colorR = 255;
const int colorG = 0;
const int colorB = 0;
int counter = 0;


const int button1 = 8;
const int button2 = 5;
const int button3 = 4;

int analogPin = 3;
int analog = 0;
int analogPin2 = 0;
int analog2 = 0;

void setup() 
{
    // set up the LCD's number of columns and rows:
    lcd.begin(16, 2);
    
    lcd.setRGB(colorR, colorG, colorB);
    pinMode(button2, INPUT);
    pinMode(button2, INPUT);
    // Print a message to the LCD.
    Serial.begin(9600);
    delay(1000);
}

void loop() 
{
    int btn = digitalRead(button1);
    int btn2 = digitalRead(button2);
    int btn3 = digitalRead(button3);
    for(int i = 16; i>=0; i--){
      if(btn3 == 1) {
        lcd.setCursor(i,0);
        lcd.print("#");
        lcd.setCursor(i,1);
        lcd.print("#");
        Serial.print("Button 3, ");
        Serial.println(btn3);
      } 
      else {
        if(btn == 0 && btn2 == 0) {
          lcd.setCursor(i,0);
          lcd.print(" ");
          lcd.setCursor(i,1);
          lcd.print(".");
        } 
        else if(btn == 1 && btn2 == 0){
          lcd.setCursor(i,1);
          lcd.print("|");
          Serial.print("Button 1, ");
          Serial.println(btn);
        } 
        else if(btn == 0 && btn2 == 1){
          lcd.setCursor(i,0);
          lcd.print(".");
          lcd.setCursor(i,1);
          lcd.print("|");
          Serial.print("Button 2, ");
          Serial.println(btn2);
        } 
        else if(btn == 1 && btn2 == 1){
          lcd.setCursor(i,0);
          lcd.print("|");
          lcd.setCursor(i,1);
          lcd.print("|");
          Serial.print("Button 1, ");
          Serial.println(btn);
          Serial.print("Button 2, ");
          Serial.println(btn2);
      }
      }
  
    }
    lcd.setCursor(0,0);
    analog = analogRead(analogPin);
    Serial.println("Analog 1, ");
    Serial.println(analog);
    lcd.setCursor(0,1);
    analog2 = analogRead(analogPin2);
    Serial.print("Analog 2, ");
    Serial.println(analog2);
}

/*********************************************************************************************************
  END FILE
*********************************************************************************************************/
