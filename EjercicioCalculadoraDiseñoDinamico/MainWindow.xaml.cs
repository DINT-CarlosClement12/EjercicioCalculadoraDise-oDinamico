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

namespace EjercicioCalculadoraDiseñoDinamico
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddButtons();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            resultTextBlock.Text += ((Button)sender).Tag;
        }

        private void AddButtons()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int currentButtonValue = (i - 1) * 3 + j + 1;

                    TextBlock textBlock = new TextBlock
                    {
                        Text = currentButtonValue.ToString()
                    };
                    Viewbox viewbox = new Viewbox
                    {
                        Child = textBlock
                    };
                    Button button = new Button
                    {
                        Tag = currentButtonValue,
                        Margin = new Thickness(5),
                        Content = viewbox
                    };

                    button.SetValue(Grid.RowProperty, i);
                    button.SetValue(Grid.ColumnProperty, j);
                    button.Click += new RoutedEventHandler(ButtonClick); 
                 
                    MainGrid.Children.Add(button);
                }
            }
        }
    }
}
