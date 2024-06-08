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
            DgvProfesionales = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txCodigo = new TextBox();
            txNombre = new TextBox();
            lbInforacion = new Label();
            btGrabar = new Button();
            btModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvProfesionales).BeginInit();
            SuspendLayout();
            // 
            // DgvProfesionales
            // 
            DgvProfesionales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProfesionales.Location = new Point(411, 38);
            DgvProfesionales.Name = "DgvProfesionales";
            DgvProfesionales.RowHeadersWidth = 51;
            DgvProfesionales.Size = new Size(460, 309);
            DgvProfesionales.TabIndex = 0;
            DgvProfesionales.CellClick += DgvProfesionales_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 72);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 205);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txCodigo
            // 
            txCodigo.Enabled = false;
            txCodigo.Location = new Point(142, 72);
            txCodigo.Name = "txCodigo";
            txCodigo.Size = new Size(125, 27);
            txCodigo.TabIndex = 3;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(142, 198);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(125, 27);
            txNombre.TabIndex = 4;
            // 
            // lbInforacion
            // 
            lbInforacion.AutoSize = true;
            lbInforacion.Location = new Point(39, 327);
            lbInforacion.Name = "lbInforacion";
            lbInforacion.Size = new Size(35, 20);
            lbInforacion.TabIndex = 5;
            lbInforacion.Text = "Info";
            // 
            // btGrabar
            // 
            btGrabar.Location = new Point(39, 261);
            btGrabar.Name = "btGrabar";
            btGrabar.Size = new Size(94, 29);
            btGrabar.TabIndex = 6;
            btGrabar.Text = "Grabar";
            btGrabar.UseVisualStyleBackColor = true;
            btGrabar.Click += btGrabar_Click;
            // 
            // btModificar
            // 
            btModificar.Location = new Point(173, 261);
            btModificar.Name = "btModificar";
            btModificar.Size = new Size(94, 29);
            btModificar.TabIndex = 7;
            btModificar.Text = "Modificar";
            btModificar.UseVisualStyleBackColor = true;
            // 
            // FormAdmProfes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 450);
            Controls.Add(btModificar);
            Controls.Add(btGrabar);
            Controls.Add(lbInforacion);
            Controls.Add(txNombre);
            Controls.Add(txCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DgvProfesionales);
            Name = "FormAdmProfes";
            Text = "Gestión Profesionales";
            ((System.ComponentModel.ISupportInitialize)DgvProfesionales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvProfesionales;
        private Label label1;
        private Label label2;
        private TextBox txCodigo;
        private TextBox txNombre;
        private Label lbInforacion;
        private Button btGrabar;
        private Button btModificar;
    }
}