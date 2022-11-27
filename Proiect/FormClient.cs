using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Librarii;
using NivelAccesData;

namespace Proiect
{
	public partial class FormClient : Form
	{
		IStocareDataMedicamente adminMedicamente = StocareFactory.GetAdministratorStocareMedicamente();
		public FormClient()
		{
			InitializeComponent();
			FormBorderStyle = FormBorderStyle.None;
			WindowState = FormWindowState.Maximized;
			buttonAdauga.Visible = false;
			afisareMedicamte();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void comboBoxCantitate_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void listBoxMedicamente_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxMedicamente.SelectedIndex != -1)
			{
				ArrayList medicamente = adminMedicamente.GetMedicamente();
				Medicament medicamentSelectat = (Medicament)medicamente[listBoxMedicamente.SelectedIndex];
				labelMedicamentSelectatStatus.Text = medicamentSelectat.ConversieLaSir_PentruAfisare();

			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (listBoxMedicamente.SelectedIndex != -1)
			{
				ArrayList medicamente = adminMedicamente.GetMedicamente();
				Medicament medicamentSelectat = (Medicament)medicamente[listBoxMedicamente.SelectedIndex];

				bool isInt = Int32.TryParse(textBoxCantitate.Text, out int cantitate);
				if (cantitate <= medicamentSelectat.cantitate && isInt && cantitate > 0)
				{
					labelCantitate.BackColor = Color.Green;
					buttonAdauga.Visible = true;
				}
				else
				{
					labelCantitate.BackColor = Color.Red;
					buttonAdauga.Visible = false;

				}
			}
		}

		private void buttonInapoi_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonFinalizareComanda_Click(object sender, EventArgs e)
		{
			var rand = new Random();
			var random = rand.Next();

			DialogResult res = MessageBox.Show("Sunteți sigur că doriți să finalizați comanda nr. (" + random + ")?", "Confirmare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
			if (res == DialogResult.OK)
			{
				listBoxMedicamenteComanda.Items.Clear();
				labelComandaStatus.Text = "Status comandă: Comanda dvs. cu nr. " + random + " a fost finalizată cu succes!";
			}
			else
			{
				labelComandaStatus.Text = "Status comandă: Comanda nu a fost finalizată cu succes! Vă rugăm să încercați încă o dată!";
			}
		}

		private void buttonAdauga_Click(object sender, EventArgs e)
		{
			if (listBoxMedicamente.SelectedIndex != -1)
			{
				int i = listBoxMedicamente.SelectedIndex;
				ArrayList medicamente = adminMedicamente.GetMedicamente();
				Medicament medicamentSelectat = (Medicament)medicamente[i];
				Medicament medicamentComanda = medicamentSelectat;

				bool isInt = Int32.TryParse(textBoxCantitate.Text, out int cantitate);
				if ((cantitate <= medicamentSelectat.cantitate) && isInt && (textBoxCantitate.Text != string.Empty))
				{
					labelCantitate.BackColor = Color.Green;

					medicamentSelectat.cantitate -= cantitate;
					adminMedicamente.EditareMedicament(i, medicamentSelectat);
					medicamentComanda.cantitate = cantitate;

					listBoxMedicamenteComanda.Items.Add(medicamentComanda.ConversieLaSir_PentruAfisare());

					labelMedicamentSelectatStatus.Text = "Medicamentul a fost adăugat cu succes!";
				}
				else
				{
					labelCantitate.BackColor = Color.Red;
					labelMedicamentSelectatStatus.Text = "Medicamentul nu a fost adăugat cu succes!";
				}
			}
			afisareMedicamte();
			buttonAdauga.Visible = false;
		}
		private void afisareMedicamte()
		{
			ArrayList medicamente = adminMedicamente.GetMedicamente();

			listBoxMedicamente.Items.Clear();
			foreach (Medicament m in medicamente)
			{
				listBoxMedicamente.Items.Add(((Medicament)m).ConversieLaSir_PentruAfisare());
			}
		}

        private void labelComandaStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
