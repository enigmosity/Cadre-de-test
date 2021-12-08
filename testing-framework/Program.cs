// See https://aka.ms/new-console-template for more information

var test = new WasRun("TestMethod");
Console.WriteLine(test.wasRun);
test.TestMethod();
Console.WriteLine(test.wasRun);

public class WasRun
{
    public bool wasRun;

    public WasRun(string testMethod)
    {
        wasRun = false;
    }

    public void TestMethod()
    {
        wasRun = true;
    }
}

