using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    abstract class Person
    {
        private static int _counter;
        public int Id { get; set; }

        protected Person()
        {
            _counter++;
            Id = _counter;
        }
        public string Name { get; set; }

    }
}
