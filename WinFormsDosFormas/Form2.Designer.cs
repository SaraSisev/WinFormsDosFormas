namespace WinFormsDosFormas
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBoxNombre = new TextBox();
            textBoxNumero = new TextBox();
            buttonRegresar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 26);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 0;
            label1.Text = "Título Formulario 2";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBoxNombre
            // 
            textBoxNombre.Enabled = false;
            textBoxNombre.Font = new Font("Rockwell", 12F);
            textBoxNombre.Location = new Point(165, 74);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(221, 26);
            textBoxNombre.TabIndex = 2;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Enabled = false;
            textBoxNumero.Font = new Font("Rockwell", 12F);
            textBoxNumero.Location = new Point(165, 103);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(221, 26);
            textBoxNumero.TabIndex = 3;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Font = new Font("Rockwell", 12F);
            buttonRegresar.Location = new Point(228, 156);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(104, 33);
            buttonRegresar.TabIndex = 4;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(567, 277);
            Controls.Add(buttonRegresar);
            Controls.Add(textBoxNumero);
            Controls.Add(textBoxNombre);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBoxNombre;
        private TextBox textBoxNumero;
        private Button buttonRegresar;
    }
}