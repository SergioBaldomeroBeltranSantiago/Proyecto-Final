
namespace Interface
{
    partial class Interfaz_Habitaciones
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
            this.Lb_NombreHabitacion = new System.Windows.Forms.Label();
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.CalendarReservacion = new System.Windows.Forms.MonthCalendar();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Lb_CapacidadHabitacion = new System.Windows.Forms.Label();
            this.Lb_CostopDia = new System.Windows.Forms.Label();
            this.Lb_CostoTotal = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Lb_ServicioE = new System.Windows.Forms.Label();
            this.Check_ServicioE = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Lb_NombreHabitacion
            // 
            this.Lb_NombreHabitacion.AutoSize = true;
            this.Lb_NombreHabitacion.Location = new System.Drawing.Point(12, 9);
            this.Lb_NombreHabitacion.Name = "Lb_NombreHabitacion";
            this.Lb_NombreHabitacion.Size = new System.Drawing.Size(95, 13);
            this.Lb_NombreHabitacion.TabIndex = 0;
            this.Lb_NombreHabitacion.Text = "NombreHabitacion";
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.Enabled = false;
            this.Btn_Confirmar.Location = new System.Drawing.Point(339, 229);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(117, 23);
            this.Btn_Confirmar.TabIndex = 1;
            this.Btn_Confirmar.Text = "Confirmar reservacion";
            this.Btn_Confirmar.UseVisualStyleBackColor = true;
            this.Btn_Confirmar.Click += new System.EventHandler(this.Btn_Confirmar_Click);
            // 
            // CalendarReservacion
            // 
            this.CalendarReservacion.Location = new System.Drawing.Point(18, 229);
            this.CalendarReservacion.Name = "CalendarReservacion";
            this.CalendarReservacion.TabIndex = 3;
            this.CalendarReservacion.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalendarReservacion_DateSelected);
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(21, 114);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.ReadOnly = true;
            this.Txt_Descripcion.Size = new System.Drawing.Size(185, 92);
            this.Txt_Descripcion.TabIndex = 4;
            // 
            // Lb_CapacidadHabitacion
            // 
            this.Lb_CapacidadHabitacion.AutoSize = true;
            this.Lb_CapacidadHabitacion.Location = new System.Drawing.Point(12, 65);
            this.Lb_CapacidadHabitacion.Name = "Lb_CapacidadHabitacion";
            this.Lb_CapacidadHabitacion.Size = new System.Drawing.Size(109, 13);
            this.Lb_CapacidadHabitacion.TabIndex = 5;
            this.Lb_CapacidadHabitacion.Text = "CapacidadHabitacion";
            // 
            // Lb_CostopDia
            // 
            this.Lb_CostopDia.AutoSize = true;
            this.Lb_CostopDia.Location = new System.Drawing.Point(242, 9);
            this.Lb_CostopDia.Name = "Lb_CostopDia";
            this.Lb_CostopDia.Size = new System.Drawing.Size(75, 13);
            this.Lb_CostopDia.TabIndex = 6;
            this.Lb_CostopDia.Text = "Costo por dia: ";
            // 
            // Lb_CostoTotal
            // 
            this.Lb_CostoTotal.AutoSize = true;
            this.Lb_CostoTotal.Location = new System.Drawing.Point(242, 55);
            this.Lb_CostoTotal.Name = "Lb_CostoTotal";
            this.Lb_CostoTotal.Size = new System.Drawing.Size(58, 13);
            this.Lb_CostoTotal.TabIndex = 7;
            this.Lb_CostoTotal.Text = "CostoTotal";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(339, 313);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(117, 23);
            this.Btn_Cancelar.TabIndex = 8;
            this.Btn_Cancelar.Text = "Cancelar reservacion";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Lb_ServicioE
            // 
            this.Lb_ServicioE.AutoSize = true;
            this.Lb_ServicioE.Location = new System.Drawing.Point(242, 68);
            this.Lb_ServicioE.Name = "Lb_ServicioE";
            this.Lb_ServicioE.Size = new System.Drawing.Size(0, 13);
            this.Lb_ServicioE.TabIndex = 9;
            // 
            // Check_ServicioE
            // 
            this.Check_ServicioE.AutoSize = true;
            this.Check_ServicioE.Location = new System.Drawing.Point(245, 141);
            this.Check_ServicioE.Name = "Check_ServicioE";
            this.Check_ServicioE.Size = new System.Drawing.Size(134, 17);
            this.Check_ServicioE.TabIndex = 10;
            this.Check_ServicioE.Text = "¿Servicios especiales?";
            this.Check_ServicioE.UseVisualStyleBackColor = true;
            this.Check_ServicioE.CheckedChanged += new System.EventHandler(this.Check_ServicioE_CheckedChanged);
            // 
            // Interfaz_Habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 466);
            this.ControlBox = false;
            this.Controls.Add(this.Check_ServicioE);
            this.Controls.Add(this.Lb_ServicioE);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Lb_CostoTotal);
            this.Controls.Add(this.Lb_CostopDia);
            this.Controls.Add(this.Lb_CapacidadHabitacion);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.CalendarReservacion);
            this.Controls.Add(this.Btn_Confirmar);
            this.Controls.Add(this.Lb_NombreHabitacion);
            this.Name = "Interfaz_Habitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz_Habitaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Lb_NombreHabitacion;
        private System.Windows.Forms.Button Btn_Confirmar;
        private System.Windows.Forms.MonthCalendar CalendarReservacion;
        public System.Windows.Forms.TextBox Txt_Descripcion;
        public System.Windows.Forms.Label Lb_CapacidadHabitacion;
        public System.Windows.Forms.Label Lb_CostopDia;
        private System.Windows.Forms.Label Lb_CostoTotal;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label Lb_ServicioE;
        private System.Windows.Forms.CheckBox Check_ServicioE;
    }
}