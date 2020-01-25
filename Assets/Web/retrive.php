<?php

include 'connection.php';

	$sql = "SELECT * FROM `user` ORDER BY 'Score' Limit 5 ";

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

 