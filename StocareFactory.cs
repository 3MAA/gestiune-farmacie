using System.Configuration;
using NivelAccesData;

namespace Proiect
{
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER_MEDICAMENTE = "NumeFisierMedicamente";
        private const string NUME_FISIER_ANGAJATI = "NumeFisierAngajati";

        public static IStocareDataMedicamente GetAdministratorStocareMedicamente()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisierMedicamente = ConfigurationManager.AppSettings[NUME_FISIER_MEDICAMENTE];

            if (formatSalvare != null)
            {
                return new AdministrareMedicamente_FisierText(numeFisierMedicamente + "." + formatSalvare);
            }
            return null;
        }
        public static IStocareDataAngajati GetAdministratorStocareAngajati()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisierAngajati = ConfigurationManager.AppSettings[NUME_FISIER_ANGAJATI];

            if (formatSalvare != null)
            {
                return new AdministrareAngajati_FisierText(numeFisierAngajati + "." + formatSalvare);
            }
            return null;
        }
    }
}
