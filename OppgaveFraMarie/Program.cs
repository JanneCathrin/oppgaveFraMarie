using System;

namespace OppgaveFraMarie
{
    class Program
    {
        static void Main(string[] args)
        {
            var Person1 = new Lærer("Janne", 24 , "Naturfag" );
            Person1.Bursdag();
            Person1.Teach();

            var Person2 = new Lærer("Erlend", 25, "English");
            Person2.Bursdag();
            Person2.Teach();

            var Person3 = new Lærer("Leon", 3, "Norsk" );
            Person3.Bursdag();
            Person3.Teach();

        }
    }
}


