﻿namespace ProjetoCinema
{
    partial class FormAdmSalas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmSalas));
            this.gpSalas = new System.Windows.Forms.GroupBox();
            this.dgvSalas = new System.Windows.Forms.DataGridView();
            this.Cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQtdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pnSalasBaixo = new System.Windows.Forms.Panel();
            this.pnSalas = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.gpSalas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).BeginInit();
            this.pnSalasBaixo.SuspendLayout();
            this.pnSalas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpSalas
            // 
            this.gpSalas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpSalas.BackColor = System.Drawing.Color.Transparent;
            this.gpSalas.Controls.Add(this.dgvSalas);
            this.gpSalas.ForeColor = System.Drawing.Color.Black;
            this.gpSalas.Location = new System.Drawing.Point(6, 62);
            this.gpSalas.Name = "gpSalas";
            this.gpSalas.Size = new System.Drawing.Size(463, 201);
            this.gpSalas.TabIndex = 4;
            this.gpSalas.TabStop = false;
            this.gpSalas.Text = "Salas";
            // 
            // dgvSalas
            // 
            this.dgvSalas.AllowUserToAddRows = false;
            this.dgvSalas.AllowUserToDeleteRows = false;
            this.dgvSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cid,
            this.CNome,
            this.cQtdd});
            this.dgvSalas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalas.Location = new System.Drawing.Point(3, 16);
            this.dgvSalas.Name = "dgvSalas";
            this.dgvSalas.ReadOnly = true;
            this.dgvSalas.RowHeadersVisible = false;
            this.dgvSalas.Size = new System.Drawing.Size(457, 182);
            this.dgvSalas.TabIndex = 0;
            // 
            // Cid
            // 
            this.Cid.HeaderText = "Numero";
            this.Cid.Name = "Cid";
            this.Cid.ReadOnly = true;
            // 
            // CNome
            // 
            this.CNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNome.HeaderText = "Nome";
            this.CNome.Name = "CNome";
            this.CNome.ReadOnly = true;
            // 
            // cQtdd
            // 
            this.cQtdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cQtdd.HeaderText = "Quantidade de Lugares";
            this.cQtdd.Name = "cQtdd";
            this.cQtdd.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnExcluir.Location = new System.Drawing.Point(312, 15);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnVisualizar.Location = new System.Drawing.Point(231, 15);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 2;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEditar.Location = new System.Drawing.Point(150, 15);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnNovo.Location = new System.Drawing.Point(69, 15);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pnSalasBaixo
            // 
            this.pnSalasBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSalasBaixo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnSalasBaixo.Controls.Add(this.btnExcluir);
            this.pnSalasBaixo.Controls.Add(this.btnVisualizar);
            this.pnSalasBaixo.Controls.Add(this.btnNovo);
            this.pnSalasBaixo.Controls.Add(this.btnEditar);
            this.pnSalasBaixo.Location = new System.Drawing.Point(5, 269);
            this.pnSalasBaixo.Name = "pnSalasBaixo";
            this.pnSalasBaixo.Size = new System.Drawing.Size(464, 50);
            this.pnSalasBaixo.TabIndex = 5;
            // 
            // pnSalas
            // 
            this.pnSalas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSalas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnSalas.Controls.Add(this.textBox1);
            this.pnSalas.Controls.Add(this.lbFiltro);
            this.pnSalas.Location = new System.Drawing.Point(6, 5);
            this.pnSalas.Name = "pnSalas";
            this.pnSalas.Size = new System.Drawing.Size(464, 58);
            this.pnSalas.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.Location = new System.Drawing.Point(68, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbFiltro
            // 
            this.lbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lbFiltro.ForeColor = System.Drawing.Color.Aquamarine;
            this.lbFiltro.Location = new System.Drawing.Point(30, 20);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(32, 13);
            this.lbFiltro.TabIndex = 0;
            this.lbFiltro.Text = "Filtrar";
            // 
            // FormAdmSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(65)))), ((int)(((byte)(84)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(475, 325);
            this.Controls.Add(this.pnSalasBaixo);
            this.Controls.Add(this.gpSalas);
            this.Controls.Add(this.pnSalas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAdmSalas";
            this.Text = "Administrar Salas";
            this.Load += new System.EventHandler(this.FormAdmSalas_Load);
            this.gpSalas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).EndInit();
            this.pnSalasBaixo.ResumeLayout(false);
            this.pnSalas.ResumeLayout(false);
            this.pnSalas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSalasBaixo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gpSalas;
        private System.Windows.Forms.DataGridView dgvSalas;
        private System.Windows.Forms.Panel pnSalas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQtdd;
    }
}