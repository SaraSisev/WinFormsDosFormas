namespace WinFormsDosFormas
{
    partial class Form3
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
            buttonRegresar = new Button();
            textBoxNumero = new TextBox();
            textBoxNombre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonRegresar
            // 
            buttonRegresar.Font = new Font("Rockwell", 12F);
            buttonRegresar.Location = new Point(203, 163);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(104, 33);
            buttonRegresar.TabIndex = 8;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Enabled = false;
            textBoxNumero.Font = new Font("Rockwell", 12F);
            textBoxNumero.Location = new Point(140, 110);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(221, 26);
            textBoxNumero.TabIndex = 7;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Enabled = false;
            textBoxNombre.Font = new Font("Rockwell", 12F);
            textBoxNombre.Location = new Point(140, 81);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(221, 26);
            textBoxNombre.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 33);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 5;
            label1.Text = "Título Formulario 3";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(491, 256);
            Controls.Add(buttonRegresar);
            Controls.Add(textBoxNumero);
            Controls.Add(textBoxNombre);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegresar;
        private TextBox textBoxNumero;
        private TextBox textBoxNombre;
        private Label label1;
    }
}