
namespace Interface
{
    partial class Interfaz_ModificarCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_NombreUsuario = new System.Windows.Forms.TextBox();
            this.Txt_CorreoE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_NuevaContraOne = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_NuevaContraTwo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Contraseña = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_ActualizarCuenta = new System.Windows.Forms.Button();
            this.Btn_EliminarCuenta = new System.Windows.Forms.Button();
            this.Lb_Correo = new System.Windows.Forms.Label();
            this.Lb_ContraOne = new System.Windows.Forms.Label();
            this.Lb_ContraTwo = new System.Windows.Forms.Label();
            this.Lb_MismaContra = new System.Windows.Forms.Label();
            this.Lb_Nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.Location = new System.Drawing.Point(754, 491);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Regresar.TabIndex = 0;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.UseVisualStyleBackColor = true;
            this.Btn_Regresar.Click += new System.EventHandler(this.Btn_Regresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de usuario:";
            // 
            // Txt_NombreUsuario
            // 
            this.Txt_NombreUsuario.Location = new System.Drawing.Point(151, 50);
            this.Txt_NombreUsuario.Name = "Txt_NombreUsuario";
            this.Txt_NombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.Txt_NombreUsuario.TabIndex = 2;
            this.Txt_NombreUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_NombreUsuario_KeyUp);
            // 
            // Txt_CorreoE
            // 
            this.Txt_CorreoE.Location = new System.Drawing.Point(151, 110);
            this.Txt_CorreoE.Name = "Txt_CorreoE";
            this.Txt_CorreoE.Size = new System.Drawing.Size(100, 20);
            this.Txt_CorreoE.TabIndex = 4;
            this.Txt_CorreoE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_CorreoE_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Correo electronico:";
            // 
            // Txt_NuevaContraOne
            // 
            this.Txt_NuevaContraOne.Location = new System.Drawing.Point(151, 186);
            this.Txt_NuevaContraOne.Name = "Txt_NuevaContraOne";
            this.Txt_NuevaContraOne.PasswordChar = '*';
            this.Txt_NuevaContraOne.Size = new System.Drawing.Size(100, 20);
            this.Txt_NuevaContraOne.TabIndex = 6;
            this.Txt_NuevaContraOne.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_NuevaContraOne_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nueva contraseña:";
            // 
            // Txt_NuevaContraTwo
            // 
            this.Txt_NuevaContraTwo.Location = new System.Drawing.Point(151, 227);
            this.Txt_NuevaContraTwo.Name = "Txt_NuevaContraTwo";
            this.Txt_NuevaContraTwo.PasswordChar = '*';
            this.Txt_NuevaContraTwo.Size = new System.Drawing.Size(100, 20);
            this.Txt_NuevaContraTwo.TabIndex = 8;
            this.Txt_NuevaContraTwo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_NuevaContraTwo_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Repetir nueva contraseña:";
            // 
            // Txt_Contraseña
            // 
            this.Txt_Contraseña.Location = new System.Drawing.Point(162, 420);
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.PasswordChar = '*';
            this.Txt_Contraseña.Size = new System.Drawing.Size(100, 20);
            this.Txt_Contraseña.TabIndex = 10;
            this.Txt_Contraseña.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Contraseña_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ingresar contraseña actual:";
            // 
            // Btn_ActualizarCuenta
            // 
            this.Btn_ActualizarCuenta.Enabled = false;
            this.Btn_ActualizarCuenta.Location = new System.Drawing.Point(23, 464);
            this.Btn_ActualizarCuenta.Name = "Btn_ActualizarCuenta";
            this.Btn_ActualizarCuenta.Size = new System.Drawing.Size(122, 23);
            this.Btn_ActualizarCuenta.TabIndex = 11;
            this.Btn_ActualizarCuenta.Text = "Actualizar cuenta";
            this.Btn_ActualizarCuenta.UseVisualStyleBackColor = true;
            this.Btn_ActualizarCuenta.Click += new System.EventHandler(this.Btn_ActualizarCuenta_Click);
            // 
            // Btn_EliminarCuenta
            // 
            this.Btn_EliminarCuenta.Enabled = false;
            this.Btn_EliminarCuenta.Location = new System.Drawing.Point(151, 464);
            this.Btn_EliminarCuenta.Name = "Btn_EliminarCuenta";
            this.Btn_EliminarCuenta.Size = new System.Drawing.Size(100, 23);
            this.Btn_EliminarCuenta.TabIndex = 12;
            this.Btn_EliminarCuenta.Text = "Eliminar cuenta";
            this.Btn_EliminarCuenta.UseVisualStyleBackColor = true;
            this.Btn_EliminarCuenta.Click += new System.EventHandler(this.Btn_EliminarCuenta_Click);
            // 
            // Lb_Correo
            // 
            this.Lb_Correo.AutoSize = true;
            this.Lb_Correo.Location = new System.Drawing.Point(257, 113);
            this.Lb_Correo.Name = "Lb_Correo";
            this.Lb_Correo.Size = new System.Drawing.Size(0, 13);
            this.Lb_Correo.TabIndex = 13;
            // 
            // Lb_ContraOne
            // 
            this.Lb_ContraOne.AutoSize = true;
            this.Lb_ContraOne.Location = new System.Drawing.Point(257, 193);
            this.Lb_ContraOne.Name = "Lb_ContraOne";
            this.Lb_ContraOne.Size = new System.Drawing.Size(0, 13);
            this.Lb_ContraOne.TabIndex = 14;
            // 
            // Lb_ContraTwo
            // 
            this.Lb_ContraTwo.AutoSize = true;
            this.Lb_ContraTwo.Location = new System.Drawing.Point(257, 230);
            this.Lb_ContraTwo.Name = "Lb_ContraTwo";
            this.Lb_ContraTwo.Size = new System.Drawing.Size(0, 13);
            this.Lb_ContraTwo.TabIndex = 15;
            // 
            // Lb_MismaContra
            // 
            this.Lb_MismaContra.AutoSize = true;
            this.Lb_MismaContra.Location = new System.Drawing.Point(257, 258);
            this.Lb_MismaContra.Name = "Lb_MismaContra";
            this.Lb_MismaContra.Size = new System.Drawing.Size(0, 13);
            this.Lb_MismaContra.TabIndex = 16;
            // 
            // Lb_Nombre
            // 
            this.Lb_Nombre.AutoSize = true;
            this.Lb_Nombre.Location = new System.Drawing.Point(257, 53);
            this.Lb_Nombre.Name = "Lb_Nombre";
            this.Lb_Nombre.Size = new System.Drawing.Size(0, 13);
            this.Lb_Nombre.TabIndex = 17;
            // 
            // Interfaz_ModificarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 526);
            this.ControlBox = false;
            this.Controls.Add(this.Lb_Nombre);
            this.Controls.Add(this.Lb_MismaContra);
            this.Controls.Add(this.Lb_ContraTwo);
            this.Controls.Add(this.Lb_ContraOne);
            this.Controls.Add(this.Lb_Correo);
            this.Controls.Add(this.Btn_EliminarCuenta);
            this.Controls.Add(this.Btn_ActualizarCuenta);
            this.Controls.Add(this.Txt_Contraseña);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_NuevaContraTwo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_NuevaContraOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_CorreoE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_NombreUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Regresar);
            this.Name = "Interfaz_ModificarCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz_ModificarCuenta";
            this.Load += new System.EventHandler(this.Interfaz_ModificarCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_NombreUsuario;
        private System.Windows.Forms.TextBox Txt_CorreoE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_NuevaContraOne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_NuevaContraTwo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Contraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_ActualizarCuenta;
        private System.Windows.Forms.Button Btn_EliminarCuenta;
        private System.Windows.Forms.Label Lb_Correo;
        private System.Windows.Forms.Label Lb_ContraOne;
        private System.Windows.Forms.Label Lb_ContraTwo;
        private System.Windows.Forms.Label Lb_MismaContra;
        private System.Windows.Forms.Label Lb_Nombre;
    }
}