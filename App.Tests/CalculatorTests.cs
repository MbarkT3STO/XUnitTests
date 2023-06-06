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

	[Theory]
	[InlineData(45, 20, 25)]
	[InlineData(45, -20, 65)]
	[InlineData(45, 0, 45)]
	public void Subtract_WhenCalled_ReturnsTheDifferenceOfArguments(int a, int b, int expected)
	{
		// Arrange
		var calculator = new Calculator();

		// Act
		var actual = calculator.Subtract(a, b);

		// Assert
		Assert.Equal(expected, actual);
	}
}
