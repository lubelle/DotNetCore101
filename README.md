##ASP.NET Core
	A cross-platform,high-performance,open-source framework for building modern,cloud-based,Internet-connected applications
	-can be developed and run accross different platforms like windows,macos,linux
	-can be hosted on iis,apache,docker,self-host in your own process
	-one programming model for mvc and web api: both mvc controller class and web api controller inherit from the same Controller base class and return IActionResult(ViewResult,JsonResult)
	-Dependency Injection
	-Testability
	-open-source
	-modular: provides middleware components,both the request and response pipelines are composed using the middleware components with built-in and custom middlewares;
	-https://dotnet.microsoft.com/download to download .net core sdk 2.2 latest as of 2/17/2019
	-project file:no need to unload .csproj first in order to edit it;project files are in sync with file system 
	-AspNetCoreHostingModel:InProcess or OutOfProcess;InProcess hosts the app inside of the IIS worker process(w3wp.exe);OutOfProcess(default) hosting model forward web requests to a backend ASP.NET Core app running the Kestrel server
	-configurations sources in asp.net core:Files(appsettings.json,appsettings.{Environment}.json),User secrets,Environment variables,Command-line arguments
##ASP.NET Core MVC
##ASP.NET Core Identity
##Entity Framework Core