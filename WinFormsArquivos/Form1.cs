namespace WinFormsArquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            //se o retorno do método ShowDialog () for Ok
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //instanciarStreamReader para ler o arquivo
                StreamReader arq = new StreamReader(openFileDialog1.FileName);
                //grava o nome do arquivo na propriedade text do formulário
                this.Text = openFileDialog1.FileName;
                //armazena o conteúdo do arquivo em um array de string
                string[] str = { arq.ReadToEnd() };
                //atribui a variável str à propriedade lines do arquivo
                textBox1.Lines = str;
                //fecha o arquivo
                arq.Close();

            }
        }

        private void btnSalvarComo_Click(object sender, EventArgs e)
        {
            //se o retorno do método ShowDialog () for Ok
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //declaração da variavel que vai salvar o arquivo
                StreamWriter arq = new StreamWriter(saveFileDialog1.FileName);
                //para cada linha do textBox 
                foreach (string s in textBox1.Lines)
                {
                    //escreve uma linha no arquivo
                    arq.WriteLine(s);
                }
                //fecha o arquivo
                arq.Close();



            }
        }
    }
}