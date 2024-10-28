using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class LibrarianService : ILibrarianService
    {
        private readonly Librarian[] _librarians;
        public LibrarianService(Librarian[] librarians)
        {
            _librarians = librarians;
        }
        public void CreateLibrarian(Librarian librarian)
        {
            throw new NotImplementedException();
        }

        public void DeleteLibrarian(Librarian librarian, bool isSoftDelete)
        {
            throw new NotImplementedException();
        }

        public Librarian GetAllLibrarians()
        {
            for (int i = 0; i < _librarians.Length; i++)
            {
                var librarian = _librarians[i];
                Console.WriteLine($"ID: {librarian.Id}, Name: {librarian.Name}");
            }
            return default;
        }

        public Librarian? GetLibrarianById(int id)
        {
            for ( int i = 0; i < _librarians.Length; i++)
            {
                if (_librarians[i].Id == id)
                {
                    return _librarians[i];
                }
            }
            return default;
        }

        Librarian[] ILibrarianService.GetAllLibrarians()
        {
            throw new NotImplementedException();
        }
    }
}
