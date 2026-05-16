using Novolis.Install.Commands;

namespace Novolis.Install;

public static class Program
{
    public static Task<int> Main(string[] args) => RunAsync(args);

    internal static Task<int> RunAsync(string[] args)
    {
        var root = CommandBuilder.Build();
        return root.Parse(args).InvokeAsync();
    }
}
