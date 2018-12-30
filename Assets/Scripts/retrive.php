<?php

include 'connection.php';

	$sql = "SELECT * FROM `user_road` ORDER BY 'score' ";

	$result = $con->query($sql);

	if ($result->num_rows <= 0) {
		echo "1";
	}
	else{
		echo "2";
	}
	while ($col = $result->fetch_assoc()){
		echo "+" . $col['name'] . "+" . $col['score'] ;
	}

?>

