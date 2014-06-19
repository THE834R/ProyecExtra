
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace escuela
{
	/// <summary>
	/// Description of Alumnos.
	/// </summary>
	public class Alumnos : MySQL
	{
		public static int AgregarContacto( Usuario contactoc)
 	{
 		int retorno = 0;
 		
 		MySqlCommand comando = new MySqlCommand( string.Format("Insert into agenda (Nombre, Direccion, Colonia, Ciudad, Email, Telefono, Celular) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
 		                                                       contactoc.Nombre, contactoc.Direccion, contactoc.Colonia, contactoc.Ciudad, contactoc.Email, contactoc.Telefono, contactoc.Celular), MySQL.ObtenerConexion());
 		retorno = comando.ExecuteNonQuery();
 		return retorno;
 	}
	
 	public static List<Usuario> BuscarContacto(string Nombrec )
 	{
 		List<Usuario>_lista = new List<Usuario>();	
 																																		//muestra por letra
 		MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Id, Nombre, Direccion, Colonia, Ciudad, Email, Telefono, Celular FROM agenda where Nombre LIKE '%{0}%' ", Nombrec), MySQL.ObtenerConexion());
 		MySqlDataReader _reader = _comando.ExecuteReader();
 		while (_reader.Read())
 		{
 			Usuario contactoc = new Usuario();
 			
 			contactoc.Id = _reader.GetInt32(0);
 			contactoc.Nombre = _reader.GetString(1);
 			contactoc.Direccion = _reader.GetString(2);
 			contactoc.Colonia = _reader.GetString(3);
 			contactoc.Ciudad = _reader.GetString(4);
 			contactoc.Email = _reader.GetString(5);
 			contactoc.Telefono = _reader.GetString(6);
 			contactoc.Celular = _reader.GetString(7);
 			
 			
 			_lista.Add(contactoc);
 		}
 		return _lista;
 	}
 	
 	public static Usuario ObtenerContacto(int Idc)
 	{
 		Usuario contactoc = new Usuario();
 		MySqlConnection conexion = MySQL.ObtenerConexion();
 		
 		MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Id, Nombre, Direccion,Colonia, Ciudad, Email, Telefono, Celular FROM agenda where Id ='{0}' ", Idc),
 		MySQL.ObtenerConexion());
 		MySqlDataReader _reader = _comando.ExecuteReader();
 		while (_reader.Read())
 		{
 			
 			contactoc.Id = _reader.GetInt32(0);
 			contactoc.Nombre = _reader.GetString(1);
 			contactoc.Direccion = _reader.GetString(2);
 			contactoc.Colonia = _reader.GetString(3);
 			contactoc.Ciudad = _reader.GetString(4);
 			contactoc.Email = _reader.GetString(5);
 			contactoc.Telefono = _reader.GetString(6);
 			contactoc.Celular = _reader.GetString(7);
 			
 			
 		                                         	
 	  	 }
 			conexion.Close();
 			return contactoc;
 		                                                       
 		}
 	
 	public static int EditarContacto(Usuario contactoc)
 	{
 		int retorno =0;
 		MySqlConnection conexion = MySQL.ObtenerConexion();
 		
 		MySqlCommand comando = new MySqlCommand(string.Format("Update agenda set Nombre='{0}', Direccion='{1}', Colonia='{2}', Ciudad='{3}', Email='{4}', Telefono='{5}', Celular='{6}' where Id={7}",
 		                                                      contactoc.Nombre, contactoc.Direccion, contactoc.Colonia, contactoc.Ciudad, contactoc.Email, contactoc.Telefono , contactoc.Celular), MySQL.ObtenerConexion());
 		retorno = comando.ExecuteNonQuery();
 		conexion.Close();
 		return retorno;
 	}
 	
 	
 	
	}
}
