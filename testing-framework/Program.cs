// See https://aka.ms/new-console-template for more information

// test 1 - testing that we know when a method has run, and when it has failed.
var test = new WasRun("TestMethod");
Console.WriteLine(test.wasRun);
test.TestMethod();
Console.WriteLine(test.wasRun);

// test 2 - dynamically calling test methods
var secondTest = new WasRun("TestMethodTwo");
secondTest.TestMethod();
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

    public void TestMethodTwo()
    {
        wasRun = false;
    }
}



