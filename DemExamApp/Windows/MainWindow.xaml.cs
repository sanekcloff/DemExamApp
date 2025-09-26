using DemExamApp.Context;
using DemExamApp.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemExamApp.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RefreshList();
        }
        private void RefreshList()
        {
            MaterialsListView.ItemsSource = new AppDbContext().Materials.Include(m => m.MaterialType);
        }

        private void AddMaterialButton_Click(object sender, RoutedEventArgs e)
        {
            new MaterialManageWindow(null).ShowDialog();
            RefreshList();
        }

        private void MaterialsListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            new MaterialManageWindow((Material)MaterialsListView.SelectedItem).ShowDialog();
            RefreshList();
        }
    }
}