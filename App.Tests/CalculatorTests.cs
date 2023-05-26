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

    [Fact]
    public void Subtract_WhenCalled_ReturnsTheDifferenceOfArguments()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Subtract(45, 20);

        // Assert
        Assert.Equal(25, result);
    }

    [Fact]
    public void Divide_WhenCalled_ReturnsTheQuotientOfArguments()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Divide(10, 2);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_WhenCalledWithZeroDivisor_ThrowsDivideByZeroException()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));

        // Assert
        Assert.Equal("The denominator cannot be zero.", result.Message);
    }
}
