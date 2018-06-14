﻿using frmMenuPrincipal.Formulários;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMenuPrincipal
{
	public partial class frmMenuPrincip : MaterialForm
	{
		public frmMenuPrincip()
		{
			InitializeComponent();
           
        }

		private void frmMenuPrincipal_Load(object sender, EventArgs e)
		{
			//         frmCadPrincipais frmatendimento = new frmCadPrincipais();
			//frmatendimento.MdiParent = this;
			//frmatendimento.Show();
			//frmatendimento.Anchor = AnchorStyles.Bottom;
			tslHora.Text = DateTime.Now.ToString();
			timerHora.Enabled = true;
		}

		private void tsbtnSair_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.NomeUsuarioLogado = "";
			Properties.Settings.Default.NivelUsuarioLogado = 0;
			frmLogin frmlogin = new frmLogin();
			frmlogin.Show();
			Hide();
		}

		private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.NomeUsuarioLogado = "";
			Properties.Settings.Default.NivelUsuarioLogado = 0;
			frmLogin frmlogin = new frmLogin();
			frmlogin.Show();
			Hide();
		}

        private void tsmCadastrosPrincipais_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCadPrincipais"] == null)
            {
                frmCadPrincipais frmCadastros = new frmCadPrincipais { MdiParent = this };
                frmCadastros.Show();
            }
        }

        private void tsmCadastroFornecimento_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCadFornecimento"] == null) 
            {
                frmCadFornecimento FrmCadFornecimento = new frmCadFornecimento { MdiParent = this };
                FrmCadFornecimento.Show();
            }

        }

        private void tsmBackup_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmBackup"] == null)
            {
                frmBackup FrmBackup = new frmBackup();
                FrmBackup.Show();
            }
        }

		private void timerHora_Tick(object sender, EventArgs e)
		{
			tslHora.Text = DateTime.Now.ToString();
		}
	}
}
