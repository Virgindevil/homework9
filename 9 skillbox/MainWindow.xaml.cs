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

namespace _9_skillbox
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }        

        private void SplitButton_Click(object sender, RoutedEventArgs e)
        {
            string[] sentence = SplitText.Text.Split(' ');
            SplitResult.Items.Clear();
            for (int i = 0; i < sentence.Length; i++)
            {
                if(sentence[i] != "")
                {
                    SplitResult.Items.Add(sentence[i]);
                }                
            }
        }

        private void ReverseButton_Click(object sender, RoutedEventArgs e)
        {
            string[] sentence = ReverseText.Text.Split(' ');
            Array.Reverse(sentence);
            ReverseResult.Content = "";
            foreach (string word in sentence)
            {
                ReverseResult.Content += $"{word} ";
            }

        }
    }
}
