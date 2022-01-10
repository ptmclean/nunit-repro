using System;
using System.IO;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestProject2;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test2()
    {
        await using var stream = File.AppendText("../../../../TestLog.txt");
        await stream.WriteLineAsync("Running Test 2");
        Console.WriteLine("Running Test 2");
        Assert.Pass();
    }
    
    [Test]
    public async Task Test3()
    {
        await using var stream = File.AppendText("../../../../TestLog.txt");
        await stream.WriteLineAsync("Running Test 3");
        Console.WriteLine("Running Test 3");
        Assert.Pass();
    }
}