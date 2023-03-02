using System;
using System.Collections.Generic;

namespace ServerListener.ServerModel
{
    static class Products
    {
        public static Dictionary<string, string> listProduct = new Dictionary<string, string>()
        {
            {"Суп гороходый","Рецепт супа горохового" },
            { "Борщ", "Рецепт борща"},
            { "Салат \"Цезарь\"","Рецепт салата Цезаря"}
        };

        public static string getRecipe(string dish)
        {
            string recipe = "";
            try
            {
                recipe = listProduct[dish];
            }
            catch (Exception ex)
            {
                recipe = "Неизвестное блюдо";
            }
            return recipe;
        }
    }
}
