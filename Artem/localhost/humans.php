<html>
<body>
<?php
    $db_host = "localhost";
    $db_user = "root";
    $db_password = "";
    $db_name = "test_human";
    $db_table = "humans";
    $i = 0;

    $db = new mysqli($db_host, $db_user, $db_password, $db_name) or die(var_dump($db));
    $result = new HumanRepository($db);
    $result = $result->all($db_table);

    while ($row = mysqli_fetch_array($result))
    {
        $human = new Human($row);
        $humans[$i] = $human;
        $i++;
    }

    foreach ($humans as $h)
    {
        $human = $h;
        $human->PrintOut();
    }


    class HumanRepository
    {
        private $db;
        private $query;
        private $result;

        function __construct($db)
        {
            $this->db= $db;
        }

        public function all($db_table)
        {
            $this->query = "SELECT * FROM " . $db_table;

            return $this->result = $this->db->query($this->query);
        }

    }

    class Human
    {
        private $ID;
        private $surname;
        private $name;
        private $patronymic;
        private $age;
        private $height;
        private $birthday;

        function __construct($row)
        {
                 $this->ID = $row['ID'];
                 $this->surname = $row['surname'];
                 $this->name = $row['name'];
                 $this->patronymic = $row['patronymic'];
                 $this->age = $row['age'];
                 $this->height = $row['height'];
                 $this->birthday = $row['birthday'];

        }

        public function PrintOut()
        {
             echo "ID: " . $this->ID .
                  " Surname: " . $this->surname .
                  " Name: " . $this->name.
                  " Patronymic: " . $this->patronymic .
                  " Age: " . $this->age .
                  " Height: " . $this->height .
                  " Birthday: " . $this->birthday . "<br/>";
        }
    }
?>
<a href="index.php" type="submit">Добавить запись</a>
</body>
</html>






