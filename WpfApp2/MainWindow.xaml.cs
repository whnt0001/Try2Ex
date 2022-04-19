using ClassLibrary1;
using ClassLibrary1.Sourse;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ClassRepos repos;
        public Class1 repos2;
        public MainWindow()
        {
            InitializeComponent();
            repos = new ClassRepos();
            repos2 = new Class1(repos);
            Update();
        }
        public void Update()
        {
            listm.ItemsSource = repos2.GetAllList();
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            ClassApp classApp = (ClassApp)listm.SelectedItem;
            repos2.DeleteV(classApp);
            Update();
        }
    }
}
