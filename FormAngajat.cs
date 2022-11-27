using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Librarii;
using NivelAccesData;

namespace Proiect
{
	public partial class FormAngajat : Form
	{
		IStocareDataMedicamente adminMedicamente = StocareFactory.GetAdministratorStocareMedicamente();
		public FormAngajat(string numeAngajat)
		{
			InitializeComponent();
			FormBorderStyle = FormBorderStyle.None;
			WindowState = FormWindowState.Maximized;
			labelAngajatConectat.Text = "Angajatul/a: " + numeAngajat + " este conectat/ă!";
			buttonEditare.Visible = true;
			buttonStergere.Visible = true;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			afisareMedicamte();
			FreeData();
		}

		private void buttonAdauga_Click(object sender, EventArgs e)
		{
			Medicament medicamentNou = new Medicament();

			if (dataValide() == true)
			{
				medicamentNou.nume = textBoxNume.Text;
				medicamentNou.cod = Convert.ToInt32(textBoxCod.Text);
				medicamentNou.dataExpirare = dateTimePickerDataExpirarii.Value;
				medicamentNou.cantitate = Convert.ToInt32(textBoxCantitate.Text);
				medicamentNou.tip = getTip();
				adminMedicamente.AdaugaMedicament(medicamentNou);

				labelNume.BackColor = Color.WhiteSmoke;
				labelCantitate.BackColor = Color.WhiteSmoke;
				labelTip.BackColor = Color.WhiteSmoke;
				labelDataExpirarii.BackColor = Color.WhiteSmoke;
				labelCantitate.BackColor = Color.WhiteSmoke;
				labelCod.BackColor = Color.WhiteSmoke;

				labelStatus.Text = "Produsul a fost adăugat cu succes!";
			}
			else
			{
				labelStatus.Text = "Produsul nu a fost adăugat cu succes!";
			}
			FreeData();
		}
		private void FormAngajat_Load(object sender, EventArgs e)
		{

		}
		private Medicament.TipMedicament getTip()
		{
			if (radioButtonPastila.Checked)
			{
				return Medicament.TipMedicament.Pastila;
			}
			else if (radioButtonCrema.Checked)
			{
				return Medicament.TipMedicament.Crema;
			}
			else if (radioButtonSirop.Checked)
			{
				return Medicament.TipMedicament.Sirop;
			}
			return Medicament.TipMedicament.End;
		}
		private bool dataValide()
		{

			bool isInt = Int32.TryParse(textBoxNume.Text, out int result);
			if (!isInt && textBoxNume.Text != string.Empty)
			{
				labelNume.BackColor = Color.Green;
			}
			else
			{
				labelNume.BackColor = Color.Red;
				return false;
			}

			if (getTip() != Medicament.TipMedicament.End)
			{
				labelTip.BackColor = Color.Green;
			}
			else
			{
				labelTip.BackColor = Color.Red;
				return false;
			}

			isInt = Int32.TryParse(textBoxCod.Text, out result);
			if (isInt && textBoxCod.Text != string.Empty)
			{
				labelCod.BackColor = Color.Green;
			}
			else
			{
				labelCod.BackColor = Color.Red;
				return false;
			}

			if (dateTimePickerDataExpirarii.Value > DateTime.Now)
			{
				labelDataExpirarii.BackColor = Color.Green;
			}
			else
			{
				labelDataExpirarii.BackColor = Color.Red;
				return false;
			}

			isInt = Int32.TryParse(textBoxCantitate.Text, out result);
			if (isInt && textBoxCantitate.Text != string.Empty)
			{
				labelCantitate.BackColor = Color.Green;
			}
			else
			{
				labelCantitate.BackColor = Color.Red;
				return false;
			}
			return true;
		}

