namespace Novolis.Install.Paths;

public static class NovolisPaths
{
    public static string DataRoot =>
        OperatingSystem.IsWindows()
            ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Novolis")
            : OperatingSystem.IsMacOS()
                ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Library", "Application Support", "Novolis")
                : Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".local", "share", "novolis");

    public static string BinShimDirectory =>
        OperatingSystem.IsWindows()
            ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".novolis", "bin")
            : OperatingSystem.IsLinux()
                ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".local", "bin")
                : Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".novolis", "bin");

    public static string InstalledPackagesDirectory => Path.Combine(DataRoot, "packages");

    public static string StateFile => Path.Combine(DataRoot, "state.json");
}
