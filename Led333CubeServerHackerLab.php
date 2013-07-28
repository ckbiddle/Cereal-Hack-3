<?php

  $conn = mysqli_connect( 'sql3.freemysqlhosting.net', 'sql314986', 'gP4*cG1%', 'sql314986' );
  // $conn = mysqli_connect( '68.178.142.189', 'ledmatrix', 'M@trix01', 'ledmatrix' );

  $action = '';
		
		if ( isset( $_GET['action'] ))
		{
		  $action = $_GET['action'];
				
				if ( $action == 'newledstatus' )
				{
				  $statusString = $_GET['statusstring'];

      $sql = "insert into led_indicators " .
						       "( status_string ) " .
													"values " .
													"( 'ledstatus/" . $statusString . "/*' )";

      mysqli_query( $conn, $sql ) or die ( '-1' );
				}
		}
		else
		{
    $sql = "select status_string " .
		         "from led_indicators " .
		         "where request_id = " .
							  		"( select max( request_id ) " .
						  			"  from led_indicators " .
								  	")";
									
	  	$result = mysqli_query( $conn, $sql ) or die ( 'ledstatus/111111111111111111111111111/*' );

    if ( $row = mysqli_fetch_array( $result ))
	  	{
		    echo $row['status_string'];
	  	}
		}

  mysqli_close( $conn );

// echo 'ledstatus/101000101000000000000000000/*';
		              // 123456789012345678901234567
											   		//          1          2
  
?>