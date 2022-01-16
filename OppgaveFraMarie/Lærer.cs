using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppgaveFraMarie
{
    public class Lærer
    {
        public string _navn;
        public string _fag;
        public int _age;
       


        public Lærer(string name, int age, string fag)
        {
            _navn = name;
            _fag = fag;
            _age = age;
        
        }
      

        public void Bursdag()
        {
            _age += 1;
            
        }

     public void Teach()
        {
           Console.WriteLine("Velkommen til " + _fag + " jeg heter " + _navn + " og er " + _age);
        } 
    }
}
