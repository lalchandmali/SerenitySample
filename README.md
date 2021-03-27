# SerenitySample
==============================================================================================
For Window machine clone the project and run as it is.
==============================================================================================


===================================MAC Laptop====================================================
Serenity .NET Framework project sample
for connecting to mysql follow below steps in Mac
1. startup.cs change RegisterDataProviders method content
            //DbProviderFactories.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);
            //DbProviderFactories.RegisterFactory("Microsoft.Data.SqlClient", SqlClientFactory.Instance);
           // DbProviderFactories.RegisterFactory("Microsoft.Data.Sqlite", Microsoft.Data.Sqlite.SqliteFactory.Instance);

            // to enable FIREBIRD: add FirebirdSql.Data.FirebirdClient reference, set connections, and uncomment line below
            // DbProviderFactories.RegisterFactory("FirebirdSql.Data.FirebirdClient", FirebirdSql.Data.FirebirdClient.FirebirdClientFactory.Instance);

            // to enable MYSQL: add MySql.Data reference, set connections, and uncomment line below
             DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);

            // to enable POSTGRES: add Npgsql reference, set connections, and uncomment line below
            // DbProviderFactories.RegisterFactory("Npgsql", Npgsql.NpgsqlFactory.Instance);
            
2.Follow mysql installation and connection String setup from given url https://www.c-sharpcorner.com/article/how-to-connect-mysql-with-asp-net-core/

=======================================================================================
for sql server configuration in mac

1. Install docker desktop
2. Install sql server using command line (docker run --name sql_server -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=testPass123' -p 1433:1433 mcr.microsoft.com/mssql/server:2019-latest)
3. Connect to sql database using "mssql -u sa -p" and enter <password> e.g testPass123
4. Create Database SerenitySample_Default_v1 and SerenitySample_Northwind_v1
5. change appSettings connection string to "Server=localhost;Database=SerenitySample_Default_v1;User ID=sa;Password=testPass123" and for northwind "Server=localhost;Database=SerenitySample_Northwind_v1;User ID=sa;Password=testPass123"



build comand: dotnet build
Run Command: dotnet run

