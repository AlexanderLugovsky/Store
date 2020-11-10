﻿using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Store.Test
{
    public class BookServiceTests
    {
        [Fact]
        public void GatAllByQuery_WithIsbn_CallsGetAllByIsbn()
        {
            var bookRepositoryStub = new Mock<IBookRepository>();
            bookRepositoryStub.Setup(x => x.GetAllByIsbn(It.IsAny<string>()))
                .Returns(new[] { new Book(1, "", "", "") });
            bookRepositoryStub.Setup(x => x.GetAllByTitleOrAuthor(It.IsAny<string>()))
                .Returns(new[] { new Book(2, "", "", "") });

            var bookService = new BookService(bookRepositoryStub.Object);
            var validIsbn = "ISBN 12345 - 67890";
            var actual = bookService.GatAllByQuery(validIsbn);
            
            Assert.Collection(actual, book => Assert.Equal(1, book.Id));
        }
    }
}