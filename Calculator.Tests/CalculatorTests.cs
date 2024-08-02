namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void TestAdd()
    {
        Assert.Equal(6L, Add.Eval(1L, 5L));
    }
    [Fact]
    public void TestAddInvalid()
    {
        Assert.Equal(2, Add.Eval(1L, 0L));
    }
    [Fact]
    public void TestSubtract()
    {
        Assert.Equal(4L, Subtract.Eval(12L, 8L));
    }
    [Fact]
    public void TestMult()
    {
        Assert.Equal(6L, Multiply.Eval(2L, 3L));
    }
    public void TestDivd()
    {
        Assert.Equal(4L, Divide.Eval(12L, 3L));
    }
    public void TestSqr()
    {
        Assert.Equal(16L, Square.Eval(4L, 1L));
    }
    [Fact]
    public void TestPer()
    {
        Assert.Equal(8L, Percentage.Eval(25L, 200L));
    }
    [Fact]
    public void TestAbs()
    {
        Assert.Equal(25.0F, Absolute.Eval(-25.0F,-25.0F));
    }
    [Fact]
    public void TestExp()
    {
        Assert.Equal(8F, Exponent.Eval(2F, 3F));
    }
    [Fact]
    public void TestAddOperation()
    {
        Assert.Equal(8, Evaluator.Eval("+", 6, 2));
    }
    [Fact]
    public void TestSubtractOperation()
    {
        Assert.Equal(16, Evaluator.Eval("-", 18, 2));
    }
    [Fact]
    public void TestMultiplyOperation()
    {
        Assert.Equal(12, Evaluator.Eval("*", 6, 2));
    }
    [Fact]
    public void TestDivideOperation()
    {
        Assert.Equal(3, Evaluator.Eval("/", 6, 2));
    }
    [Fact]
    public void TestSuquareOperation()
    {
        Assert.Equal(9, Evaluator.Eval("@", 3, 1));
    }
    [Fact]
    public void TestInvalidOperation()
    {
        Assert.Equal(0, Evaluator.Eval("#", 6, 2));
    }
}