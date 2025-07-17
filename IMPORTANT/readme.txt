<!-- 
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.13
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.13
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.13
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 8.0.3
dotnet add package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation (For hotreload)
dotnet add package Microsoft.AspNetCore.Identity
dotnet ef DbContext scaffold "server=localhost;port=3306;database=lab6;user=root;password=root;" Pomelo.EntityFrameworkCore.MySql 
dotnet ef dbcontext scaffold "Server=localhost\SQLEXPRESS;Initial Catalog=introSE_database;User ID=;Password=;TrustServerCertificate=True;Trusted_Connection=true" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models/SQL_Server -f
dotnet watch run
dotnet new page -n Index -o Views\Employees (tạo razorpage)
-->

connect SQL Server with nodejs:
1. npm init -y
2. npm install msnodesqlv8 --save