namespace Presentacion
{
    partial class Presentacion
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
            label1 = new Label();
            label2 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            dataGridView1 = new DataGridView();
            btnGrabar = new Button();
            btnModificar = new Button();
            lblInformativo = new Label();
            btSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 40);
            label1.Name = "label1";
            label1.Size = new Size(113, 33);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 136);
            label2.Name = "label2";
            label2.Size = new Size(127, 33);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(181, 46);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(142, 27);
            txtCodigo.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(181, 136);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(142, 27);
            txtNombre.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(435, 44);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(437, 385);
            dataGridView1.TabIndex = 4;
            // 
            // btnGrabar
            // 
            btnGrabar.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGrabar.Location = new Point(46, 239);
            btnGrabar.Margin = new Padding(3, 4, 3, 4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(101, 40);
            btnGrabar.TabIndex = 5;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(222, 239);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(118, 40);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // lblInformativo
            // 
            lblInformativo.AutoSize = true;
            lblInformativo.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInformativo.Location = new Point(46, 395);
            lblInformativo.Name = "lblInformativo";
            lblInformativo.Size = new Size(183, 24);
            lblInformativo.TabIndex = 7;
            lblInformativo.Text = "Label informativo";
            // 
            // btSalir
            // 
            btSalir.Cursor = Cursors.Hand;
            btSalir.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSalir.Location = new Point(771, 489);
            btSalir.Margin = new Padding(3, 4, 3, 4);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(101, 40);
            btSalir.TabIndex = 8;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = true;
            btSalir.Click += btSalir_Click;
            // 
            // Presentacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 569);
            Controls.Add(btSalir);
            Controls.Add(lblInformativo);
            Controls.Add(btnModificar);
            Controls.Add(btnGrabar);
            Controls.Add(dataGridView1);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Presentacion";
            Text = "Presentacion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private DataGridView dataGridView1;
        private Button btnGrabar;
        private Button btnModificar;
        private Label lblInformativo;
        private Button btSalir;
    }
}