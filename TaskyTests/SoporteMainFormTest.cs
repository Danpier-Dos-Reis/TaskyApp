using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentAssertions;
using FrontEnd;
using System.Configuration;

namespace TaskyTests
{
    public class SoporteMainFormTest
    {
        /// <summary>
        /// Error: to get the connection string we need to init MainForm of the main project (FrontEnd) because it has App.config file.
        /// </summary>
        [Fact]
        public void GetConnectionString_ReturnConnectionString()
        {
            //Arrange
            SoporteMainForm soporteTesMainForm = new SoporteMainForm();

            //Act
            string r = soporteTesMainForm.GetConnectionString();

            //Assert
            r.Should().BeOfType<string>();
            r.Should().NotBeNullOrEmpty();
        }
    }
}
