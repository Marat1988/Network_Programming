using System.Collections.Generic;

namespace ServerListener.ServerModel
{
    static class Products
    {
        public static Dictionary<string, decimal> listProduct = new Dictionary<string, decimal>()
        {
            {"Бананы",2000 },
            { "Кокосы", 4000},
            { "Салат \"Цезарь\"",8000},
            { "Мандарины",12000},
            { "Оливье",15000}
        };
    }
}
