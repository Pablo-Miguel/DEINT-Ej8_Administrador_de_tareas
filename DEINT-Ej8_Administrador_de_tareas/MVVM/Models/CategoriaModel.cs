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
        public string Nombre { get; set; }
        public List<TareaModel> Tareas { get; set; } = new List<TareaModel>();
        public int Num_tareas { get { return Tareas.Count; } }
    }
}
