# DotNetCoreCleanArch
Template for asp net core web app clean architecture using MediatR and CQRS

add-migration "Initial Migration" -Context ApplicationDbContext

update-database


### Error 
	1. Assets file project.assets.json not found. Run a NuGet package restore
https://stackoverflow.com/questions/48440223/assets-file-project-assets-json-not-found-run-a-nuget-package-restore
	2. The operation failed as details for project could not be loaded
		Simply restart vs


Infra.Data
Create DBContext Class
Add Below Nuget Packages
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
