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
using KrnlAPI;

namespace custom_ui_template_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        KrnlApi krnlAPI = new KrnlApi();

        public MainWindow()
        {
            InitializeComponent();
            krnlAPI.Initialize();
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if(krnlAPI.IsInjected())
            {
                krnlAPI.Execute(Editor.Text);
            }
            else
            {
                MessageBox.Show("Please inject before executing a script");
            }
        }

        private void Button_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            if (!krnlAPI.IsInjected())
            {
                krnlAPI.Inject();
            }
            else
            {
                MessageBox.Show("Already injected");
            }
        }

        private void Button_MouseUp_2(object sender, MouseButtonEventArgs e)
        {
            Editor.Text = "";
        }
    }
}
