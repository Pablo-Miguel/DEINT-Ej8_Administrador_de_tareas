using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej8_Administrador_de_tareas.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class TareaModel
    {
        public string Nombre { get; set; }
        public int Categ_id { get; set; }
        public bool Completado { get; set; } = false;
    }
}
