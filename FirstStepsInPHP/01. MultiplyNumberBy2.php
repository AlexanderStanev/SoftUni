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
<?php
if (isset($_GET['num'])){
echo 'The result is: ' . $result = intval($_GET['num']) * 2;}?>
</form>
</body>
</html>

