# SerenitySample
Serenity .NET Framework project sample
for connecting to mysql follow below steps
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
            
2. https://www.c-sharpcorner.com/article/how-to-connect-mysql-with-asp-net-core/
