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
    public partial class Home : Form
    {
        List<Filme> data = new List<Filme>();
        private FilmeDAO DAO = new FilmeDAO();

        public Home()
        {
            InitializeComponent();
            LoadDatabase();
        }
       
               
        private void LoadDatabase()
        {
            data = DAO.ListAll();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormIngressos ing = new FormIngressos();
            ing.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            ing.ShowDialog();
        }

        private void Fill(string filter)
        {
            dgvFilmes.Rows.Clear();
            foreach (Filme a in data)
                if (filter == "" || a.Nome.ToUpper().Contains(filter.ToUpper()) || a.Genero.ToUpper().Contains(filter.ToUpper()))
                    dgvFilmes.Rows.Add(a.Id,a.Nome, a.Duracao, a.Genero);
        }


        private void Home_Load(object sender, EventArgs e)
        {
            Fill("");
        }

        private void dgvFilmes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int key = int.Parse(dgvFilmes.CurrentRow.Cells[0].Value.ToString());
            Filme f = DAO.Read(key);
            List<Filme> data = DAO.ListAll();
            for (int i=0;i<data.Count;i++)
            {
                if(f.Id==data[i].Id)
                {
                    MessageBox.Show(data[i].Sinopse, "Sinopse");
                }
               
            }
        }
    }
}
