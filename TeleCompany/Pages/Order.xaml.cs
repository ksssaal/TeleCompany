using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TeleCompany.Modules;

namespace TeleCompany.Pages
{
    public partial class Order : Page
    {
        TVcompanyEntities db = new TVcompanyEntities();
        public Order()
        {
            InitializeComponent();
            fillmoneyblock();
        }
        public void fillmoneyblock()
        {
            var usermoney = db.CustomersBalance.Where(x => x.id_Customer == InfoS.number).FirstOrDefault();
            try
            {

            }
            catch
            {

            }
           
        }
        private void Moneyadd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MoneyC());
        }
    }
}
