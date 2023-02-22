void setup() {
  Serial.begin(9600);
  pinMode(13,OUTPUT);
  pinMode(A0,INPUT);
  // put your setup code here, to run once:

}



void loop() {
  Serial.println(analogRead(A0));

  char i=0;
  //delay(2000);

  if(Serial.available()>0)
  {
    char numLamp;
    numLamp=(Serial.read()-48);
    while(i<numLamp)
    {
      digitalWrite(13,HIGH);
      delay(250);
      digitalWrite(13,LOW);
      delay(250);
      i++;
    }
    i=0;
  }
  
}
  
  // put your main code here, to run repeatedly:
