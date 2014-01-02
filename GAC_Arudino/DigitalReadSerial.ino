/*
  DigitalReadSerial
 Reads a digital input on pin 2, prints the result to the serial monitor 
 
 This example code is in the public domain.
 */

// digital pin 2 has a pushbutton attached to it. Give it a name:
int pushButton = 2;
int led = 13;
String readString;
int relay1 = 1;
int relay2 = 2;

// the setup routine runs once when you press reset:
void setup() 
{  
  // initialize serial communication at 9600 bits per second:
  Serial.begin(9600);
  // make the pushbutton's pin an input:
  //pinMode(pushButton, INPUT);
  pinMode(led, OUTPUT);
  pinMode(relay1, OUTPUT);
  pinMode(relay2, OUTPUT);
  Serial.println("swishboard-1.0"); // so I can keep track of what is loaded
}

// the loop routine runs over and over again forever:
void loop() 
{
  // read the input pin:
  //int buttonState = digitalRead(pushButton);
  // print out the state of the button:
  //Serial.println(buttonState);
  //delay(1);        // delay in between reads for stability
  while (Serial.available()) 
  {
    delay(3);  //delay to allow buffer to fill 
    if (Serial.available() >0) 
    {
      char c = Serial.read();  //gets one byte from serial buffer
      readString += c; //makes the string readString
    }
  }
  if (readString != "")
  {
       if(readString == "on1")
       {
         digitalWrite(relay1, HIGH);
       }
       if(readString == "on2")
       {
         digitalWrite(relay2, HIGH);
       }
       if(readString == "onall")
       {
         digitalWrite(relay1, HIGH);
         digitalWrite(relay2, HIGH);
       }
       if(readString == "off1")
       {
         digitalWrite(relay1, LOW);
       }
       if(readString == "off2")
       {
         digitalWrite(relay2, LOW);
       }
       if(readString == "offall")
       {
         digitalWrite(relay1, LOW);
         digitalWrite(relay2, LOW);
       }
       if(readString == "ledtest")
       {
         digitalWrite(led, HIGH);
       }
     readString = "";
  }
  
}



