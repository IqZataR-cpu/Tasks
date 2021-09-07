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
<br/>
<br/>
<br/>
<form name="Human" method="POST" action="human.php">
    Введите ваши персональные данные   <br/>
    <input type="text" name="surname" required placeholder="Фамилия">
    <input type="text" name="name" required placeholder="Имя">
    <input type="text" name="patronymic" required placeholder="Отчество">
    <input type="number" name="age" required placeholder="Возраст" max=100>
    <input type="number" name="height" required placeholder="Рост" max=250>
    <input type="date" name="birthday" required>
    <input type="submit" value="Добавить">
</form>
<form action="humans.php">
    <input type="submit" value="Просмотреть все записи">
</form>
<?php

    $surname = isset($_GET['surname']) ? $_GET['surname'] : "Зайцев ";
    $name = isset($_GET['name']) ? $_GET['name'] : "Артем ";
    $patronymic = isset($_GET['patronymic']) ? $_GET['patronymic'] : "Сергеевич";
    $age = isset($_GET['age']) ? $_GET['age'] : 21;;
    $height = isset($_GET['height']) ? $_GET['height'] : 178;
    $birthday = isset($_GET['birthday']) ? $_GET['birthday'] : '2021-07-22' ;

    $me = new Human($surname, $name, $patronymic, $age, $height, $birthday);

    $me->PrintOut();

    class Human
    {
        private $surname;
        private $name;
        private $patronymic;
        private $age;
        private $height;
        private $birthday;

        public function __construct($surname, $name, $patronymic, $age, $height, $birthday)
        {
            $this->surname = $surname;
            $this->name = $name;
            $this->patronymic = $patronymic;
            $this->age = $age;
            $this->height = $height;
            $this->birthday = $birthday;
        }

        public function PrintOut()
        {
            echo 'My name is ' . $this->surname . $this->name . $this->patronymic .
                 '<br/>Age: ' . $this->age .
                 '<br/>Height: ' . $this->height .
                 '<br/>Birthday: ' . $this->birthday;
        }
    }

?>
</body>
</html>
