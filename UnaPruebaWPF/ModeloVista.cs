using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnaPruebaWPF
{
    public class ModeloVista
    {
        public ObservableCollection<string> Milista { get; private set; } = new ObservableCollection<string>();

        public ModeloVista() {
            Milista.Add("Juan Hidalgo");
        }
    }
}
