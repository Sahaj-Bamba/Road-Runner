<?php

include 'connection.php';

	$name = mysqli_real_escape_string($con, $_POST["name"]);
	$score = mysqli_real_escape_string($con, $_POST["score"]);
	$level = mysqli_real_escape_string($con, $_POST["level"]);

	$result = $con->query("INSERT INTO `user`(`Name`, `Score`, `Level`) VALUES ('$name','$score','$level')");

?>

