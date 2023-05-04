using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TeleCompany.Modules;

namespace TeleCompany.Pages
{
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }
        TVcompanyEntities db = new TVcompanyEntities();
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Registration());
        }

        private void Sign_Click(object sender, RoutedEventArgs e)
        {
            SignUp(LoginBox.Text, PasswordBox.Password);
        }
        public void SignUp(string name, string password) // Проверка ролей в логинах пользователей и вход
        {
            var obj = db.Account.Where(x => x.Login == name && x.Password == password).FirstOrDefault();
            var obj1 = db.Analyst.ToList();
            var obj2 = db.Director.ToList();
            var obj3 = db.Customer.ToList();
            var obj4 = db.Manager.ToList();
            if (obj != null)
            {
                foreach (var item in obj1)
                {
                    if (obj.id_ac == item.id_ac) // Analyst
                    {
                        InfoS.number = obj.id_ac;
                        NavigationService.Navigate(new Order());
                        var s = db.Analyst.Where(x => x.id_ac == InfoS.number).FirstOrDefault();
                        InfoS.number = s.id_Analyst;
                    }
                }
                foreach (var item in obj2) // Director
                {
                    if (obj.id_ac == item.id_ac)
                    {
                        InfoS.number = obj.id_ac;
                        NavigationService.Navigate(new Order()); 
                        var s = db.Director.Where(x => x.id_ac == InfoS.number).FirstOrDefault();
                        InfoS.number = s.id_Director;
                    }
                }
                foreach (var item in obj3) // Customre
                {
                    if (obj.id_ac == item.id_ac)
                    {
                        InfoS.number = obj.id_ac;
                        NavigationService.Navigate(new Order()); 
                        var s = db.Customer.Where(x => x.id_ac == InfoS.number).FirstOrDefault();
                        InfoS.number = s.id_Customer;

                    }
                }
                foreach (var item in obj4) // Manager
                {
                    if (obj.id_ac == item.id_ac)
                    {
                        InfoS.number = obj.id_ac;
                        NavigationService.Navigate(new Order());
                        var s = db.Manager.Where(x => x.id_ac == InfoS.number).FirstOrDefault();
                        InfoS.number = s.id_Manager;

                    }
                }
            }
            else
            {
                MessageBox.Show("No acc");
            }
        }
    }
}
