
namespace escuela
{
	partial class Nuevo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtColonia = new System.Windows.Forms.TextBox();
			this.txtCiudad = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtCelular = new System.Windows.Forms.TextBox();
			this.BtnGuardar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(12, 35);
			this.txtNombre.MaxLength = 10;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(373, 20);
			this.txtNombre.TabIndex = 0;
			this.txtNombre.TextChanged += new System.EventHandler(this.TxtCodigoTextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(266, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nombre Y Primer Apellido";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(33, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Colonia";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(32, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Ciudad";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(32, 225);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "Tel. casa";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(32, 260);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 7;
			this.label6.Text = "Cel.";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(33, 190);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 8;
			this.label7.Text = "email";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(33, 77);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 10;
			this.label9.Text = "Direccion";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(103, 77);
			this.txtDireccion.MaxLength = 10;
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(282, 20);
			this.txtDireccion.TabIndex = 11;
			// 
			// txtColonia
			// 
			this.txtColonia.Location = new System.Drawing.Point(103, 110);
			this.txtColonia.MaxLength = 10;
			this.txtColonia.Name = "txtColonia";
			this.txtColonia.Size = new System.Drawing.Size(282, 20);
			this.txtColonia.TabIndex = 12;
			// 
			// txtCiudad
			// 
			this.txtCiudad.Location = new System.Drawing.Point(103, 145);
			this.txtCiudad.MaxLength = 10;
			this.txtCiudad.Name = "txtCiudad";
			this.txtCiudad.Size = new System.Drawing.Size(282, 20);
			this.txtCiudad.TabIndex = 13;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(103, 187);
			this.txtEmail.MaxLength = 10;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(282, 20);
			this.txtEmail.TabIndex = 14;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(103, 222);
			this.txtTelefono.MaxLength = 10;
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(125, 20);
			this.txtTelefono.TabIndex = 15;
			// 
			// txtCelular
			// 
			this.txtCelular.Location = new System.Drawing.Point(103, 260);
			this.txtCelular.MaxLength = 10;
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(125, 20);
			this.txtCelular.TabIndex = 16;
			// 
			// BtnGuardar
			// 
			this.BtnGuardar.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnGuardar.Location = new System.Drawing.Point(150, 358);
			this.BtnGuardar.Name = "BtnGuardar";
			this.BtnGuardar.Size = new System.Drawing.Size(128, 71);
			this.BtnGuardar.TabIndex = 20;
			this.BtnGuardar.Text = "GUARDAR";
			this.BtnGuardar.UseVisualStyleBackColor = true;
			this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// Nuevo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 457);
			this.Controls.Add(this.BtnGuardar);
			this.Controls.Add(this.txtCelular);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtCiudad);
			this.Controls.Add(this.txtColonia);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNombre);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Nuevo";
			this.Text = "AGENDA Y DIRECTORIO TELEFONICO";
			this.Load += new System.EventHandler(this.NuevoLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button BtnGuardar;
		private System.Windows.Forms.TextBox txtCelular;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtCiudad;
		private System.Windows.Forms.TextBox txtColonia;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		
		void TxtCodigoTextChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void NuevoLoad(object sender, System.EventArgs e)
		{
			
		}
		
		void TxtNombreTextChanged(object sender, System.EventArgs e)
		{
			
		}
		
		
	}
}
