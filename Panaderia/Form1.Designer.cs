
namespace Panaderia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox47
            // 
            this.pictureBox47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pictureBox47.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", global::Panaderia.Properties.Settings.Default, "imagen", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBox47.ImageLocation = global::Panaderia.Properties.Settings.Default.imagen;
            this.pictureBox47.Location = new System.Drawing.Point(943, 24);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(40, 40);
            this.pictureBox47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox47.TabIndex = 151;
            this.pictureBox47.TabStop = false;
            this.pictureBox47.Click += new System.EventHandler(this.pictureBox47_Click);
            // 
            // label60
            // 
            this.label60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label60.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Panaderia.Properties.Settings.Default, "Sesion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label60.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.White;
            this.label60.Location = new System.Drawing.Point(874, 29);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(66, 18);
            this.label60.TabIndex = 150;
            this.label60.Text = global::Panaderia.Properties.Settings.Default.Sesion;
            this.label60.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 153;
            this.label1.Text = "Sesion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(819, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 132);
            this.panel1.TabIndex = 154;
            this.panel1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 155;
            this.label3.Text = "Salir";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 154;
            this.label2.Text = "Cerrar sesion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Panaderia.Properties.Settings.Default, "nivel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label65.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label65.ForeColor = System.Drawing.Color.White;
            this.label65.Location = new System.Drawing.Point(911, 47);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(29, 17);
            this.label65.TabIndex = 169;
            this.label65.Text = global::Panaderia.Properties.Settings.Default.nivel;
            this.label65.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(870, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 170;
            this.label4.Text = "Nivel:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1007, 622);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox47);
            this.Controls.Add(this.label60);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panaderia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox47;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label4;
    }
}

