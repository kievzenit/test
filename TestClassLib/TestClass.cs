namespace TestClassLib;

public class TestClass
{
    public int Add(int a, int b)
    {
        if (a > b)
        {
            return -1;
        }

        return a + b;
    }
}
