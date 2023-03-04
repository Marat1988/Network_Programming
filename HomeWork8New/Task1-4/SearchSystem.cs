
namespace Task1_4
{
    public class SearchSystem
    {
        private string nameSearchSystem; //наименование поисковой системы
        private string textSearch; //Текст поиска
        private int idContent; //Id поиска контента

        public SearchSystem(string nameSearchSystem, string textSearch, int idContent)
        {
            this.nameSearchSystem = nameSearchSystem;
            this.textSearch = textSearch;
            this.idContent = idContent;
        }

        public string LineSearch()
        {
            string search = "";
            switch (nameSearchSystem)
            {
                case @"https://yandex.ru/":
                    switch (idContent)
                    {
                        case 0:
                            search = @"https://yandex.ru/search/?text=" + textSearch;
                            break;
                        case 1:
                            search = @"https://yandex.ru/images/search?text=" + textSearch;
                            break;
                    }
                    break;
                default:
                    switch (idContent)
                    {
                        case 0:
                            search = @"https://www.google.com/search?q=" + textSearch;
                            break;
                        case 1:
                            search = @"https://www.google.com/search?q=" + textSearch + "&tbm=isch";
                            break;
                    }
                    break;
            }
            return search;
        }
    }
}