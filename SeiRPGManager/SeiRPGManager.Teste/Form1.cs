using SeiRPGManager.DAL.Repositorio;
using SeiRPGManager.Entidades.Modelo.ClassesBasicas;
using SeiRPGManager.Entidades.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SeiRPGManager.Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Raca r = new Raca();

            r.Descricao = "Descrição";
            r.Nome = "Nome";

            SeiRPGManagerDAO<Raca> rDao = new SeiRPGManagerDAO<Raca>();
            rDao.Inserir(r);

        }
    }
}
