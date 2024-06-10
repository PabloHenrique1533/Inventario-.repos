using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gf_materiais.forms
{
    public partial class Form3 : Form
    {
        internal Action<object, object> FormShown;

        public Form3()
        {
            InitializeComponent();
           
        }

        public string comando;

        private void button1_Click(object sender, EventArgs e)
        {
            DAO dados = new DAO();
            comando = "INSERT INTO Usuario(@nome_completo, @usuario, @data_nascimento, @senha, @email) values (@nome_completo)";
            dados.insert_dados(comando);
            dados.InserirNoBanco("@nome_completo", Nome_txt.Text);
            dados.InserirNoBanco("@usuario", Usuario_txt.Text);
            dados.InserirNoBanco("@data_nascimento", date_txt.Text);
            dados.InserirNoBanco("@senha", Senha_txt.Text);
            dados.InserirNoBanco("@email", Email_txt.Text);
            Form2 forms2 = new Form2();
            this.Hide();
            forms2.Show();
        }

      
        private void Nome_TextChanged(object sender, EventArgs e)
        {
         
            
                        
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
         }

        private void Email_txt_TextChanged(object sender, EventArgs e)
        {
        }

        private void Cpf_txt_TextChanged(object sender, EventArgs e)
        {
        }

        private void date_txt_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Senha_txt_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
