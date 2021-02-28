void setup(){
  //set baud rate to 9600
  Serial.begin(9600);
  //set pin 13 to OUTPUT mode
  pinMode( 13, OUTPUT);
}

void loop(){
  //if button on analog pin A0 is pressed
  if(analogRead(A0) == 0)
    //Sends "RIGHT" to Serial
    Serial.println("RIGHT");
  //if button on analog pin A1 is pressed
  if(analogRead(A1) == 0)
    //Sends "LEFT" to Serial
    Serial.println("LEFT");
  //if button on analog pin A2 is pressed
  if(analogRead(A2) == 0)
    //Sends "FIRE" to Serial
    Serial.println("FIRE");
  //Read data from Unity
  int abc = Serial.read();
  switch(abc){
    case '1' :
      //Produce sound from Active buzzer
      tone(13, 900 , 500);
      break;
  }
  //Wait for 0.02 seconds
  delay(20);
  
}
