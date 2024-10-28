using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    struct LibraryLocation
    {
        public int Aisle { get; set; }
        public int Shelf { get; set; }
        public LibraryLocation(int aisle, int shelf)
        {
            this.Aisle = aisle;
            this.Shelf = shelf;

        }
        enum BookJenre
        {
            Fiction,
            NonFiction,
            Science,
            Art
        }   
    }
}
