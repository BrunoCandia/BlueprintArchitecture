
1-The project "Blueprint.Domain" contains the entities.
2-The project "Blueprint.Infraestructure" contains the Context, Migrations and Configuration; and also the packages:
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="6.0.2" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.2" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="6.0.2">
3-The project "Blueprint.WebApi" contains the package:
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="6.0.2">
4-To create the first migration:    
    Set "Blueprint.WebApi" as Start Up project.
    Use the Package Manager Console in Visual Studio.
    Select "Blueprint.Infraestructure" as Default project, I added the Migrations folder manually before execute the next step.
    Run the command "add-migration Initial".
5-To apply the migration, run the command "update-database".

Note:
1-To fix the validation,
Microsoft.EntityFrameworkCore.Model.Validation[20601]
      The 'bool' property 'IsActive' on entity type 'Group' is configured with a database-generated default. 
      This default will always be used for inserts when the property has the value 'false', since this is the CLR default for the 'bool' type. 
      Consider using the nullable 'bool?' type instead, so that the default will only be used for inserts when the property value is 'null'.

we have to set as nullable the boolean field IsActive. From "public bool IsActive { get; set; }" to "public bool? IsActive { get; set; }"

2-Links to review:
https://docs.microsoft.com/en-us/ef/core/extensions/
https://docs.microsoft.com/en-us/ef/core/dbcontext-configuration/
https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli


DomainServices = UseCases