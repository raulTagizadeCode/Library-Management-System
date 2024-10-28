using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    abstract class LibraryItem
    {
        public string Title { get; set; }
        public DateTime PublicationYear { get; set; }
        public abstract void DisplayInfo();

        protected LibraryItem(string title, DateTime publicationYear)
        {
            string Title = title;
            DateTime PublicationYear = publicationYear;
        }
    }
    internal class Book: LibraryItem
    {
        public string Genre { get; set; }
        public string Genre { get; set; }
        public void Read()
        {
            Console.WriteLine("Sefiller");
        }
        public override void DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
    internal class Magazine : LibraryItem
    {
        public Magazine(string title, DateTime publicationYear) : base(title, publicationYear)
        {
        }

        public override void DisplayInfo()
        {
            throw new NotImplementedException();
        }

        public void Whrite()
        {
            Console.WriteLine("Maqazin");
        }

    }
    internal class DVD : LibraryItem
    {
        public DVD(string title, DateTime publicationYear) : base(title, publicationYear)
        {
        }

        public override void DisplayInfo()
        {
            throw new NotImplementedException();
        }

        public void Dvdname()
        {
            Console.WriteLine("Music");
        }

    }
}
