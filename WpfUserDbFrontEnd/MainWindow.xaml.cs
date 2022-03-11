using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

        BackgroundWorker bgWorker;


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

        private void btnLongRunningProcess_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLongRunningProcess_Click_1(object sender, RoutedEventArgs e)
        {
            Thread.Sleep(5000);
        }

        private void btnStartBackgroundWorker_Click(object sender, RoutedEventArgs e)
        {

            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.ProgressChanged += BgWorker_ProgressChanged;
            bgWorker.WorkerReportsProgress = true;
            bgWorker.WorkerSupportsCancellation = true;
            bgWorker.RunWorkerAsync();

            btnCancel.IsEnabled = true;
            btnStartBackgroundWorker.IsEnabled = false;
        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgMain.Value = e.ProgressPercentage;
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i=0; i<500; i++)
            {
                Thread.Sleep(100);
                bgWorker.ReportProgress(i / 5);

                if (bgWorker.CancellationPending)
                {
                    break;
                }
            }

            //MessageBox.Show("finished");
            /*
            MessageBox.Show("starting...");
            Thread.Sleep(5000);
            MessageBox.Show("finished");
            */
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            bgWorker.CancelAsync();
            btnCancel.IsEnabled = false;
            btnStartBackgroundWorker.IsEnabled = true;
        }
    }
}
