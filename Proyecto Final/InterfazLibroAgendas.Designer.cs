namespace Proyecto_Final
{
    partial class InterfazLibroAgendas
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
            this.CalendarioReservaciones = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // CalendarioReservaciones
            // 
            this.CalendarioReservaciones.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.CalendarioReservaciones.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.CalendarioReservaciones.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarioReservaciones.Location = new System.Drawing.Point(18, 18);
            this.CalendarioReservaciones.MaxSelectionCount = 15;
            this.CalendarioReservaciones.Name = "CalendarioReservaciones";
            this.CalendarioReservaciones.TabIndex = 0;
            // 
            // InterfazLibroAgendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalendarioReservaciones);
            this.Name = "InterfazLibroAgendas";
            this.Text = "LibroAgendas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CalendarioReservaciones;
    }
}