using System.Collections.ObjectModel;
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

namespace UnaPruebaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ObservableCollection<string> milista;

        public MainWindow()
        {
            InitializeComponent();

            milista = ((ModeloVista)DataContext).Milista;
        }

        private void ClickBoton(object sender, RoutedEventArgs e)
        {
            string dato = EntradaTexto.Text.Trim();

            if (!string.IsNullOrWhiteSpace(dato))
            {
                Efectos.Capitalizar(ref dato);
                milista.Add(dato);
                EntradaTexto.Text = "";
            }
            EntradaTexto.Text = "";
        }

        private void ListaNombres_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string dato = "";

            switch (e.AddedItems.Count)
            {
                case 1:
                    dato = (string)(e.AddedItems[0]);
                    break;
                case 0:
                    dato = "Ningún elemento seleccionado";
                    break;
                default:
                    dato = "Demasiados elementos seleccionados";
                    break;
            }
        }
    }
}