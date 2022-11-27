using System;
using Librarii;
using System.IO;
using System.Collections;

namespace NivelAccesData
{
	public class AdministrareMedicamente_FisierText : IStocareDataMedicamente
	{
		string numeFisierMedicamente { get; set; }
		public AdministrareMedicamente_FisierText(string numeFisierMedicamente)
		{
			this.numeFisierMedicamente = numeFisierMedicamente;
			Stream sFisierText = File.Open(numeFisierMedicamente, FileMode.OpenOrCreate);
			sFisierText.Close();
		}
		public void AdaugaMedicament(Medicament medicamentNou)
		{
			try
			{
				using (StreamWriter swFisierText = new StreamWriter(numeFisierMedicamente, true))
				{
					swFisierText.WriteLine(medicamentNou.ConversieLaSir_PentruScriereInFisier());
				}
			}
			catch (IOException eIO)
			{
				throw new Exception("Eroare la deschiderea fișierului. Mesaj: " + eIO.Message);
			}
			catch (Exception eGen)
			{
				throw new Exception("Eroare generică. Mesaj: " + eGen.Message);
			}
		}
		public ArrayList GetMedicamente()
		{
			ArrayList medicamente = new ArrayList();

			try
			{
				using (StreamReader sRead = new StreamReader(numeFisierMedicamente))
				{
					string line;
					while ((line = sRead.ReadLine()) != null)
					{
						Medicament medicamentDinFisier = new Medicament(line);
						medicamente.Add(medicamentDinFisier);
					}
				}
			}
			catch (IOException eIO)
			{
				throw new Exception("Eroare la deschiderea fișierului. Mesaj: " + eIO.Message);
			}
			catch (Exception eGen)
			{
				throw new Exception("Eroare generică. Mesaj: " + eGen.Message);
			}

			return medicamente;
		}
		public Medicament GetMedicament(string nume)
		{
			ArrayList medicamente = new ArrayList();

			try
			{
				using (StreamReader sr = new StreamReader(numeFisierMedicamente))
				{
					string line;
					while ((line = sr.ReadLine()) != null)
					{
						Medicament studentDinFisier = new Medicament(line);
						if (studentDinFisier.nume == nume)
							return studentDinFisier;
					}
				}
			}
			catch (IOException eIO)
			{
				throw new Exception("Eroare la deschiderea fișierului. Mesaj: " + eIO.Message);
			}
			catch (Exception eGen)
			{
				throw new Exception("Eroare generică. Mesaj: " + eGen.Message);
			}

			return null;
		}
		public bool EditareMedicament(int index, Medicament medicamentEditat)
		{
			ArrayList medicamente = GetMedicamente();
			bool actualizareCuSucces = false;
			try
			{
				using (StreamWriter swFisierText = new StreamWriter(numeFisierMedicamente, false))
				{
					foreach (Medicament medicament in medicamente)
					{
						Medicament medicamentPentruScrisInFisier = medicament;

						if (medicamente[index] == medicament)
						{
							medicamentPentruScrisInFisier = medicamentEditat;
						}
						swFisierText.WriteLine(medicamentPentruScrisInFisier.ConversieLaSir_PentruScriereInFisier());
					}
					actualizareCuSucces = true;
				}
			}
			catch (IOException eIO)
			{
				throw new Exception("Eroare la deschiderea fișierului. Mesaj: " + eIO.Message);
			}
			catch (Exception eGen)
			{
				throw new Exception("Eroare generică. Mesaj: " + eGen.Message);
			}
			return actualizareCuSucces;
		}
		public bool StergereMedicament(int index)
		{
			ArrayList medicamente = GetMedicamente();
			bool actualizareCuSucces = false;
			int i = 0;
			try
			{
				using (StreamWriter swFisierText = new StreamWriter(numeFisierMedicamente, false))
				{
					foreach (Medicament medicament in medicamente)
					{
						if (i != index)
						{
							swFisierText.WriteLine(medicament.ConversieLaSir_PentruScriereInFisier());
						}
						i++;
					}
					actualizareCuSucces = true;
				}
			}
			catch (IOException eIO)
			{
				throw new Exception("Eroare la deschiderea fișierului. Mesaj: " + eIO.Message);
			}
			catch (Exception eGen)
			{
				throw new Exception("Eroare generică. Mesaj: " + eGen.Message);
			}
			return actualizareCuSucces;
		}
	}
}
