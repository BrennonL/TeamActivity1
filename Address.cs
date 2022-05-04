using System;

namespace Cse210_Unit02_Ta
{
    public class Address
    {
        public string _street;
        public string _City;
        public string _State;

        public void DisplayMailingLabel()
        {
            Console.WriteLine($"Street:{_street}, ");
            Console.Write($"City:{_City}, ");
            Console.Write($"State:{_State},");
        }
        
    }
}
