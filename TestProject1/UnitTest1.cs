using System;
using System.IO;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        await using var stream = File.AppendText("../../../../TestLog.txt");
        await stream.WriteLineAsync("Running Test 1");
        Console.WriteLine("Running Test 1");
        Assert.Pass();
    }
    
    [Test]
    public async Task Test4()
    {
        await using var stream = File.AppendText("../../../../TestLog.txt");
        await stream.WriteLineAsync("Running Test 4");
        Console.WriteLine("Running Test 4");
        Assert.Pass();
    }
}