using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit hero = new Unit();
            Squad mainSquad = new Squad();
            Unit warrior1 = new Unit();
            Unit warrior2 = new Unit();
            Unit warrior3 = new Unit();
            Unit warrior4 = new Unit();

            Squad warriors = new Squad();
            warriors.Add(warrior1);
            warriors.Add(warrior2);
            warriors.Add(warrior3);
            warriors.Add(warrior4);

            mainSquad.Add(warriors);
            mainSquad.Add(hero);

            mainSquad.Accept(new Print());
        } 
    }
}