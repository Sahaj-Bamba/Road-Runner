<?php

include 'connection.php';

	$name = mysqli_real_escape_string($con, $_POST["name"]);
	$score = mysqli_real_escape_string($con, $_POST["score"]);

	$result = $con->query("INSERT INTO `user`(`Name`, `Score`) VALUES ('$name','$score')");

?>

