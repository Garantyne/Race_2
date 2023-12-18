using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_2.Entitis
{

    internal class Car
    {
        public string Name {  get; set; }
        public int Speed {  get; set; }
        public int Boost {  get; set; }
        private Random rand = new Random();

        public event EventHandler eh;

        public Car() { }
        public Car(string name, int boost)
        {
            Name = name;
            Boost = boost;            
        }

        public int Run()
        {
            Speed += rand.Next(0, Boost);
            return Speed;
        }

        public override string ToString()
        {
            return $"{Name} пришел к финишу!";
        }
    }
}
