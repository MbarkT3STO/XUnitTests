using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Core.Helpers;

namespace App.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_WhenCalled_ReturnsTheSumOfArguments()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(45, 20);

        // Assert
        Assert.Equal(65, result);
    }
}
