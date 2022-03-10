using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserDaoLibrary;

namespace WpfUserDbFrontEnd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserDao dao = new UserDao();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPressMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("you clicked the button");
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            List<User> users = dao.GetUsers();

            foreach(var user in users)
            {
                lstUsers.Items.Add(user);
            }
        }

        private void lstUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User user = (User)lstUsers.SelectedItem;

            txtId.Text = $"{user.Id}";
            txtName.Text = user.Name;
            txtEmail.Text = user.Email;
            chkActive.IsChecked = user.Active;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, RoutedEventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtName.IsReadOnly = false;
            txtEmail.Text = "";
            txtEmail.IsReadOnly = false;
            chkActive.IsChecked = false;
            chkActive.IsEnabled = true;

            btnSave.IsEnabled = true;
            btnAdd.IsEnabled = false;
        }
    }
}
