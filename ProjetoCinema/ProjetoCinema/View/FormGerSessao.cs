﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoCinema.BD;
namespace ProjetoCinema
{
    public partial class FormGerSessao : Form
    {
        private SessaoDAO DAO = new SessaoDAO();
        private FilmeDAO DAOf = new FilmeDAO();
        private SalaDAO DAOs = new SalaDAO();
        private bool salvar= true;
        private bool editavel=false;
        public FormGerSessao()
        {
            
            InitializeComponent();
            FillComboBox();
        }
        private void FillComboBox()
        {

            List<Filme> f = DAOf.ListAll();
            List<Sala> s = DAOs.ListAll();
            for (int i=0;i<f.Count;i++)
            {
                cbFilme.Items.Insert(i,f[i].Nome);
            }
            for(int i=0;i<s.Count;i++)
            {
                cbSala.Items.Insert(i, s[i].Nome);
            }
            
        }
        public FormGerSessao(bool editavel,Sessão s)
        {
            salvar = false;
            this.editavel = editavel;
            InitializeComponent();
            TxtCod.Text = s.Id.ToString();
            cbFilme.Text = s.Filme.Nome;
            cbSala.Text = s.Sala.Nome;
            dtpHorario.Text = s.Horario.ToShortTimeString();
            NmLugares.Value = s.LugaresDisponiveis;
            if (editavel == false)
            {
                TxtCod.Enabled = false;
                cbFilme.Enabled = false;
                cbSala.Enabled = false;
                dtpHorario.Enabled = false;
                NmLugares.Enabled = false;
                
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Sessão s = new Sessão();
            s.Filme = DAOf.FindByName(cbFilme.Text);
            s.Sala = DAOs.FindByName(cbSala.Text);
            s.Horario = dtpHorario.Value;
            s.LugaresDisponiveis = int.Parse(NmLugares.Value.ToString());
            
            if (salvar)
            {
                DAO.Create(s);
                Dispose();
            }
            if (editavel)
            {
                s.Id = int.Parse(TxtCod.Text);
                DAO.Update(s);
                Dispose();
            }
            if (!salvar && !editavel)
            {
                Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FormGerSessao_Load(object sender, EventArgs e)
        {

        }
    }
}
