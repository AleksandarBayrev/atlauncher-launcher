using System.Diagnostics;

var javaHome = Environment.GetEnvironmentVariable("JAVA_HOME"); // Adjust this if Java is not in your system PATH
var javaPath = javaHome != null ? Path.Combine(javaHome, "bin", "java") : "java";

Console.WriteLine($"Using Java path: {javaPath}");

var process = Process.Start(javaPath, [ "-jar", Path.Combine(Directory.GetCurrentDirectory(), "ATLauncher.jar") ]);

if (process == null)
{
    Console.WriteLine("Failed to start ATLauncher process.");
    return;
}

await process.WaitForExitAsync();

Console.WriteLine("ATLauncher has exited. Press any key to close this window...");
Console.ReadKey();