		private void comboBoxCantitate_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void listBoxMedicamente_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxMedicamente.SelectedIndex != -1)
			{
				buttonAdauga.Visible = true;
				buttonCauta.Visible = true;
				buttonEditare.Visible = true;
				buttonStergere.Visible = true;

				ArrayList medicamente = adminMedicamente.GetMedicamente();
				Medicament medicamentSelectat = (Medicament)medicamente[listBoxMedicamente.SelectedIndex];

				textBoxNume.Text = medicamentSelectat.nume;

				if (medicamentSelectat.tip == Medicament.TipMedicament.Pastila)
					radioButtonPastila.Checked = true;
				else if (medicamentSelectat.tip == Medicament.TipMedicament.Crema)
					radioButtonCrema.Checked = true;
				else if (medicamentSelectat.tip == Medicament.TipMedicament.Sirop)
					radioButtonSirop.Checked = true;

				textBoxCod.Text = Convert.ToString(medicamentSelectat.cod);
				dateTimePickerDataExpirarii.Value = medicamentSelectat.dataExpirare;
				textBoxCantitate.Text = Convert.ToString(medicamentSelectat.cantitate);
			}
		}

		private void buttonEditare_Click(object sender, EventArgs e)
		{
			buttonStergere.Visible = true;
			buttonCauta.Visible = true;
			buttonAdauga.Visible = true;

			int index = listBoxMedicamente.SelectedIndex;
			if (listBoxMedicamente.SelectedIndex != -1)
			{
				ArrayList medicamente = adminMedicamente.GetMedicamente();
				foreach (Medicament medicamentEditat in medicamente)
				{
					if (dataValide() == true && medicamente[index] == medicamentEditat)
					{
						medicamentEditat.nume = textBoxNume.Text;
						medicamentEditat.cod = Convert.ToInt32(textBoxCod.Text);
						medicamentEditat.dataExpirare = dateTimePickerDataExpirarii.Value;
						medicamentEditat.cantitate = Convert.ToInt32(textBoxCantitate.Text);
						medicamentEditat.tip = getTip();

						adminMedicamente.EditareMedicament(index, medicamentEditat);

						labelStatus.Text = "Medicamentul a fost editat cu succes!";
						continue;
					}
					else
					{
						labelStatus.Text = "Medicamentul nu a fost editat cu succes!";
						continue;
					}
				}
			}
			buttonEditare.Visible = true;
			FreeData();
		}

		private void buttonStergere_Click(object sender, EventArgs e)
		{
			buttonEditare.Visible = true;
			buttonCauta.Visible = true;
			buttonAdauga.Visible = true;

			int index = listBoxMedicamente.SelectedIndex;
			if (listBoxMedicamente.SelectedIndex != -1)
			{
				FreeData();
				DialogResult res = MessageBox.Show("Sunteți sigur că doriți să ștergeți medicamentul selectat?", "Confirmare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				if (res == DialogResult.OK)
				{
					if (adminMedicamente.StergereMedicament(index) == true)
					{
						labelStatus.Text = "Medicamentul a fost șters cu succes!";
						afisareMedicamte();

					}
				}
				else
				{
					labelStatus.Text = "Medicamentul nu a fost șters cu succes!";
				}
			}
			buttonStergere.Visible = true;
			FreeData();
		}

		private void button1_Cautare(object sender, EventArgs e)
		{
			buttonEditare.Visible = true;
			buttonStergere.Visible = true;
			buttonAdauga.Visible = true;

			bool isInt = Int32.TryParse(textBoxNume.Text, out int result);
			if (!isInt && textBoxNume.Text != string.Empty)
			{

				Medicament medicamentCautat = adminMedicamente.GetMedicament(textBoxNume.Text);
				if (medicamentCautat != null)
				{
					listBoxMedicamente.Items.Clear();
					listBoxMedicamente.Items.Add(medicamentCautat.ConversieLaSir_PentruAfisare());
					labelStatus.Text = "Medicamentul căutat a fost găsit cu succes!";
				}
				else
				{
					labelStatus.Text = "Medicamentul căutat nu există!";
				}

			}
			else
			{
				labelNume.BackColor = Color.Red;
			}
			buttonAdauga.Visible = true;
			FreeData();
		}
		private void FreeData()
		{
			textBoxNume.Text = string.Empty;
			textBoxCod.Text = string.Empty;
			dateTimePickerDataExpirarii.Value = DateTime.Now;
			textBoxCantitate.Text = string.Empty;
			radioButtonPastila.Checked = false;
			radioButtonCrema.Checked = false;
			radioButtonSirop.Checked = false;
		}

		private void label1_Click_1(object sender, EventArgs e)
		{

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

		private void buttonInapoi_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void textBoxNume_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBoxCod_TextChanged(object sender, EventArgs e)
		{

		}

        private void dateTimePickerDataExpirarii_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
