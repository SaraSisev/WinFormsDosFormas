namespace WinFormsDosFormas
{
    partial class Form1
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
            labelTitulo = new Label();
            buttonForm2 = new Button();
            buttonForm3 = new Button();
            textBoxData = new TextBox();
            label1 = new Label();
            salir = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(335, 22);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(155, 23);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Título Principal";
            // 
            // buttonForm2
            // 
            buttonForm2.BackColor = Color.LightSalmon;
            buttonForm2.FlatStyle = FlatStyle.Popup;
            buttonForm2.Location = new Point(413, 62);
            buttonForm2.Name = "buttonForm2";
            buttonForm2.Size = new Size(123, 55);
            buttonForm2.TabIndex = 1;
            buttonForm2.Text = "Forma 2";
            buttonForm2.UseVisualStyleBackColor = false;
            buttonForm2.Click += buttonForm2_Click;
            // 
            // buttonForm3
            // 
            buttonForm3.BackColor = Color.LightSalmon;
            buttonForm3.FlatStyle = FlatStyle.Popup;
            buttonForm3.Location = new Point(284, 62);
            buttonForm3.Name = "buttonForm3";
            buttonForm3.Size = new Size(123, 55);
            buttonForm3.TabIndex = 2;
            buttonForm3.Text = "Forma 3";
            buttonForm3.UseVisualStyleBackColor = false;
            buttonForm3.Click += buttonForm1_Click;
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(284, 151);
            textBoxData.Name = "textBoxData";
            textBoxData.PlaceholderText = "Captura un nombre";
            textBoxData.Size = new Size(252, 23);
            textBoxData.TabIndex = 3;
            textBoxData.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(263, 19);
            label1.TabIndex = 4;
            label1.Text = "Sara Alexandra Chamorro Cuevas";
            // 
            // salir
            // 
            salir.BackColor = Color.RosyBrown;
            salir.FlatStyle = FlatStyle.Flat;
            salir.Location = new Point(512, 238);
            salir.Name = "salir";
            salir.Size = new Size(153, 53);
            salir.TabIndex = 5;
            salir.Text = "Salir";
            salir.UseVisualStyleBackColor = false;
            salir.Click += salir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Sailor_Moon_Crystal_Desktop_Background__1920x1080_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(salir);
            Controls.Add(label1);
            Controls.Add(textBoxData);
            Controls.Add(buttonForm3);
            Controls.Add(buttonForm2);
            Controls.Add(labelTitulo);
            DoubleBuffered = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Button buttonForm2;
        private Button buttonForm3;
        private TextBox textBoxData;
        private Label label1;
        private Button salir;
    }
}
