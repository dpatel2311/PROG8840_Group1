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
    public void TestInvalidOperation()
    {
        Assert.Equal(0, Evaluator.Eval("#", 6, 2));
    }
}