using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalisadorLexico;

namespace AnalisadorLexico
{
    public partial class frmAnalisadorLexico : Form
    {
        public frmAnalisadorLexico()
        {
            InitializeComponent();
        }

        private Simbolo simbolo = new Simbolo();
        private TabelaSimbolos tabelaSimbolos = new TabelaSimbolos();

        string codigo;

        char[] programa;

        private void btnGeradorLexico_Click(object sender, EventArgs e)
        {
            txbToken.Clear();
            codigo = txbCodigo.Text;

            String token = "";

            //Converte o codigo de string para char
            programa = codigo.ToCharArray();

            if(codigo != "")
            {
                Lexico lex = new Lexico(programa);

                while (token != "end")
                {
                    //Adcionar os tokens
                    token = lex.GetToken();

                    if ( (token == "<Palavra reservada>") || (token == "<NUM>") || (token == "<RELOP>") || (token == "<LITERAL>") || (token == "<DELIM>") || (token == "end") )
                    {
                        if (token.ToString() == "end")
                        {
                            txbToken.Text += "<Palavra reservada>";
                        }
                        else
                        {
                            txbToken.Text += token.ToString() + "\n";
                        }

                            
                    }
                    else
                    {
                        txbToken.Text += "<ID, " + tabelaSimbolos.add_simbolo(token) + ">" + "\n";
                    }      
                }

                txbTabSimbolos.Clear();

                foreach (Simbolo item in tabelaSimbolos.Simbolos)
                {
                    txbTabSimbolos.Text += "ID: " + item.Id.ToString() + " | ";
                    txbTabSimbolos.Text += "Nome: " + item.Nome.ToString() + "\n";
                }
            }
            else
            {
                MessageBox.Show("Erro: Nenhum Código Digitado!");
            }

            //txbCodigo.Clear();
        }

        //Carregar o Arquivo com o codigo
        private void btnCarregarCodigo_Click(object sender, EventArgs e)
        {

            openArqCod.Multiselect = false;
            openArqCod.Title = "Selecionar Arquivo";
            openArqCod.InitialDirectory = @"C:\";
            openArqCod.Filter = "Imagens (*.TXT)|*.TXT";
            openArqCod.CheckFileExists = true;
            openArqCod.CheckPathExists = true;
            openArqCod.FilterIndex = 1;

            DialogResult arq = openArqCod.ShowDialog();


            //Se o arquivo Selecionado for OK coloca no TxbCodigo
            if(arq.ToString() == "OK")
            {
                txbCodigo.Text = System.IO.File.ReadAllText(openArqCod.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txbCodigo.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbToken.Clear();
            txbTabSimbolos.Clear();
            
        }
    }
}
