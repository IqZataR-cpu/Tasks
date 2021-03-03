using System;
using OOP.Orcs;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc person = new Shaman(100, 50, 5, 20, 8);
            Orc injuredArcher = new Archer(19, 70, 10, 15, 12 );
            Orc friendlyNPC = new Warrior(200, 0, 20, 10, 5);

            person.SayMeetings();
            injuredArcher.SayMeetings();
            friendlyNPC.SayMeetings();


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
