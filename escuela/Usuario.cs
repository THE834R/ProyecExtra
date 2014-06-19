/*
 * Creado por SharpDevelop.
 * Usuario: THEBEAR
 * Fecha: 17/06/2014
 * Hora: 05:31 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace escuela
{
	/// <summary>
	/// Description of Usuario.
	/// </summary>
	public class Usuario
	{
		public int Id { get; set; }
       	public string Nombre { get; set; }
       	public string Direccion { get; set; }
       	public string Colonia { get; set; }
       	public string Ciudad {get; set;}
       	public string Email { get; set; }
       	public string Telefono { get; set; }
       	public string Celular { get; set; }
       
		public Usuario()
		{
		}
		
		public Usuario(int Idc, string Nombrec, string Direccionc, string Coloniac, string Ciudadc, string Emailc, string Telefonoc, string Celularc )
		{
		
	  	   this.Id = Idc;
           this.Nombre = Nombrec;
           this.Direccion = Direccionc;
           this.Colonia = Coloniac;
           this.Ciudad = Ciudadc;
           this.Email = Emailc;
           this.Telefono = Telefonoc;
           this.Celular = Celularc;
		              
       }
	}
}
