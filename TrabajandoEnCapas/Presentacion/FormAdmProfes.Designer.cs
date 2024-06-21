namespace Presentacion
{
    partial class FormAdmProfes
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
            LlenarDgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)LlenarDgv).BeginInit();
            SuspendLayout();
            // 
            // LlenarDgv
            // 
            LlenarDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LlenarDgv.Location = new Point(204, 89);
            LlenarDgv.Name = "LlenarDgv";
            LlenarDgv.RowHeadersWidth = 51;
            LlenarDgv.Size = new Size(561, 319);
            LlenarDgv.TabIndex = 0;
            LlenarDgv.CellContentClick += LlenarDgv_CellContentClick;
            // 
            // FormAdmProfes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LlenarDgv);
            Name = "FormAdmProfes";
            Text = "FormAdmProfes";
            ((System.ComponentModel.ISupportInitialize)LlenarDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView LlenarDgv;
    }
}