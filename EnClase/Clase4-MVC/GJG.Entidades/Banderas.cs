namespace Paises
{
    public static class Banderas
    {
        private static readonly Dictionary<string, string> CodigosPaises = new(
            StringComparer.OrdinalIgnoreCase
        )
        {
            { "Argentina", "ar" },
            { "España", "es" },
            { "México", "mx" },
            { "Italia", "it" },
            { "Reino Unido", "gb" },
            { "Alemania", "de" },
            { "Francia", "fr" },
            { "Brasil", "br" },
            { "Canadá", "ca" },
            { "Estados Unidos", "us" },
            { "Japón", "jp" },
            { "China", "cn" },
            { "India", "in" },
            { "Australia", "au" },
            { "Rusia", "ru" },
            { "Sudáfrica", "za" },
            { "Suecia", "se" },
            { "Noruega", "no" },
            { "Finlandia", "fi" },
            { "Países Bajos", "nl" },
            { "Suiza", "ch" },
            { "Bélgica", "be" },
            { "Portugal", "pt" },
            { "Grecia", "gr" },
            {"Austria", "at"},
            {"Polonia", "pl"},
            {"Hungría", "hu"},
            {"República Checa", "cz"},
            {"Turquía", "tr"},
            {"Corea del Sur", "kr"},
            {"Nueva Zelanda", "nz"},
            {"Singapur", "sg"},
            {"Malasia", "my"},
            {"Tailandia", "th"},
            {"Indonesia", "id"},
            {"Filipinas", "ph"},
            {"Vietnam", "vn"},
            {"Pakistán", "pk"},
            {"Bangladesh", "bd"},
            {"Sri Lanka", "lk"},
            {"Nepal", "np"},
            {"Bhután", "bt"},
        };

        public static string ObtenerCodigoIso(string nombrePais)
        {
            if (
                !string.IsNullOrEmpty(nombrePais)
                && CodigosPaises.TryGetValue(nombrePais, out var codigo)
            )
            {
                return codigo;
            }
            return string.Empty;
        }
    }
}
