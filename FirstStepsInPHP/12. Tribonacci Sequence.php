<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php
if (isset($_GET['num'])){
    $n = intval($_GET['num']);
    $firstNumber = 1;
    $secondNumber = 1;
    $thirdNumber = 2;
    if ($n >= 1){
        echo $firstNumber . ' ';
    }

    if ($n >= 2){
        echo $secondNumber . ' ';
    }

    if ($n >= 3){
        echo $thirdNumber . ' ';
    }

    if ($n > 3){
        for ($i = 4; $i <= $n; $i++){
            $fourthNumber = $firstNumber + $secondNumber + $thirdNumber;
            echo $fourthNumber . ' ';
            $firstNumber = $secondNumber;
            $secondNumber = $thirdNumber;
            $thirdNumber = $fourthNumber;
        }
    }
}
?>
</body>
</html>