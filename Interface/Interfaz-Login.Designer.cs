
namespace Interface
{
    partial class Interfaz_Login
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
            this.Btn_Registro = new System.Windows.Forms.Button();
            this.Btn_InicioSesion = new System.Windows.Forms.Button();
            this.Lb_AquaOne = new System.Windows.Forms.Label();
            this.Txt_CorreoE = new System.Windows.Forms.TextBox();
            this.Txt_Contraseña = new System.Windows.Forms.TextBox();
            this.Lb_AquaTwo = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Lb_Correo = new System.Windows.Forms.Label();
            this.Lb_Contraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Registro
            // 
            this.Btn_Registro.Location = new System.Drawing.Point(64, 225);
            this.Btn_Registro.Name = "Btn_Registro";
            this.Btn_Registro.Size = new System.Drawing.Size(75, 23);
            this.Btn_Registro.TabIndex = 0;
            this.Btn_Registro.Text = "Registrarse";
            this.Btn_Registro.UseVisualStyleBackColor = true;
            this.Btn_Registro.Click += new System.EventHandler(this.Btn_Registro_Click);
            // 
            // Btn_InicioSesion
            // 
            this.Btn_InicioSesion.Enabled = false;
            this.Btn_InicioSesion.Location = new System.Drawing.Point(368, 225);
            this.Btn_InicioSesion.Name = "Btn_InicioSesion";
            this.Btn_InicioSesion.Size = new System.Drawing.Size(94, 23);
            this.Btn_InicioSesion.TabIndex = 1;
            this.Btn_InicioSesion.Text = "Iniciar sesión";
            this.Btn_InicioSesion.UseVisualStyleBackColor = true;
            this.Btn_InicioSesion.Click += new System.EventHandler(this.Btn_InicioSesion_Click);
            // 
            // Lb_AquaOne
            // 
            this.Lb_AquaOne.AutoSize = true;
            this.Lb_AquaOne.Location = new System.Drawing.Point(356, 101);
            this.Lb_AquaOne.Name = "Lb_AquaOne";
            this.Lb_AquaOne.Size = new System.Drawing.Size(100, 13);
            this.Lb_AquaOne.TabIndex = 2;
            this.Lb_AquaOne.Text = "Correo Electronico: ";
            // 
            // Txt_CorreoE
            // 
            this.Txt_CorreoE.Location = new System.Drawing.Point(353, 117);
            this.Txt_CorreoE.Name = "Txt_CorreoE";
            this.Txt_CorreoE.Size = new System.Drawing.Size(174, 20);
            this.Txt_CorreoE.TabIndex = 3;
            this.Txt_CorreoE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_CorreoE_KeyUp);
            // 
            // Txt_Contraseña
            // 
            this.Txt_Contraseña.Location = new System.Drawing.Point(359, 177);
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.PasswordChar = '*';
            this.Txt_Contraseña.Size = new System.Drawing.Size(121, 20);
            this.Txt_Contraseña.TabIndex = 4;
            this.Txt_Contraseña.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Contraseña_KeyUp);
            // 
            // Lb_AquaTwo
            // 
            this.Lb_AquaTwo.AutoSize = true;
            this.Lb_AquaTwo.Location = new System.Drawing.Point(359, 161);
            this.Lb_AquaTwo.Name = "Lb_AquaTwo";
            this.Lb_AquaTwo.Size = new System.Drawing.Size(64, 13);
            this.Lb_AquaTwo.TabIndex = 5;
            this.Lb_AquaTwo.Text = "Contraseña:";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Location = new System.Drawing.Point(584, 365);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(102, 22);
            this.Btn_Cerrar.TabIndex = 6;
            this.Btn_Cerrar.Text = "Cerrar programa";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Lb_Correo
            // 
            this.Lb_Correo.AutoSize = true;
            this.Lb_Correo.Location = new System.Drawing.Point(533, 120);
            this.Lb_Correo.Name = "Lb_Correo";
            this.Lb_Correo.Size = new System.Drawing.Size(0, 13);
            this.Lb_Correo.TabIndex = 7;
            // 
            // Lb_Contraseña
            // 
            this.Lb_Contraseña.AutoSize = true;
            this.Lb_Contraseña.Location = new System.Drawing.Point(486, 180);
            this.Lb_Contraseña.Name = "Lb_Contraseña";
            this.Lb_Contraseña.Size = new System.Drawing.Size(0, 13);
            this.Lb_Contraseña.TabIndex = 8;
            // 
            // Interfaz_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Lb_Contraseña);
            this.Controls.Add(this.Lb_Correo);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Lb_AquaTwo);
            this.Controls.Add(this.Txt_Contraseña);
            this.Controls.Add(this.Txt_CorreoE);
            this.Controls.Add(this.Lb_AquaOne);
            this.Controls.Add(this.Btn_InicioSesion);
            this.Controls.Add(this.Btn_Registro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Interfaz_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Registro;
        private System.Windows.Forms.Button Btn_InicioSesion;
        private System.Windows.Forms.Label Lb_AquaOne;
        private System.Windows.Forms.TextBox Txt_CorreoE;
        private System.Windows.Forms.TextBox Txt_Contraseña;
        private System.Windows.Forms.Label Lb_AquaTwo;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label Lb_Correo;
        private System.Windows.Forms.Label Lb_Contraseña;
    }
}