using System.Collections.Generic;

namespace ServerListener.ServerModel
{
    class Info
    {
        private static Dictionary<string, double> kurs = new Dictionary<string, double>()
        {
            { "USD EURO", 0.94805},
            { "EURO USD", 1.05},
            { "EURO RUB", 79.57},
            { "USD RUB", 74.71},
        };

        public static Dictionary<string, string> logins = new Dictionary<string, string>
        {
            { "Admin", "1234"}
        };

        public static string getInfoKurs(string param)
        {
            return param + " = " + kurs[param];
        }
    }
}
