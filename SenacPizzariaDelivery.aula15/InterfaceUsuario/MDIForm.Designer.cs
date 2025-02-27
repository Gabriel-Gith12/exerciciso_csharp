﻿
namespace InterfaceUsuario
{
    partial class MDIFrm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIFrm));
            this.mmsPrincipal = new System.Windows.Forms.MenuStrip();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mmsPrincipal
            // 
            this.mmsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.rotinasToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.mmsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mmsPrincipal.Name = "mmsPrincipal";
            this.mmsPrincipal.Size = new System.Drawing.Size(1096, 24);
            this.mmsPrincipal.TabIndex = 1;
            this.mmsPrincipal.Text = "menuStrip1";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Image = global::InterfaceUsuario.Properties.Resources.relatorio;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Image = global::InterfaceUsuario.Properties.Resources.arquivo;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::InterfaceUsuario.Properties.Resources.sair;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Image = global::InterfaceUsuario.Properties.Resources.cadastro;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.pessoasToolStripMenuItem.Image = global::InterfaceUsuario.Properties.Resources.Pessoas;
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Image = global::InterfaceUsuario.Properties.Resources.usuarios;
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::InterfaceUsuario.Properties.Resources.clientes;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // rotinasToolStripMenuItem
            // 
            this.rotinasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem});
            this.rotinasToolStripMenuItem.Image = global::InterfaceUsuario.Properties.Resources.rotinas;
            this.rotinasToolStripMenuItem.Name = "rotinasToolStripMenuItem";
            this.rotinasToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.rotinasToolStripMenuItem.Text = "Rotinas";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Image = global::InterfaceUsuario.Properties.Resources.pedidos;
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // MDIFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 440);
            this.Controls.Add(this.mmsPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mmsPrincipal;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(16, 70);
            this.Name = "MDIFrm";
            this.Text = "Senac Pizzaria Delivery";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIFrm_Load);
            this.mmsPrincipal.ResumeLayout(false);
            this.mmsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mmsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
    }
}

