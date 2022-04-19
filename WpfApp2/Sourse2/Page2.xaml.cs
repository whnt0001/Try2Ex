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

namespace WpfApp2.Sourse2
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public ClassRepos repos;
        public Class1 repos2;
        public Page2()
        {
            InitializeComponent();
            repos = new ClassRepos();
            repos2 = new Class1(repos);
            Update();
        }
        public void Update()
        {
            Listv2.ItemsSource = repos2.GetAllList();
        }
    }
}
