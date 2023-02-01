using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej8_Administrador_de_tareas.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class CategoriaModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int ContTareas { get; set; }
    }
}
