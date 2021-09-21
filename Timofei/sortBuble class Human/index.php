<?php
//Сортировка пузырьком + создаешь новый массив у которого значения больше 25, вывести на экран.
//
//[25, 28, 999, 1, 4, 8, 12, 16]
//
//1. Создать класс человека - вес, рост, имя, фамилия, отчество его свойства.
//2. Создать класс в котором будет метод вывода на экран этого человека, его свойств, то есть в качестве аргумента функции будет выступать класс человека.

 class Human{
     public $weight;
     public $height;
     public $surname;
     public $name;
     public $secondName;

     /**
      * @return mixed
      */
     public function getHeight()
     {
         return $this->height;
     }

     /**
      * @return mixed
      */
     public function getWeight()
     {
         return $this->weight;
     }

     /**
      * @return mixed
      */
     public function getSurname()
     {
         return $this->surname;
     }

     /**
      * @return mixed
      */
     public function getName()
     {
         return $this->name;
     }

     /**
      * @return mixed
      */
     public function getSecondName()
     {
         return $this->secondName;
     }

     public function getInfo(){
        echo 'Фамилия: ' . $this->surname;
        echo '<br>';
        echo 'Имя: ' . $this->name;
        echo '<br>';
        echo 'Отчество: ' . $this->secondName;
        echo '<br>';
        echo 'Рост: ' . $this->height;
        echo '<br>';
        echo 'Вес: ' . $this->weight;
        echo '<br>';
     }
 }

 $people = new Human();
     $people->weight = 99;
     $people->height = 187;
     $people->surname = 'Черных';
     $people->name = 'Тимофей';
     $people->secondName = 'Сергеевич';

     $people->getInfo();

$array = [25, 28, 999, 1, 4, 8, 12, 16];
$temp = null;

for ($i = 1; $i < count($array); $i++) {
        for ($j = 0; $j < count($array) - 1; $j++) {
            if ($array[$j] > $array[$j + 1]){
                $temp = $array[$j + 1];
                $array[$j + 1] = $array[$j];
                $array[$j] = $temp;
            }

        }
    }
    showArray($array);
    bigNumber($array);

   function bigNumber($array){
       $bigNumber = [];

       foreach ($array as $i){
           if ($i >= 25){
               $bigNumber[$i] = $i;
           }
       }

       showArray($bigNumber);
   }

   function showArray($array){
       foreach ($array as $i){
         echo " " . $i;
       }
       echo "<br>";
   }