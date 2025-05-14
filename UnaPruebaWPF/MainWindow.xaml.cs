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
        //private readonly ObservableCollection<string> milista;

        public MainWindow()
        {
            InitializeComponent();

            //milista = ((ModeloVista)DataContext).Milista;
        }

        private void ClickBoton(object sender, RoutedEventArgs e)
        {
            string dato = EntradaTexto.Text.Trim();

            if (!string.IsNullOrWhiteSpace(dato))
            {
                Efectos.Capitalizar(ref dato);
                MiModelo.Milista.Add(dato);
            }
            EntradaTexto.Text = "";
        }

        private void ListaNombres_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string? dato = ListaNombres.SelectedItem as string;

            // if(dato is null) { return ; }

            VerElemento();
        }

        private void VerElemento()
        {
            if (ListaNombres.SelectedItem is string dato)
            {
                if (!string.IsNullOrWhiteSpace(dato.Trim()))
                {
                    ElementoLista.Content = dato + $" ({ListaNombres.SelectedIndex})";
                }
            }
        }

        private void ClickModificar(object sender, RoutedEventArgs e)
        {
            string dato = EntradaTexto.Text.Trim();
            int indice = ListaNombres.SelectedIndex;

            if (!string.IsNullOrWhiteSpace(dato) && ( indice >= 0))
            {
                string modificacion = $"{ListaNombres.SelectedItem} --> ";

                Efectos.Capitalizar(ref dato);
                MiModelo.Milista[ListaNombres.SelectedIndex] = dato;
                ListaNombres.SelectedIndex = indice;
                modificacion += $"{dato}";
                LabelCambios.Content = modificacion;
            }
            EntradaTexto.Text = "";
        }
    }
}