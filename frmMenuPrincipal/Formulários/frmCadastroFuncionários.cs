﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMenuPrincipal.Formulários
{
	public partial class frmCadastroFuncionários : Form
	{
		public frmCadastroFuncionários()
		{
			InitializeComponent();
		}

		private void frmCadastroFuncionários_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'dsPrincipal.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
			this.funcionarioTableAdapter.Fill(this.dsPrincipal.Funcionario);

		}

		private void btnLimparCampos_Click(object sender, EventArgs e)
		{
			foreach (Control item in pnlCampos.Controls)
			{
				if (item is TextBox)
				{
					(item as TextBox).Clear();
				}
				if (item is MaskedTextBox)
				{
					(item as MaskedTextBox).Clear();
				}
				if (item is DateTimePicker)
				{
					dtpDataNascimento.Value = DateTime.Now;
				}
			}
		}
	}
}
