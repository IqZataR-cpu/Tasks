<html>
<body>
<?php

    $surname = $_POST['surname'];
    $name = $_POST['name'];
    $patronymic = $_POST['patronymic'];
    $age = $_POST['age'];
    $height = $_POST['height'];
    $birthday = $_POST['birthday'];

    AddEntry($surname, $name, $patronymic, $age, $height, $birthday);

    echo    "Your surname: " . $surname .
            "<br/>Your name: " . $name.
            "<br/>Your patronymic: " . $patronymic .
            "<br/>Your age: " . $age .
            "<br/>Your height: " . $height .
            "<br/>Your birthday: " . $birthday;

    function AddEntry($surname, $name, $patronymic, $age, $height, $birthday)
    {
        $db_host = "localhost";
        $db_user = "root";
        $db_password = "";
        $db_name = "test_human";
        $db_table = "humans";


        $db = new mysqli($db_host, $db_user, $db_password, $db_name) or die(var_dump($db));
        if($db){
            echo "Hello!!";
        }

        $query = "INSERT INTO " . $db_table . "
                  VALUES ( DEFAULT ,'$surname' , '$name', '$patronymic', '$age', '$height',  '$birthday')";

        $result = $db->query($query) or trigger_error(mysqli_error($db). " in " . $query);

        if($result)
        {
            echo "The entry was added <br/>";
        }


    }
?>
<form action="index.php">
    <input type="submit" value="Добавить запись">
</form>
<form action="humans.php">
    <input type="submit" value="Просмотреть все записи">
</form>
</body>
</html>



