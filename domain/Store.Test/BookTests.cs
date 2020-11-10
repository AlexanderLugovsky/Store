using System;
using Xunit;

namespace Store.Test
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_WithBlankString_ReturnFalse()
        {
            bool actual = Book.IsIsbn("           ");
            Assert.False(actual);
        } 
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse()
        {
            bool actual = Book.IsIsbn(null);
            Assert.False(actual);
        }
        [Fact]
        public void IsIsbn_InvalidIsbn_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 123");
            Assert.False(actual);
        }
        [Fact]
        public void IsIsbn_WithIsbn10_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 123-456-789 0");
            Assert.True(actual);
        }
        [Fact]
        public void IsIsbn_WithTrashSatrt_ReturnFalse()
        {
            bool actual = Book.IsIsbn("xxx ISBN 123-456-789 0123 yyy");
            Assert.False(actual);
        }
    }
}
