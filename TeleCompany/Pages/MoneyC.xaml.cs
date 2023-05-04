using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using TeleCompany.Modules;

namespace TeleCompany.Pages
{

    public partial class MoneyC : Page
    {
        public MoneyC()
        {
            InitializeComponent();
        }

        TVcompanyEntities db = new TVcompanyEntities();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MoneyAdd();
            NavigationService.GoBack();
        }

        public void MoneyAdd()
        {
            var balanceid = db.CustomersBalance.Where(x => x.id_Customer == InfoS.number).FirstOrDefault();
            if (balanceid !=null)
            {
                balanceid.Balans += Convert.ToDecimal(MoneyCount.Text);
                db.CustomersBalance.AddOrUpdate(balanceid);
            }
            else
            {
                CustomersBalance d = new CustomersBalance()
                {
                    Balans = Convert.ToDecimal(MoneyCount.Text),
                    id_Customer = InfoS.number,
                };
                db.CustomersBalance.Add(d);
            }
            db.SaveChanges();
        }
    }
}
