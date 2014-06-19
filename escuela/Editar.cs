
using System;
using System.Drawing;
using System.Windows.Forms;

namespace escuela
{
	/// <summary>
	/// Description of Editar.
	/// </summary>
	public partial class Editar : Form
	{
		private MainForm main;
		private string id;
		
		public Editar(MainForm main, string id)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.main = main;
			this.id = id;
		}
		
		public Usuario ContactoActual{ get; set; }
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) ||
			    string.IsNullOrWhiteSpace(txtColonia.Text) || string.IsNullOrWhiteSpace(txtCiudad.Text) ||
			    string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) ||
			    string.IsNullOrWhiteSpace(txtCelular.Text)){

                MessageBox.Show("Hay Uno o mas Campos Vacios!", " Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else{
			
				Usuario contactoc = new Usuario();
					contactoc.Nombre = txtNombre.Text.Trim();
					contactoc.Direccion = txtDireccion.Text.Trim();
					contactoc.Colonia = txtColonia.Text.Trim();
					contactoc.Ciudad = txtCiudad.Text.Trim();
					contactoc.Email = txtEmail.Text.Trim();
					contactoc.Telefono = txtTelefono.Text.Trim();
					contactoc.Celular = txtCelular.Text.Trim();
					
			//	if (contactoc.EditarContacto(contactoc) > 0){
			//		this.actualizarTabla();
                	MessageBox.Show("Los datos del contacto " + contactoc.Nombre + " se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            	
                	this.txtNombre.Clear();
			  			this.txtDireccion.Clear();
			  			this.txtColonia.Clear();
			  			this.txtCiudad.Clear();
			  			this.txtEmail.Clear();
			  			this.txtTelefono.Clear();
			  			this.txtCelular.Clear();	
					
					//Deshabilitar();
					MessageBox.Show("No se pudo actualizar", " Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            
				} 
			
			          
			}
		}
		
		
		    //void TxtContactoTextChanged(object sender, EventArgs e)
		//{
			
		//}
	}
