using CIDemo_Team13;
using System;
using Xunit;

public class CalculatorTests
{
    private readonly ICalculator _calculator;

    public CalculatorTests()
    {
        // Initialiserer med den konkrete implementering
        _calculator = new Calculator();
    }

    #region Add Tests
    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int a = 5;
        int b = 7;
        int expected = 12;

        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
    {
        // Arrange
        int a = 10;
        int b = -5;
        int expected = 5;

        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int a = -8;
        int b = -3;
        int expected = -11;

        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Add_WhenOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MaxValue;
        int b = 1;

        // Act & Assert
        var exception = Record.Exception(() => _calculator.Add(a, b));
        Assert.IsType<OverflowException>(exception);
    }
    #endregion

    #region Subtract Tests
    [Fact]
    public void Subtract_PositiveNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        int a = 10;
        int b = 5;
        int expected = 5;

        // Act
        int result = _calculator.Subtract(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Subtract_PositiveAndNegativeNumber_ReturnsCorrectDifference()
    {
        // Arrange
        int a = 10;
        int b = -5;
        int expected = 15;

        // Act
        int result = _calculator.Subtract(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Subtract_SecondNumberLarger_ReturnsNegativeDifference()
    {
        // Arrange
        int a = 5;
        int b = 10;
        int expected = -5;

        // Act
        int result = _calculator.Subtract(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Subtract_WhenOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MinValue;
        int b = 1;

        // Act & Assert
        var exception = Record.Exception(() => _calculator.Subtract(a, b));
        Assert.IsType<OverflowException>(exception);
    }
    #endregion

    #region Multiply Tests
    [Fact]
    public void Multiply_TwoPositiveNumbers_ReturnsCorrectProduct()
    {
        // Arrange
        int a = 5;
        int b = 7;
        int expected = 35;

        // Act
        int result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Multiply_PositiveAndNegativeNumber_ReturnsNegativeProduct()
    {
        // Arrange
        int a = 10;
        int b = -5;
        int expected = -50;

        // Act
        int result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Multiply_TwoNegativeNumbers_ReturnsPositiveProduct()
    {
        // Arrange
        int a = -8;
        int b = -3;
        int expected = 24;

        // Act
        int result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Multiply_WithZero_ReturnsZero()
    {
        // Arrange
        int a = 42;
        int b = 0;
        int expected = 0;

        // Act
        int result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Multiply_WhenOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MaxValue;
        int b = 2;

        // Act & Assert
        var exception = Record.Exception(() => _calculator.Multiply(a, b));
        Assert.IsType<OverflowException>(exception);
    }
    #endregion

    #region Divide Tests
    [Fact]
    public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
    {
        // Arrange
        int a = 10;
        int b = 2;
        int expected = 5;

        // Act
        int result = _calculator.Divide(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Divide_PositiveAndNegativeNumber_ReturnsNegativeQuotient()
    {
        // Arrange
        int a = 10;
        int b = -2;
        int expected = -5;

        // Act
        int result = _calculator.Divide(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Divide_WithRemainder_ReturnsTruncatedQuotient()
    {
        // Arrange
        int a = 7;
        int b = 2;
        int expected = 3; // Integer division truncates

        // Act
        int result = _calculator.Divide(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int a = 42;
        int b = 0;

        // Act & Assert
        var exception = Record.Exception(() => _calculator.Divide(a, b));
        Assert.IsType<DivideByZeroException>(exception);
    }
    #endregion
    #region Power Tests
    [Fact]
    public void Power_PositiveBaseAndExponent_ReturnsCorrectResult()
    {
        // Arrange
        double a = 2;
        double b = 3;
        double expected = 8;

        // Act
        double result = _calculator.Power(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Power_BaseZeroAndPositiveExponent_ReturnsZero()
    {
        // Arrange
        double a = 0;
        double b = 5;
        double expected = 0;

        // Act
        double result = _calculator.Power(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Power_BaseZeroAndNonPositiveExponent_ThrowsArgumentException()
    {
        // Arrange
        double a = 0;
        double b = -1;

        // Act & Assert
        var exception = Record.Exception(() => _calculator.Power(a, b));
        Assert.IsType<ArgumentException>(exception);
        Assert.Equal("Ugyldig eksponentiation: 0^0 eller 0 til negativ eksponent", exception.Message);
    }
    #endregion

    #region SquareRoot Tests
    [Fact]
    public void SquareRoot_PositiveNumber_ReturnsCorrectResult()
    {
        // Arrange
        double a = 16;
        double expected = 4;

        // Act
        double result = _calculator.SquareRoot(a);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SquareRoot_Zero_ReturnsZero()
    {
        // Arrange
        double a = 0;
        double expected = 0;

        // Act
        double result = _calculator.SquareRoot(a);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SquareRoot_NegativeNumber_ThrowsArgumentException()
    {
        // Arrange
        double a = -4;

        // Act & Assert
        var exception = Record.Exception(() => _calculator.SquareRoot(a));
        Assert.IsType<ArgumentException>(exception);
        Assert.Equal("Kvadratroden af et negativt tal er ikke defineret i reelle tal", exception.Message);
    }
    #endregion
}