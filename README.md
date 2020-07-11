# DotNetCoreCleanArch
Template for asp net core web app clean architecture using MediatR and CQRS

add-migration "Initial Migration" -Context ApplicationDbContext

update-database


### Error 
	1. Assets file project.assets.json not found. Run a NuGet package restore
https://stackoverflow.com/questions/48440223/assets-file-project-assets-json-not-found-run-a-nuget-package-restore
	2. The operation failed as details for project could not be loaded
		Simply restart vs
	3. IApplicationBuilder does not contain UseDataBaseErrorPage() method

		Add Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore nuget package
	4. Unable to create an object of type 'UniversityDBContext'. For the different patterns supported at design time, see https://go.microsoft.com/fwlink/?linkid=851728
		Error when adding migration
		Just have only one project for startup instead of multiple

Infra.Data Project: Class Library
Create DBContext Class
Add Below Nuget Packages
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

Create new Connection string on appsettings.json from Presentation project
Inject the connect string in  Startup.cs
Add migration 
update database you need to specify the context when you have multiple dbcontext

 update-database -Context UniversityDBContext

 Core/Application Project: Services, View Model