<?php

echo "<h3>Candy Crush Test<h3>";
require_once "../CandyCrush/class_candy_crash.php";
$test= new CandyCrash();

echo"<br>";
echo"Test 1: ";
/*$test -> pravoagolnik(5,5);*/
$test -> howLong([1,2,3,4], 0);
?>