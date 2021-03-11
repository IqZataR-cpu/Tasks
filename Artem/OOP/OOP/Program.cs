using System;
using OOP.Orcs;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {//По созданию конструкторов классов всё верно, но я бы инкапсулировал статы в класс, т.е. без возможности их определить/изменить извне (Ты так сделал с начальной позицией в орке)
            Orc person = new Shaman(100, 50, 5, 20, 8);
            Orc injuredArcher = new Archer(19, 70, 10, 15, 12 );
            Orc friendlyNPC = new Warrior(200, 0, 20, 10, 5);

            person.SayMeetings();
            injuredArcher.SayMeetings();
            friendlyNPC.SayMeetings(); //Лишний энтер


            person.Print();
            injuredArcher.Print();
            friendlyNPC.Print();

            friendlyNPC.Attack(injuredArcher);
            injuredArcher.Attack(friendlyNPC);
            person.Attack(injuredArcher);

            person.Print();
            injuredArcher.Print();
            friendlyNPC.Print();

            person.Rest();
            friendlyNPC.Rest();
            person.MoveBack();
            friendlyNPC.MoveForward();

            person.Print();
            friendlyNPC.Print();
        }
    }
}
//По всем классам ты забыл поставить пробелы между методами 