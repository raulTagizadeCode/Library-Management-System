using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Book : LibraryItem
    {
        public override void DisplayInfo()
        {
            throw new NotImplementedException();
        }
        public string Genre { get; set; }
        public Book(string genre)
        {
            this.Genre = genre;
        }
        public void Read()
        {
            Console.WriteLine("Sefiller");
        }
    }
}