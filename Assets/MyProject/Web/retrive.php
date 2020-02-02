<?php

include 'connection.php';

	$level = mysqli_real_escape_string($con, $_GET["level"]);
	
	$sql = "SELECT * FROM `user` where Level='$level' ORDER BY 'Score' Limit 5 ";

	$result = $con->query($sql);

	if ($result->num_rows <= 0) {
		echo "0";
	}
	else{
		echo $result->num_rows;
	}
	while ($col = $result->fetch_assoc()){
		echo "+" . $col['Name'] . "+" . $col['Score'] ;
	}

?>

 