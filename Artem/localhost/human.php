<html>
<body>
<?php

    $request = new Request();

    $human = $request->QueryTranform();
    AddEntry($human);

    echo    "Your surname: " . $human[0] .
            "<br/>Your name: " . $human[1].
            "<br/>Your patronymic: " . $human[2] .
            "<br/>Your age: " . $human[3] .
            "<br/>Your height: " . $human[4] .
            "<br/>Your birthday: " . $human[5];

    function AddEntry($human)
    {
        $db_host = "localhost";
        $db_user = "root";
        $db_password = "";
        $db_name = "test_human";
        $db_table = "humans";

        $db = new mysqli($db_host, $db_user, $db_password, $db_name) or die(var_dump($db));

        if($db)
        {
            echo "Hello!!";
        }

        $query = "INSERT INTO " . $db_table . "
                  VALUES ( DEFAULT, '$human[0]' , '$human[1]', '$human[2]',
                   '$human[3]', '$human[4]', '$human[5]')";

        $result = $db->query($query) or trigger_error(mysqli_error($db). " in " . $query);

        if ($result)
        {
            echo "The entry was added <br/>";
        }


    }

    class Request
    {
        public $query;
        private $url;
        private $post;
        private $previousUrl;
        private $ip;
        private $userAgent;

        function __construct()
        {
            $this->query = &$_GET;
            $this->post = &$_POST;

            $this->url = $_SERVER['REQUEST_URI'];
            $this->url = explode('?', $this->url);
            $this->url = $this->url[0];

            $this->previousUrl = $_SERVER['HTTP_REFERER'];
            $this->ip = $_SERVER['REMOTE_ADDR'];
            $this->userAgent = $_SERVER['HTTP_USER_AGENT'];

            $this->PrintOut();
        }

        public function QueryTranform()
        {
            $i = 0;

            if (isset($this->query))
            {
                foreach ($this->query as $q)
                {
                    $human[$i] = $q;
                    $i++;
                }
            }
            else if (isset($this->post))
            {
                foreach ($this->post as $p)
                {
                    $human[$i] = $p;
                    $i++;
                }
            }

            return $human;
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



