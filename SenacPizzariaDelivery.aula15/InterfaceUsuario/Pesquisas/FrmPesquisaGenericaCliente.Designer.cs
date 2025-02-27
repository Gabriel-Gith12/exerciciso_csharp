﻿
namespace InterfaceUsuario.Pesquisas
{
    partial class FrmPesquisaGenericaCliente
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblBusca = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.gbSituacao = new System.Windows.Forms.GroupBox();
            this.optInativos = new System.Windows.Forms.RadioButton();
            this.optAtivos = new System.Windows.Forms.RadioButton();
            this.optTodos = new System.Windows.Forms.RadioButton();
            this.gbListagem = new System.Windows.Forms.GroupBox();
            this.lvlListagem = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbSituacao.SuspendLayout();
            this.gbListagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSair);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirmar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(193, 368);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 52);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Image = global::InterfaceUsuario.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(122, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(105, 45);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::InterfaceUsuario.Properties.Resources.confirmar;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmar.Location = new System.Drawing.Point(11, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(105, 45);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Location = new System.Drawing.Point(13, 13);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(37, 13);
            this.lblBusca.TabIndex = 1;
            this.lblBusca.Text = "Busca";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(13, 30);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(407, 20);
            this.txtBusca.TabIndex = 2;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // gbSituacao
            // 
            this.gbSituacao.Controls.Add(this.optInativos);
            this.gbSituacao.Controls.Add(this.optAtivos);
            this.gbSituacao.Controls.Add(this.optTodos);
            this.gbSituacao.Location = new System.Drawing.Point(13, 67);
            this.gbSituacao.Name = "gbSituacao";
            this.gbSituacao.Size = new System.Drawing.Size(407, 51);
            this.gbSituacao.TabIndex = 3;
            this.gbSituacao.TabStop = false;
            this.gbSituacao.Text = "Situação";
            // 
            // optInativos
            // 
            this.optInativos.AutoSize = true;
            this.optInativos.Location = new System.Drawing.Point(271, 19);
            this.optInativos.Name = "optInativos";
            this.optInativos.Size = new System.Drawing.Size(107, 17);
            this.optInativos.TabIndex = 2;
            this.optInativos.TabStop = true;
            this.optInativos.Text = "Somente Inativos";
            this.optInativos.UseVisualStyleBackColor = true;
            this.optInativos.CheckedChanged += new System.EventHandler(this.optInativos_CheckedChanged);
            // 
            // optAtivos
            // 
            this.optAtivos.AutoSize = true;
            this.optAtivos.Location = new System.Drawing.Point(136, 19);
            this.optAtivos.Name = "optAtivos";
            this.optAtivos.Size = new System.Drawing.Size(99, 17);
            this.optAtivos.TabIndex = 1;
            this.optAtivos.TabStop = true;
            this.optAtivos.Text = "Somente Ativos";
            this.optAtivos.UseVisualStyleBackColor = true;
            this.optAtivos.CheckedChanged += new System.EventHandler(this.optAtivos_CheckedChanged);
            // 
            // optTodos
            // 
            this.optTodos.AutoSize = true;
            this.optTodos.Location = new System.Drawing.Point(44, 19);
            this.optTodos.Name = "optTodos";
            this.optTodos.Size = new System.Drawing.Size(55, 17);
            this.optTodos.TabIndex = 0;
            this.optTodos.TabStop = true;
            this.optTodos.Text = "Todos";
            this.optTodos.UseVisualStyleBackColor = true;
            this.optTodos.CheckedChanged += new System.EventHandler(this.optTodos_CheckedChanged);
            // 
            // gbListagem
            // 
            this.gbListagem.Controls.Add(this.lvlListagem);
            this.gbListagem.Location = new System.Drawing.Point(13, 125);
            this.gbListagem.Name = "gbListagem";
            this.gbListagem.Size = new System.Drawing.Size(407, 237);
            this.gbListagem.TabIndex = 4;
            this.gbListagem.TabStop = false;
            this.gbListagem.Text = "Listagem de dados";
            // 
            // lvlListagem
            // 
            this.lvlListagem.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvlListagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvlListagem.FullRowSelect = true;
            this.lvlListagem.GridLines = true;
            this.lvlListagem.HideSelection = false;
            this.lvlListagem.Location = new System.Drawing.Point(3, 16);
            this.lvlListagem.Name = "lvlListagem";
            this.lvlListagem.Size = new System.Drawing.Size(401, 218);
            this.lvlListagem.TabIndex = 0;
            this.lvlListagem.UseCompatibleStateImageBehavior = false;
            this.lvlListagem.DoubleClick += new System.EventHandler(this.lvlListagem_DoubleClick);
            // 
            // FrmPesquisaGenericaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 432);
            this.Controls.Add(this.gbListagem);
            this.Controls.Add(this.gbSituacao);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.lblBusca);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPesquisaGenericaCliente";
            this.ShowIcon = false;
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.FrmPesquisaGenerica_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gbSituacao.ResumeLayout(false);
            this.gbSituacao.PerformLayout();
            this.gbListagem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.RadioButton optInativos;
        private System.Windows.Forms.RadioButton optAtivos;
        private System.Windows.Forms.RadioButton optTodos;
        private System.Windows.Forms.GroupBox gbListagem;
        private System.Windows.Forms.ListView lvlListagem;
        public System.Windows.Forms.GroupBox gbSituacao;
    }
}