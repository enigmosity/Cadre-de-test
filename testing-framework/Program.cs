// See https://aka.ms/new-console-template for more information

// test 1 - testing that we know when a method has run, and when it has failed.
var test = new WasRun("TestMethod");
Console.WriteLine(test.wasRun);
test.Run();
Console.WriteLine(test.wasRun);

public class WasRun
{
    public bool wasRun;
    public string testName;

    public WasRun(string testMethod)
    {
        wasRun = false;
        testName = testMethod;
    }

    public void Run()
    {
        var testMethod = Type.GetType("WasRun");

        testMethod.GetMethod(testName).Invoke(this, null);
    }

    public void TestMethod()
    {
        wasRun = true;
    }
}



