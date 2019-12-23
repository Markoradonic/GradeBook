using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests  
    {

        // 18:48 
        [Fact] // -> je atribut u C#-u
        public void GetBookReturnsDifferentObjexts()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotEqual(book1, book2);

        }

         public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.Equal("Book 2", book2.Name);

            Assert.True(Object.ReferenceEquals(book1, book2));

        }

         Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
