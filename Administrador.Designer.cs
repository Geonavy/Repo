namespace InterfazJSON
{
    partial class Administrador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GridViewArchivo = new DataGridView();
            btnCargar = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)GridViewArchivo).BeginInit();
            SuspendLayout();
            // 
            // GridViewArchivo
            // 
            GridViewArchivo.BackgroundColor = Color.FromArgb(255, 224, 192);
            GridViewArchivo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewArchivo.Dock = DockStyle.Top;
            GridViewArchivo.Location = new Point(0, 0);
            GridViewArchivo.Name = "GridViewArchivo";
            GridViewArchivo.Size = new Size(800, 159);
            GridViewArchivo.TabIndex = 0;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = SystemColors.Highlight;
            btnCargar.FlatAppearance.BorderSize = 10;
            btnCargar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnCargar.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 160, 255);
            btnCargar.ForeColor = SystemColors.Info;
            btnCargar.Location = new Point(665, 189);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(105, 43);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Highlight;
            btnActualizar.FlatAppearance.BorderSize = 10;
            btnActualizar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 160, 255);
            btnActualizar.ForeColor = SystemColors.Info;
            btnActualizar.Location = new Point(539, 189);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(105, 43);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnActualizar);
            Controls.Add(btnCargar);
            Controls.Add(GridViewArchivo);
            Name = "Administrador";
            Text = "Panel de Administrador";
            ((System.ComponentModel.ISupportInitialize)GridViewArchivo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridViewArchivo;
        private Button btnCargar;
        private Button btnActualizar;
    }
}
