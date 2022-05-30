namespace calculator.unittests;

[TestFixture]
public class CalculatorTests
{
    [TestCase(1,1, ExpectedResult = 2)]
    public int Add(int a, int b)
    {
        return Calculator.Add(a, b);
    }

    [TestCase(1, 1, ExpectedResult = 0)]
    public int Sub(int a, int b)
    {
        return Calculator.Sub(a, b);
    }

    [TestCase(1, 1, ExpectedResult = 1)]
    public int Mult(int a, int b)
    {
        return Calculator.Mult(a, b);
    }

    [TestCase(1, 1, ExpectedResult = 1)]
    public int Div(int a, int b)
    {
        return Calculator.Div(a, b);
    }

    [TestCase(1, 1, ExpectedResult = 0)]
    public int Mod(int a, int b)
    {
        return Calculator.Mod(a, b);
    }
}