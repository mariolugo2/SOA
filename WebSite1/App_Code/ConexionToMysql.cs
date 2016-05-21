using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for ConexionToMysql
/// </summary>
public class connectionManager
{
    public static MySqlConnection NewCon;
    public static string ConStr = "Server=localhost;Port=3306;Database=soa;Uid=root;Pwd=root;";

    public static MySqlConnection GetConnection()
    {
        NewCon = new MySqlConnection(ConStr);
        return NewCon;
    }
}