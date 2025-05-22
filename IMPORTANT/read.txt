<!-- 
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.13
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.13
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.13
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 8.0.3
dotnet ef DbContext scaffold "server=localhost;port=3306;database=lab6;user=root;password=root;" Pomelo.EntityFrameworkCore.MySql 
dotnet watch run
dotnet new page -n Index -o Views\Employees (tạo razorpage)
-->