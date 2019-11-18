using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsoleApp
{
    public class Human
    {
        public int age;
        public String Name;

        public Human(String NameInput, DateTime DateofBirth)
        {
            this.Name = NameInput;
            this.age = DateTime.Today.Year - DateofBirth.Year;
        }

        public Human(DateTime DateofBirth)
        {
            this.Name = "Undefined";
            this.age = DateTime.Today.Year - DateofBirth.Year;
        }
        public void  eat(String food)
        {
            return;
        }
        public void travel(String modeOfTransportation)
        {
            return;
        }
    }
}
