using DemExamApp.Context;
using DemExamApp.Entities;
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
using System.Windows.Shapes;

namespace DemExamApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для MaterialManageWindow.xaml
    /// </summary>
    public partial class MaterialManageWindow : Window
    {
        private Material? _material;

        public MaterialManageWindow(Material? material)
        {
            InitializeComponent();

            using (AppDbContext _ctx = new())
            {
                MaterialTypeComboBox.ItemsSource = _ctx.MaterialTypes.ToList();
                MaterialTypeComboBox.DisplayMemberPath = "Title";
                MaterialTypeComboBox.SelectedValuePath = "Id";
            }


            if (material == null)
            {
                Title = "Добавление материала";
                _material = new Material();
            }
            else
            {
                Title = "Редактирование материала";
                _material = material;
                TitleTextBox.Text = _material.Title;
                CountOnStorageTextBox.Text = _material.CountOnStorage.ToString();
                MeasurementTextBox.Text = _material.UnitOfMeasurement.ToString();
                CountInPackageTextBox.Text = _material.CountInPackage.ToString();
                MinCountTextBox.Text = _material.MinCount.ToString();
                CostPerUnitTextBox.Text = _material.PricePerUnit.ToString();
                MaterialTypeComboBox.SelectedValue = _material.MaterialTypeId;
            }
        }

        private void TitleTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _material!.Title = TitleTextBox.Text;
        }

        private void CountOnStorageTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (decimal.TryParse(CountOnStorageTextBox.Text, out decimal result))
            {
                _material!.CountOnStorage = result;
            }
            else
            {
                CountOnStorageTextBox.Text = (_material!.CountOnStorage = 0).ToString();
            }
        }

        private void MeasurementTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _material!.UnitOfMeasurement = MeasurementTextBox.Text;
        }

        private void CountInPackageTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (decimal.TryParse(CountInPackageTextBox.Text, out decimal result))
            {
                _material!.CountInPackage = result;
            }
            else
            {
                CountInPackageTextBox.Text = (_material!.CountInPackage = 0).ToString();
            }
        }

        private void MinCountTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (decimal.TryParse(MinCountTextBox.Text, out decimal result))
            {
                _material!.MinCount = result;
            }
            else
            {
                MinCountTextBox.Text = (_material!.MinCount = 0).ToString();
            }
        }

        private void CostPerUnitTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (decimal.TryParse(CostPerUnitTextBox.Text, out decimal result))
            {
                _material!.PricePerUnit = result;
            }
            else
            {
                CostPerUnitTextBox.Text = (_material!.PricePerUnit = 0).ToString("C");
            }
        }
    }
}
