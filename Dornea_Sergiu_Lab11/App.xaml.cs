using Dornea_Sergiu_Lab11.Data;
using Dornea_Sergiu_Lab11.Models;

namespace Dornea_Sergiu_Lab11

{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }
    }
}