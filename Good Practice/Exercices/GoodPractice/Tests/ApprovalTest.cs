using System.IO;
using System.Text;
namespace Tests;
public class ApprovalTest
{
    [Fact]
    public void ThirtyDays()
    {
        var fakeoutput = new StringBuilder();
        Console.SetOut(new StringWriter(fakeoutput));
        Console.SetIn(new StringReader("a\n"));

        Program.Main(new string[] { });
        var output = fakeoutput.ToString();

        Assert.Equivalent(GetSourceFileContent(), output);
    }

    private string GetSourceFileContent()
    {
        string readText = File.ReadAllText("./Source/Source.txt");
        return readText;
    }
}