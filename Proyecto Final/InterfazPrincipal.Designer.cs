
namespace Proyecto_Final
{
    partial class InterfazPrincipal
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
            this.Btn_Sesion = new System.Windows.Forms.Button();
            this.Btn_RealizarAgenda = new System.Windows.Forms.Button();
            this.Btn_LibroAgenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Sesion
            // 
            this.Btn_Sesion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sesion.Location = new System.Drawing.Point(594, 405);
            this.Btn_Sesion.Name = "Btn_Sesion";
            this.Btn_Sesion.Size = new System.Drawing.Size(194, 33);
            this.Btn_Sesion.TabIndex = 0;
            this.Btn_Sesion.Text = "Iniciar Sesion/Registrarse";
            this.Btn_Sesion.UseVisualStyleBackColor = true;
            this.Btn_Sesion.Click += new System.EventHandler(this.Btn_Sesion_Click);
            // 
            // Btn_RealizarAgenda
            // 
            this.Btn_RealizarAgenda.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RealizarAgenda.Location = new System.Drawing.Point(191, 177);
            this.Btn_RealizarAgenda.Name = "Btn_RealizarAgenda";
            this.Btn_RealizarAgenda.Size = new System.Drawing.Size(203, 42);
            this.Btn_RealizarAgenda.TabIndex = 1;
            this.Btn_RealizarAgenda.Text = "Realizar nueva reservacion";
            this.Btn_RealizarAgenda.UseVisualStyleBackColor = true;
            this.Btn_RealizarAgenda.Click += new System.EventHandler(this.Btn_RealizarAgenda_Click);
            // 
            // Btn_LibroAgenda
            // 
            this.Btn_LibroAgenda.Location = new System.Drawing.Point(400, 177);
            this.Btn_LibroAgenda.Name = "Btn_LibroAgenda";
            this.Btn_LibroAgenda.Size = new System.Drawing.Size(173, 42);
            this.Btn_LibroAgenda.TabIndex = 2;
            this.Btn_LibroAgenda.Text = "Abrir agenda";
            this.Btn_LibroAgenda.UseVisualStyleBackColor = true;
            this.Btn_LibroAgenda.Click += new System.EventHandler(this.Btn_LibroAgenda_Click);
            // 
            // InterfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_LibroAgenda);
            this.Controls.Add(this.Btn_RealizarAgenda);
            this.Controls.Add(this.Btn_Sesion);
            this.Name = "InterfazPrincipal";
            this.Text = "InterfazPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Sesion;
        private System.Windows.Forms.Button Btn_RealizarAgenda;
        private System.Windows.Forms.Button Btn_LibroAgenda;
    }
}