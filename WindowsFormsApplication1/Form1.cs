using System;
using System.ComponentModel;
using System.Data;
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
                //textBox1.Text = ExtractTextFromPdf(enderecoTxt); 
                //return;

            int counter = 0 ,numEnd;
            string line, nome, endereco, bairro, cidade, estado;


            System.IO.StreamReader file = new System.IO.StreamReader(enderecoTxt);
              
            DataTable TABELA_1 = new DataTable();
          TABELA_1.Columns.Add("dados", typeof(string));
            
            while ((line = file.ReadLine()) != null)

           {
               TABELA_1.Rows.Add(line);
               //System.Console.WriteLine(line);
               counter++;
           }


            dataGridView1.DataSource = TABELA_1; 
            


              MessageBox.Show("Arquivo Importado");

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            System.Console.ReadLine();
        

    




























          
          //  TABELA_1.Columns.Add("Endereco", typeof(string));
          //  TABELA_1.Columns.Add("numero", typeof(int));
          //  TABELA_1.Columns.Add("Bairro", typeof(string));
          //  TABELA_1.Columns.Add("Cidade", typeof(string));
         //   TABELA_1.Columns.Add("Estado", typeof(string));

           // TABELA_1.Rows.Add(0, 0, 0, 0, 0, 0);
            //while ((line = file.ReadLine()) != null)
          // {
               //nome = line;
               ///TABELA_1.Rows[TABELA_1.Rows.Count - 1]["endereco"] = "dffds";  
               //int teste;
            //   System.Console.WriteLine(line);
           //    counter++;
           // }

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

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}