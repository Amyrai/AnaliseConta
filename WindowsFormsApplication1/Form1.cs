using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {



        string enderecoTxt;


        public Form1()
        {

            enderecoTxt = "Nenhum Arquivo Selecionado";
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = enderecoTxt;
        }
        private void tXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            enderecoTxt = openFileDialog1.FileName;


            toolStripStatusLabel1.Text = enderecoTxt;

            MessageBox.Show("Importação Concluída");

       

            // Here we create a DataTable with four columns.

           
            int counter = 0;
            string line;
            // Here we add five DataRows.

            DataTable TABELA_1 = new DataTable();
            TABELA_1.Columns.Add("Nome", typeof(string));
            TABELA_1.Columns.Add("Endereco", typeof(string));
            TABELA_1.Columns.Add("numero", typeof(int));
            TABELA_1.Columns.Add("Bairro", typeof(string));
            TABELA_1.Columns.Add("Cidade", typeof(string));
            TABELA_1.Columns.Add("Estado", typeof(string));

            // Read the file and display it line by line.
         string nome,
               endereco,
               bairro,
               cidade,
               estado;
        int numEnd;

            System.IO.StreamReader file =
            new System.IO.StreamReader(enderecoTxt);


            TABELA_1.Rows.Add(0, 0, 0, 0, 0, 0);

            while ((line = file.ReadLine()) != null)
            {
                nome = line;

                int teste;

                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.
            System.Console.ReadLine();




        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabelaDeImportaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}