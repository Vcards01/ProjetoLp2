﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using ProjetoCinema.View;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoCinema.BD;
using ProjetoCinema.Model;

namespace ProjetoCinema
{
    public partial class Form1 : Form
    {
        private int caixa = 0;
        
        public Form1()
        {
            Tables tb = new Tables();
            tb.CreateTable();
            InitializeComponent();
            timer1.Start();
            AbrirForm(new Home());
            
        }
        public Form1(int flag)
        { 
            InitializeComponent();
            
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToLongDateString().ToUpper()+" |";
            lbHoras.Text = DateTime.Now.ToShortTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            
        }
       private void AbrirForm(object form)
        {
            if(this.pnFundo.Controls.Count>0)
            {
                this.pnFundo.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnFundo.Controls.Add(f);
            pnFundo.Tag = f;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show(); 
        }
        private void FecharForm(object form)
        {
            Form f = form as Form;
            f.Close();
        }
        private void btnFilme_Click(object sender, EventArgs e)
        {
            if(caixa==0)
            {
                MessageBox.Show("É necesario abrir o caixa primeiro!", "Caixa fechado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AbrirForm(new FormCompra());
            }
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AbrirForm(new Home());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja mesmo fechar o sistema?", "Encerrar o programa?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            AbrirForm(new Administração());
        }

        private void relatorioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioVendasTotais r = new FormRelatorioVendasTotais();
            r.StartPosition = FormStartPosition.CenterParent;
            r.ShowDialog(this);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormAbrirCaixa f = new FormAbrirCaixa();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog(this);
            
            caixa = 1;
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (caixa == 1)
            {
                CaixaDAO dao = new CaixaDAO();
                Caixa c = dao.FindbyDate(DateTime.Now.ToShortDateString());
                MessageBox.Show("Valor atual em caixa:" + c.ValorAtual.ToString("C") + "| Lucro de hoje:" + c.Lucro.ToString("C"), "Caixa fechado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                caixa = 0;
            }
            else
            {
                MessageBox.Show("É necesario abrir o caixa primeiro!", "Caixa fechado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void vendaDeIngressosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioFilme r = new FormRelatorioFilme();
            r.StartPosition = FormStartPosition.CenterParent;
            r.ShowDialog(this);
        }

        private void relatorioProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioProdutos form = new FormRelatorioProdutos();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog(this);
       


        }

        private void relatorioDeLucrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioLucro form = new FormRelatorioLucro();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void relatorioSessõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioSessao form = new FormRelatorioSessao();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }
    }
}
