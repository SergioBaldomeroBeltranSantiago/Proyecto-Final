
namespace Interface
{
    partial class Interfaz_Registro
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
            this.Btn_IniciarRegistro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_NuevoCorreo = new System.Windows.Forms.TextBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Txt_NuevoNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_NuevaContraseñaOne = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_NuevaContraseñaTwo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_CodigoAdmin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Lb_Correo = new System.Windows.Forms.Label();
            this.Lb_ContraseñaOne = new System.Windows.Forms.Label();
            this.Lb_ContraseñaTwo = new System.Windows.Forms.Label();
            this.Lb_MismaContraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_IniciarRegistro
            // 
            this.Btn_IniciarRegistro.Enabled = false;
            this.Btn_IniciarRegistro.Location = new System.Drawing.Point(44, 356);
            this.Btn_IniciarRegistro.Name = "Btn_IniciarRegistro";
            this.Btn_IniciarRegistro.Size = new System.Drawing.Size(75, 23);
            this.Btn_IniciarRegistro.TabIndex = 0;
            this.Btn_IniciarRegistro.Text = "Registrarse";
            this.Btn_IniciarRegistro.UseVisualStyleBackColor = true;
            this.Btn_IniciarRegistro.Click += new System.EventHandler(this.Btn_IniciarRegistro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "correo";
            // 
            // Txt_NuevoCorreo
            // 
            this.Txt_NuevoCorreo.Location = new System.Drawing.Point(201, 73);
            this.Txt_NuevoCorreo.Name = "Txt_NuevoCorreo";
            this.Txt_NuevoCorreo.Size = new System.Drawing.Size(100, 20);
            this.Txt_NuevoCorreo.TabIndex = 2;
            this.Txt_NuevoCorreo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_NuevoCorreo_KeyUp);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(181, 356);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 3;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Txt_NuevoNombre
            // 
            this.Txt_NuevoNombre.Location = new System.Drawing.Point(201, 118);
            this.Txt_NuevoNombre.Name = "Txt_NuevoNombre";
            this.Txt_NuevoNombre.Size = new System.Drawing.Size(100, 20);
            this.Txt_NuevoNombre.TabIndex = 5;
            this.Txt_NuevoNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_NuevoNombre_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "nombre de usuario";
            // 
            // Txt_NuevaContraseñaOne
            // 
            this.Txt_NuevaContraseñaOne.Location = new System.Drawing.Point(201, 163);
            this.Txt_NuevaContraseñaOne.Name = "Txt_NuevaContraseñaOne";
            this.Txt_NuevaContraseñaOne.Size = new System.Drawing.Size(100, 20);
            this.Txt_NuevaContraseñaOne.TabIndex = 7;
            this.Txt_NuevaContraseñaOne.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_NuevaContraseñaOne_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "contraseña";
            // 
            // Txt_NuevaContraseñaTwo
            // 
            this.Txt_NuevaContraseñaTwo.Location = new System.Drawing.Point(201, 200);
            this.Txt_NuevaContraseñaTwo.Name = "Txt_NuevaContraseñaTwo";
            this.Txt_NuevaContraseñaTwo.Size = new System.Drawing.Size(100, 20);
            this.Txt_NuevaContraseñaTwo.TabIndex = 9;
            this.Txt_NuevaContraseñaTwo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_NuevaContraseñaTwo_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "confirmar contraseña";
            // 
            // Txt_CodigoAdmin
            // 
            this.Txt_CodigoAdmin.Location = new System.Drawing.Point(190, 251);
            this.Txt_CodigoAdmin.Name = "Txt_CodigoAdmin";
            this.Txt_CodigoAdmin.Size = new System.Drawing.Size(100, 20);
            this.Txt_CodigoAdmin.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "(Opcional)codigo";
            // 
            // Lb_Correo
            // 
            this.Lb_Correo.AutoSize = true;
            this.Lb_Correo.Location = new System.Drawing.Point(307, 76);
            this.Lb_Correo.Name = "Lb_Correo";
            this.Lb_Correo.Size = new System.Drawing.Size(0, 13);
            this.Lb_Correo.TabIndex = 12;
            // 
            // Lb_ContraseñaOne
            // 
            this.Lb_ContraseñaOne.AutoSize = true;
            this.Lb_ContraseñaOne.Location = new System.Drawing.Point(307, 166);
            this.Lb_ContraseñaOne.Name = "Lb_ContraseñaOne";
            this.Lb_ContraseñaOne.Size = new System.Drawing.Size(0, 13);
            this.Lb_ContraseñaOne.TabIndex = 14;
            // 
            // Lb_ContraseñaTwo
            // 
            this.Lb_ContraseñaTwo.AutoSize = true;
            this.Lb_ContraseñaTwo.Location = new System.Drawing.Point(307, 203);
            this.Lb_ContraseñaTwo.Name = "Lb_ContraseñaTwo";
            this.Lb_ContraseñaTwo.Size = new System.Drawing.Size(0, 13);
            this.Lb_ContraseñaTwo.TabIndex = 15;
            // 
            // Lb_MismaContraseña
            // 
            this.Lb_MismaContraseña.AutoSize = true;
            this.Lb_MismaContraseña.Location = new System.Drawing.Point(460, 203);
            this.Lb_MismaContraseña.Name = "Lb_MismaContraseña";
            this.Lb_MismaContraseña.Size = new System.Drawing.Size(0, 13);
            this.Lb_MismaContraseña.TabIndex = 16;
            // 
            // Interfaz_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Lb_MismaContraseña);
            this.Controls.Add(this.Lb_ContraseñaTwo);
            this.Controls.Add(this.Lb_ContraseñaOne);
            this.Controls.Add(this.Lb_Correo);
            this.Controls.Add(this.Txt_CodigoAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_NuevaContraseñaTwo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_NuevaContraseñaOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_NuevoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Txt_NuevoCorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_IniciarRegistro);
            this.Name = "Interfaz_Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz_Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_IniciarRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_NuevoCorreo;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.TextBox Txt_NuevoNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_NuevaContraseñaOne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_NuevaContraseñaTwo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_CodigoAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lb_Correo;
        private System.Windows.Forms.Label Lb_ContraseñaOne;
        private System.Windows.Forms.Label Lb_ContraseñaTwo;
        private System.Windows.Forms.Label Lb_MismaContraseña;
    }
}