

namespace DotnetUbuntuHelper.CommandLine;

using System.CommandLine;

public static class Program
{
    public static int Main(string[] args)
    {
        var rootCommand = new RootCommand(description: "Developer command line tool that helps releasing .NET for Ubuntu");
        return rootCommand.Invoke(args);
    }
}


