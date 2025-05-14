namespace WinFormsArquivos
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
            textBox1 = new TextBox();
            btnAbrirArquivo = new Button();
            btnSalvarComo = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 54);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(739, 384);
            textBox1.TabIndex = 0;
            // 
            // btnAbrirArquivo
            // 
            btnAbrirArquivo.Location = new Point(22, 12);
            btnAbrirArquivo.Name = "btnAbrirArquivo";
            btnAbrirArquivo.Size = new Size(101, 23);
            btnAbrirArquivo.TabIndex = 1;
            btnAbrirArquivo.Text = "Abrir Arquivo...";
            btnAbrirArquivo.UseVisualStyleBackColor = true;
            // 
            // btnSalvarComo
            // 
            btnSalvarComo.Location = new Point(129, 12);
            btnSalvarComo.Name = "btnSalvarComo";
            btnSalvarComo.Size = new Size(95, 23);
            btnSalvarComo.TabIndex = 2;
            btnSalvarComo.Text = "Salvar Como...";
            btnSalvarComo.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvarComo);
            Controls.Add(btnAbrirArquivo);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnAbrirArquivo;
        private Button btnSalvarComo;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
