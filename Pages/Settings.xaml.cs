using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ApplicationSettings_Kylosov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
        ColorDialog colorDialog = new ColorDialog();
        public Settings(MainWindow _mainWindow)
        {
            InitializeComponent();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Access files (*.accdb)|*.accdb|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            colorDialog.AllowFullOpen = true;
            colorDialog.ShowHelp = false;
        }
        private void OpenDataBase(object sender, RoutedEventArgs e)
        {
            if(openFileDialog.ShowDialog() = DialogResult.OK)
                tb_database.Text = openFileDialog.FileName;
        }
        
        private void SelectColorApplication(object sender, RoutedEventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Color color = colorDialog.Color;

                gr_header.Background = new SolidColorBrush();
            }
        }
    }
}
