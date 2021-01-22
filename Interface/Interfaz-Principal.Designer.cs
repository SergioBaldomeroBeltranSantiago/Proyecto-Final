
namespace Interface
{
    partial class Interfaz_Principal
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
            this.p_Cuenta = new System.Windows.Forms.Panel();
            this.lb_AquaOne = new System.Windows.Forms.Label();
            this.lb_NombreUsuario = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Btn_CerrarSesion = new System.Windows.Forms.Button();
            this.Btn_ModifCuenta = new System.Windows.Forms.Button();
            this.tp_InfoHotel = new System.Windows.Forms.TabPage();
            this.tp_Habitaciones = new System.Windows.Forms.TabPage();
            this.tp_Principal = new System.Windows.Forms.TabPage();
            this.tc_Menu = new System.Windows.Forms.TabControl();
            this.p_Cuenta.SuspendLayout();
            this.tc_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_Cuenta
            // 
            this.p_Cuenta.Controls.Add(this.Btn_ModifCuenta);
            this.p_Cuenta.Controls.Add(this.Btn_CerrarSesion);
            this.p_Cuenta.Controls.Add(this.Btn_Cerrar);
            this.p_Cuenta.Controls.Add(this.lb_NombreUsuario);
            this.p_Cuenta.Controls.Add(this.lb_AquaOne);
            this.p_Cuenta.Location = new System.Drawing.Point(1013, 12);
            this.p_Cuenta.Name = "p_Cuenta";
            this.p_Cuenta.Size = new System.Drawing.Size(221, 588);
            this.p_Cuenta.TabIndex = 1;
            // 
            // lb_AquaOne
            // 
            this.lb_AquaOne.AutoSize = true;
            this.lb_AquaOne.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AquaOne.Location = new System.Drawing.Point(61, 22);
            this.lb_AquaOne.Name = "lb_AquaOne";
            this.lb_AquaOne.Size = new System.Drawing.Size(100, 25);
            this.lb_AquaOne.TabIndex = 0;
            this.lb_AquaOne.Text = "Bienvenido";
            // 
            // lb_NombreUsuario
            // 
            this.lb_NombreUsuario.AutoSize = true;
            this.lb_NombreUsuario.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NombreUsuario.Location = new System.Drawing.Point(61, 47);
            this.lb_NombreUsuario.Name = "lb_NombreUsuario";
            this.lb_NombreUsuario.Size = new System.Drawing.Size(0, 25);
            this.lb_NombreUsuario.TabIndex = 1;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.Location = new System.Drawing.Point(34, 536);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(154, 35);
            this.Btn_Cerrar.TabIndex = 2;
            this.Btn_Cerrar.Text = "Cerrar programa";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_CerrarSesion
            // 
            this.Btn_CerrarSesion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CerrarSesion.Location = new System.Drawing.Point(34, 481);
            this.Btn_CerrarSesion.Name = "Btn_CerrarSesion";
            this.Btn_CerrarSesion.Size = new System.Drawing.Size(154, 35);
            this.Btn_CerrarSesion.TabIndex = 3;
            this.Btn_CerrarSesion.Text = "Cerrar sesion";
            this.Btn_CerrarSesion.UseVisualStyleBackColor = true;
            this.Btn_CerrarSesion.Click += new System.EventHandler(this.Btn_CerrarSesion_Click);
            // 
            // Btn_ModifCuenta
            // 
            this.Btn_ModifCuenta.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ModifCuenta.Location = new System.Drawing.Point(34, 426);
            this.Btn_ModifCuenta.Name = "Btn_ModifCuenta";
            this.Btn_ModifCuenta.Size = new System.Drawing.Size(154, 35);
            this.Btn_ModifCuenta.TabIndex = 4;
            this.Btn_ModifCuenta.Text = "Tu perfil";
            this.Btn_ModifCuenta.UseVisualStyleBackColor = true;
            this.Btn_ModifCuenta.Click += new System.EventHandler(this.Btn_ModifCuenta_Click);
            // 
            // tp_InfoHotel
            // 
            this.tp_InfoHotel.Location = new System.Drawing.Point(4, 22);
            this.tp_InfoHotel.Name = "tp_InfoHotel";
            this.tp_InfoHotel.Padding = new System.Windows.Forms.Padding(3);
            this.tp_InfoHotel.Size = new System.Drawing.Size(987, 566);
            this.tp_InfoHotel.TabIndex = 2;
            this.tp_InfoHotel.Text = "Informacion del hotel";
            this.tp_InfoHotel.UseVisualStyleBackColor = true;
            // 
            // tp_Habitaciones
            // 
            this.tp_Habitaciones.Location = new System.Drawing.Point(4, 22);
            this.tp_Habitaciones.Name = "tp_Habitaciones";
            this.tp_Habitaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Habitaciones.Size = new System.Drawing.Size(987, 566);
            this.tp_Habitaciones.TabIndex = 1;
            this.tp_Habitaciones.Text = "Habitaciones";
            this.tp_Habitaciones.UseVisualStyleBackColor = true;
            // 
            // tp_Principal
            // 
            this.tp_Principal.Location = new System.Drawing.Point(4, 22);
            this.tp_Principal.Name = "tp_Principal";
            this.tp_Principal.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Principal.Size = new System.Drawing.Size(987, 566);
            this.tp_Principal.TabIndex = 0;
            this.tp_Principal.Text = "Pagina principal";
            this.tp_Principal.UseVisualStyleBackColor = true;
            // 
            // tc_Menu
            // 
            this.tc_Menu.Controls.Add(this.tp_Principal);
            this.tc_Menu.Controls.Add(this.tp_Habitaciones);
            this.tc_Menu.Controls.Add(this.tp_InfoHotel);
            this.tc_Menu.Location = new System.Drawing.Point(12, 12);
            this.tc_Menu.Name = "tc_Menu";
            this.tc_Menu.SelectedIndex = 0;
            this.tc_Menu.Size = new System.Drawing.Size(995, 592);
            this.tc_Menu.TabIndex = 0;
            // 
            // Interfaz_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 616);
            this.Controls.Add(this.p_Cuenta);
            this.Controls.Add(this.tc_Menu);
            this.Name = "Interfaz_Principal";
            this.p_Cuenta.ResumeLayout(false);
            this.p_Cuenta.PerformLayout();
            this.tc_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_Cuenta;
        private System.Windows.Forms.Button Btn_ModifCuenta;
        private System.Windows.Forms.Button Btn_CerrarSesion;
        private System.Windows.Forms.Button Btn_Cerrar;
        public System.Windows.Forms.Label lb_NombreUsuario;
        private System.Windows.Forms.Label lb_AquaOne;
        private System.Windows.Forms.TabPage tp_InfoHotel;
        private System.Windows.Forms.TabPage tp_Habitaciones;
        private System.Windows.Forms.TabPage tp_Principal;
        private System.Windows.Forms.TabControl tc_Menu;
    }
}