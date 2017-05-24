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
    if ($n == 1 || $n == 0){
        echo 1;
    }
    else {
        $result = 1;
        for ($i = 1; $i <= $n; $i++) {
            $result = $result * $i;
        }
        echo $result;
    }
}
?>
</body>
</html>