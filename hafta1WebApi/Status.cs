using System.Collections.Generic;

namespace hafta1WebApi
{
    public class Status
    {
        public static string aktif = "Aktif";
        public static string pasif = "Pasif";

        public static List<string> getStatus()
        {
            List<string> stat = new List<string>();
            stat.Add(aktif);
            stat.Add(pasif);

            return stat;
        }
    }
}
