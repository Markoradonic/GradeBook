using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests  
    {


        [Fact] // -> je atribut u C#-u 
        public void CSharpCanPassByref()
        {
            var book1 = GetBook("Book 1"); // kreirani objekat
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);


        }

        private void GetBookSetName(ref Book book, string name)
        {
              book = new Book(name);  // na ovaj nacin kreiramo novo book objekat i novu referencu
               // book.Name = name; // na ovaj nacin uzimamo vrednost iz varijable book1, iz kriranog objekta (this is not working with the same object "var book1" that we worked with up )
        }



        [Fact] // -> je atribut u C#-u 
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1"); // kreirani objekat
            GetBookSetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);


        }

        private void GetBookSetName(Book book, string name)
        {
              book = new Book(name);  // na ovaj nacin kreiramo novo book objekat i novu referencu
               // book.Name = name; // na ovaj nacin uzimamo vrednost iz varijable book1, iz kriranog objekta (this is not working with the same object "var book1" that we worked with up )
        }


        [Fact] // -> je atribut u C#-u 
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);


        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        // od 17:02
        [Fact] // -> je atribut u C#-u 
        public void GetBookReturnsDifferentObjexts()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotEqual(book1, book2); 

        }



        // two variables can reference the same object.
         public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1; // this line of code take a value of the variable "var book1" 

            Assert.Same(book1, book2);
            //sAssert.Equal("Book 2", book2.Name);

            Assert.True(Object.ReferenceEquals(book1, book2));
            // values can be references

        }

        Book GetBook(string name) // this identifier tho the left of the method name, describing the return type. (Book)
        {
            return new Book(name);
        }
    }
}


// object lowest base type in the C#
