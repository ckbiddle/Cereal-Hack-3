// Chris Biddle, 07/05/2013
// BEGIN - HTTP server stuff

#include <SPI.h>
#include <Ethernet.h>
#include <string.h>

byte mac[] = { 0x90, 0xA2, 0xDA, 0x00, 0xDE, 0x88 };
char server[] = "www.chrisbiddle.us";

// Static IP address to use if DHCP fails to assign
IPAddress ip( 172, 16, 200, 29 );

// Initialize Ethernet client library
EthernetClient client;

// Chris Biddle, 07/05/2013 - HTTP server stuff
#define bufferMax 512
int bufferSize;
char buffer[bufferMax];
char param[28];  // one extra for the '\0' terminator.

unsigned long startTime;
unsigned long endTime;
unsigned long elapsedTime = 5000;

void setup()
{
  Serial.begin( 9600 );

  Serial.println( "Connecting to server" );

  if ( Ethernet.begin( mac ) == 0 )
  {
    Serial.println( "Failed to configure Ethernet using DHCP" );
    Ethernet.begin( mac, ip );
  }
  
  for( int pinNumber = 2; pinNumber <= 10; pinNumber++ )
  {
    pinMode( pinNumber, OUTPUT );
    digitalWrite( pinNumber, LOW );
  }
  
  pinMode( A0, OUTPUT );
  digitalWrite( A0, LOW );
  
  pinMode( A1, OUTPUT );
  digitalWrite( A1, LOW );
  
  pinMode( A2, OUTPUT );
  digitalWrite( A2, LOW );
  
  // give shield time to initialize
  delay( 5000 );

}

int pinArray[27][2] = {{ 2, A0 }, { 3, A0 }, { 4, A0 }, { 5, A0 }, { 6, A0 }, { 7, A0 }, { 8, A0 }, { 9, A0 }, { 10, A0 },
                       { 2, A1 }, { 3, A1 }, { 4, A1 }, { 5, A1 }, { 6, A1 }, { 7, A1 }, { 8, A1 }, { 9, A1 }, { 10, A1 },                     
                       { 2, A2 }, { 3, A2 }, { 4, A2 }, { 5, A2 }, { 6, A2 }, { 7, A2 }, { 8, A2 }, { 9, A2 }, { 10, A2 }
                      };

void loop()
{
  if ( clientConnect( server ))
  {
    int statusCode = -1;

    bufferResponse( client );
    setParam( &statusCode );
    client.stop();
  }

  startTime = millis();
  endTime = millis();

  while ( endTime < startTime + elapsedTime )
  {
    for ( int jnx = 0; jnx <= 26; jnx++ )
    {  
      if ( param[jnx] == '1' )
      {
        /*
        Serial.print( "pinArray[" );
        Serial.print( jnx );
        Serial.print( "][0]=" );
        Serial.print( pinArray[jnx][0] );
        Serial.println();

        Serial.print( "pinArray[" );
        Serial.print( jnx );
        Serial.print( "][1]=" );
        Serial.print( pinArray[jnx][1] );
        Serial.println();
        */
        
        digitalWrite( pinArray[jnx][0], HIGH );
        digitalWrite( pinArray[jnx][1], HIGH );
        
        delay( 1 );
      }

      digitalWrite( pinArray[jnx][0], LOW );
      digitalWrite( pinArray[jnx][1], LOW );
    }  
  
    endTime = millis();
  }
}

bool clientConnect( char* pServer )
{
  bool success = false;
  
  Serial.println( "Connecting..." );

  // If you get a connection, report back via serial:
  if ( client.connect( pServer, 80 ))
  {
    Serial.println( "Connected!" );
    client.println( "GET /ArduinoController/Led333CubeServerHackerLab.php HTTP/1.1" );
    client.println( "Host: www.chrisbiddle.us" );
    client.println();  // Needed in order for the server to recognize the completion of the request
    
    success = true;
  } 
  else
  {
    // If you didn't get a connection to the server:
    Serial.println( "Connection failed." );
  }
  
  return success;
}

void bufferResponse( EthernetClient client ) // Sets buffer[] and bufferSize
{
  bufferSize = 0;

  Serial.println( "In bufferResponse()" );
  unsigned long startTime = millis();

  // Clear buffer
  for ( int inx = 0; inx < bufferMax; inx++ )
  {
    buffer[inx] = NULL;
  }
 
  while ( client.connected())
  {
    if ( client.available())
    {
      char c = client.read();

      if ( c == '*' )
        break;
      else
        if ( bufferSize < bufferMax )
          buffer[bufferSize++] = c;
        else
          break;
    }
  }
  
  Serial.print( "bufferSize=" );
  Serial.print( bufferSize );
  Serial.println();
  
  Serial.print( "Leaving bufferResponse. Elapsed time: " );
  Serial.print( millis() - startTime );
  Serial.println( " ms" );
}

void setParam( int* statusCode )
{
  Serial.println( "In setParam() ..." );
  Serial.println( buffer );

  char* stringFromSlash = strstr( buffer, "ledstatus/" ) + 10;
  
  Serial.print( "stringFromSlash=" );
  Serial.print( stringFromSlash );
  Serial.println();
  
  param[0] = '\0';
  strncat( param, stringFromSlash, 27 ); 
  
  Serial.print( "param=" );
  Serial.println( param );
  
  *statusCode = 0;
}