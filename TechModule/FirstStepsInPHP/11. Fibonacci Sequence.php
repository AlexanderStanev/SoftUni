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
    if ($n >= 1){
        echo $firstNumber . ' ';
    }

    if ($n >= 2){
        echo $secondNumber . ' ';
    }

    if ($n >= 3){
        for ($i = 1; $i <= $n; $i++){
            $thirdNumber = $firstNumber + $secondNumber;
            echo $thirdNumber . ' ';
            $firstNumber = $secondNumber;
            $secondNumber = $thirdNumber;
        }
    }
}
?>
</body>
</html>