<html>
<head>
</head>
<body>
<form name="Fibonacci" method="GET" action="<?=$_SERVER['PHP_SELF']?>">
    Введите крайний элемент ряда Фибоначи   <br/>
    <input type="text" name="quantity">
    <input type="submit">
</form>


<?php
    echo "Hello world <br/>";

    PrintRow();

    $quantity = isset($_GET['quantity']) ? $_GET['quantity'] : 10;
    if ($quantity == 1)
    {
        $fibo = 0;
        PrintFibo($fibo,$quantity);
    }
    else
    {
        $fibo = implode(",",    Fibonacci($quantity));
        PrintFibo($fibo,$quantity);
    }


    function PrintRow()
    {
        echo "Ряд натуральных чисел от 1 до 10: ";

        for ($i = 1; $i <= 10; $i++)
        {
            echo "$i ";
        }
    }

    function PrintFibo($fibo, $quantity)
    {
        echo "<br/>  Ряд Фибоначи до $quantity-го элемента: $fibo";
    }

    function Fibonacci($quantity)
    {
        $fib = [0, 1];

        for ($i = end($fib); $i <= $quantity - 2; $i++) {
            $nextFib = $fib[$i] + $fib[$i - 1];
            array_push($fib, $nextFib);
        }

        return $fib;
    }



?>

<form name="Fibonacci" method="GET" action="<?=$_SERVER['PHP_SELF']?>">
    Введите ваши персональные данные   <br/>
    <input type="text" name="FIO" >
    <input type="text" name="age">
    <input type="text" name="height">
    <input type="date" name="birthday">
    <input type="submit">
</form>
<?php

    $FIO = isset($_GET['FIO']) ? $_GET['FIO'] : "Зайцев Артем Сергеевич";
    $age = isset($_GET['age']) ? $_GET['age'] : 21;;
    $height = isset($_GET['height']) ? $_GET['height'] : 178;
    $birthday = isset($_GET['birthday']) ? $_GET['birthday'] : '2021-07-22' ;

    $me = new Human($FIO, $age, $height, $birthday);

    $me->PrintData();

    class Human
    {
        private $FIO;
        private $age;
        private $height;
        private $birthday;

        public function __construct($fio, $age, $height, $birthday)
        {
            $this->FIO = $fio;
            $this->age = $age;
            $this->height = $height;
            $this->birthday = $birthday;
        }

        public function PrintData()
        {
            echo 'My name is ' . $this->FIO
                . '<br/>Age: ' . $this->age
                . '<br/>Height: ' . $this->height
                . '<br/>Birthday: ' . $this->birthday;
        }
    }

?>
</body>
</html>
