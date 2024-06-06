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
            btSalir = new Button();
            SuspendLayout();
            // 
            // btSalir
            // 
            btSalir.Cursor = Cursors.Hand;
            btSalir.Location = new Point(694, 12);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(94, 29);
            btSalir.TabIndex = 0;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = true;
            btSalir.Click += btSalir_Click;
            // 
            // Presentacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btSalir);
            Name = "Presentacion";
            Text = "Presentacion";
            ResumeLayout(false);
        }

        #endregion

        private Button btSalir;
    }
}