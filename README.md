# C# hello

[![Deploy to FadeHost](https://fadehost.com/deploy-button.svg)](https://laplace.fadehost.com/register?intent=app&repo=https://github.com/FadeHost/example-dotnet-hello)

A C# console program as small as they come, for FadeHost app hosting: one
project file, no packages, prints a line every minute. Push it and FadeHost
finds the project file, publishes it in Release on the server and runs the
assembly with the .NET 10 host.

- Nothing to configure: no build command, no start command
- The publish output and the NuGet packages are cached on the app volume, so a
  restart does not publish again
- Replace `Program.cs` with your bot or worker and keep the rest

```
hello-dotnet.csproj   the project
Program.cs            the program
```
