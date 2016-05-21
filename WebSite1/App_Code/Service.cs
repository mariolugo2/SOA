using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
//[System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    StringBuilder sb;

    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string Get_Info(String nombre) {

        StringBuilder sb = new StringBuilder();

        sb.Append("SELECT nombre FROM alumno ");
        sb.AppendFormat("WHERE nombre ='{0}'", nombre);

        MySqlConnection conn;
        conn = connectionManager.GetConnection();
        conn.Open();

        MySqlCommand newCmd = conn.CreateCommand();

        newCmd.CommandType = CommandType.Text;
        newCmd.CommandText = sb.ToString();
        MySqlDataReader sdr = newCmd.ExecuteReader();
        String valor = null;

        if (sdr.Read()) {
            valor = sdr.GetValue(0).ToString();
        }

        conn.Close();
        return valor;
     
    }

    [WebMethod]
    public DataSet Obtener_Todo()
    {

        StringBuilder sb = new StringBuilder();

        sb.Append("SELECT * FROM alumno ");
       // sb.AppendFormat("WHERE campo4 ='{0}'", campo);

        MySqlConnection conn;
        conn = connectionManager.GetConnection();
        conn.Open();

        MySqlCommand newCmd = conn.CreateCommand();

        newCmd.CommandType = CommandType.Text;
        newCmd.CommandText = sb.ToString();
        newCmd.ExecuteNonQuery();

        MySqlDataAdapter da = new MySqlDataAdapter(newCmd);
        DataSet ds = new DataSet();
        da.Fill(ds);

        conn.Close();
        return ds; 

    }

    [WebMethod]
    public string Insertar_nuevo(String matricula,String nombre,String p_apellido,String s_apellido,String fecha_ingreso,String plantel,String carrera, String semestre, String direccion,String correo, String telefono)
    {

        StringBuilder sb = new StringBuilder();

        sb.Append("INSERT INTO alumno VALUES");
        sb.AppendFormat("('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", matricula, nombre, p_apellido, s_apellido, fecha_ingreso, plantel, carrera, semestre, direccion, correo, telefono);

        MySqlConnection conn;
        conn = connectionManager.GetConnection();
        conn.Open();

        MySqlCommand newCmd = conn.CreateCommand();

        newCmd.CommandType = CommandType.Text;
        newCmd.CommandText = sb.ToString();
        MySqlDataReader sdr = newCmd.ExecuteReader();
        String valor = null;

        if (sdr.Read())
        {
            valor = sdr.GetValue(0).ToString();
        }

        conn.Close();
        return valor;

    }

    [WebMethod]
    public string Actualizar(String matricula, String nombre, String p_apellido, String s_apellido, String fecha_ingreso, String plantel, String carrera, String semestre, String direccion, String correo, String telefono)
    {

        StringBuilder sb = new StringBuilder();


        sb.Append(" UPDATE alumno SET");
        sb.AppendFormat(" nombre='{1}',p_apellido='{2}',s_apellido='{3}',fechaingreso='{4}',plantel='{5}',carrera='{6}',semestre='{7}',direccion='{8}',correo='{9}',telefono='{10}' WHERE matricula={0};", matricula, nombre, p_apellido, s_apellido, fecha_ingreso, plantel, carrera, semestre, direccion, correo, telefono);

        MySqlConnection conn;
        conn = connectionManager.GetConnection();
        conn.Open();

        MySqlCommand newCmd = conn.CreateCommand();

        newCmd.CommandType = CommandType.Text;
        newCmd.CommandText = sb.ToString();
        MySqlDataReader sdr = newCmd.ExecuteReader();
        String valor = null;

        if (sdr.Read())
        {
            valor = sdr.GetValue(0).ToString();
        }

        conn.Close();
        return valor;

    }

    [WebMethod]
    public string cuenta_registros()
    {

        StringBuilder sb = new StringBuilder();
       

        sb.Append(" Select count(matricula) FROM alumno");
        

        MySqlConnection conn;
        conn = connectionManager.GetConnection();
        conn.Open();

        MySqlCommand newCmd = conn.CreateCommand();

        newCmd.CommandType = CommandType.Text;
        newCmd.CommandText = sb.ToString();
        MySqlDataReader sdr = newCmd.ExecuteReader();
        String valor = null;

        if (sdr.Read())
        {
            valor = sdr.GetValue(0).ToString();
        }

        conn.Close();
        return valor;

    }
    [WebMethod]
    public string Borra_Registro(String matricula)
    {

        StringBuilder sb = new StringBuilder();


        sb.Append(" DELETE FROM alumno");
        sb.AppendFormat(" WHERE matricula={0};", matricula);

        MySqlConnection conn;
        conn = connectionManager.GetConnection();
        conn.Open();

        MySqlCommand newCmd = conn.CreateCommand();

        newCmd.CommandType = CommandType.Text;
        newCmd.CommandText = sb.ToString();
        MySqlDataReader sdr = newCmd.ExecuteReader();
        String valor = null;

        if (sdr.Read())
        {
            valor = sdr.GetValue(0).ToString();
        }

        conn.Close();
        return valor;

    }
    
}