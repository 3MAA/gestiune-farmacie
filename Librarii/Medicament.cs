using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarii
{
	public class Medicament
	{
		private const string SEPARATOR_AFISARE = " ";
		private const char SEPARATOR_PRINCIPAL_FISIER = ';';

		private const int ID = 0;
		private const int COD = 1;
		private const int CANTITATE = 2;
		private const int NUME = 3;
		private const int TIP = 4;
		private const int DATA = 5;

		public enum TipMedicament
		{
			Pastila = 1,
			Crema = 2,
			Sirop = 3,
			End = 4,
		};

		public static int IdUltimul { get; set; }
		public int Id { get; set; }
		public string nume { get; set; }
		public int cod { get; set; }
		public DateTime dataExpirare { get; set; }
		public int cantitate { get; set; }
		public TipMedicament tip { get; set; }

		public Medicament()
		{
			nume = String.Empty;
			cod = 0;
			IdUltimul++;
			Id = IdUltimul;
		}
		public Medicament(string nume, int cod)
		{
			this.nume = nume;
			this.cod = cod;
			IdUltimul++;
			Id = IdUltimul;
		}
		public Medicament(string linieFisier)
		{
			string[] dataFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

			Id = Convert.ToInt32(dataFisier[ID]);
			cod = Convert.ToInt32(dataFisier[COD]);
			cantitate = Convert.ToInt32(dataFisier[CANTITATE]);
			nume = dataFisier[NUME];
			tip = (TipMedicament)Convert.ToInt32(dataFisier[TIP]);
			dataExpirare = Convert.ToDateTime(dataFisier[DATA]);
			IdUltimul = Id;
		}

		public string ConversieLaSir_PentruAfisare()
		{
			return $"id: {Id}, cod: {cod}, cantitate: {cantitate}, nume: {nume}, tip: {(TipMedicament)tip}, data și ora expirării: {dataExpirare.ToString()}";

		}
		public string ConversieLaSir_PentruScriereInFisier()
		{
			return string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}", SEPARATOR_PRINCIPAL_FISIER, Id, cod, cantitate, nume, (int)tip, dataExpirare);
		}
	}
}
