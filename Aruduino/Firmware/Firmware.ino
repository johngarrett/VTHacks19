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

int prev_analog = 0;
int prev_analog2 = 0;
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
    
    prev_analog = analog;
    prev_analog2 = analog2;

    for(int i = 16; i>=0; i--){
      if(btn3 == 1) { //btn 3 pushed 
        lcd.setCursor(i,0);
        lcd.print("#");
        lcd.setCursor(i,1);
        lcd.print("#");
        Serial.print("C");
      } 
      else {
        if(btn == 0 && btn2 == 0) {
          lcd.setCursor(i,0);
          lcd.print(" ");
          lcd.setCursor(i,1);
          lcd.print(".");
        } 
        else if(btn == 1 && btn2 == 0){ //btn 1 pushed
          lcd.setCursor(i,1);
          lcd.print("|");
          Serial.print("A");
        } 
        else if(btn == 0 && btn2 == 1){ //btn 2 pushed
          lcd.setCursor(i,0);
          lcd.print(".");
          lcd.setCursor(i,1);
          lcd.print("|");
          Serial.print("B");
        } 
        else if(btn == 1 && btn2 == 1){//btn 1 and 2
          lcd.setCursor(i,0);
          lcd.print("|");
          lcd.setCursor(i,1);
          lcd.print("|");
          Serial.print("D");
      }
     }
    }
    lcd.setCursor(0,0);
    checkAnalog();
}

void checkAnalog(){
  delay(200);
    analog = analogRead(analogPin);

    if (analog != prev_analog){
      Serial.print("Z:");
      Serial.println(analog);
    }
    
    lcd.setCursor(0,1);
    
    analog2 = analogRead(analogPin2);
    if (analog2 != prev_analog2){
      Serial.print("X:");
      Serial.println(analog2);
    }  
}
