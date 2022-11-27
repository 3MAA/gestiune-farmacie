using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librarii;

namespace NivelAccesData
{
	public interface IStocareDataMedicamente
	{
		void AdaugaMedicament(Medicament medicamentNou);
		ArrayList GetMedicamente();
		Medicament GetMedicament(string nume);
		bool EditareMedicament(int index, Medicament medicamenteEditata);
		bool StergereMedicament(int index);
	}
}
