using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DEINT_Ej8_Administrador_de_tareas.MVVM.ViewModels
{
    public class AnyadirViewModel
    {
        public TareasViewModel TareasViewModel { get; set; }
        public ICommand AnyadirTarea { get; set; }
        public ICommand AnyadirCategoria { get; set; }
        public int SelectedCategory { get; set; } = -1;
        public AnyadirViewModel(TareasViewModel tareasViewModel)
        {
            TareasViewModel = tareasViewModel;
            AnyadirTarea = new Command(async (s) =>
            {
                string tareaName = s as string;
                if (SelectedCategory == -1)
                {
                    await App.Current.MainPage.DisplayAlert("Categoria", "Tienes que seleccionar una Categoría para añadir una tarea", "OK");
                }
                else if (tareaName.Equals("")) {
                    await App.Current.MainPage.DisplayAlert("Tarea", "La tarea no puede estar vacía", "OK");
                }
                else
                {
                    TareasViewModel.Tareas.Add(new Models.TareaModel()
                    {
                        Nombre = tareaName,
                        Categ_id = SelectedCategory
                    });
                }
                
            });
            AnyadirCategoria = new Command(async (s) => {
                string result = await App.Current.MainPage.DisplayPromptAsync("Categoria", "Introduzca el nombre de la categoría");
                int id = TareasViewModel.Categorias.Max(x => x.Id) + 1;
                TareasViewModel.Categorias.Add(new Models.CategoriaModel() {
                    Id = id,
                    Nombre = result
                });
            });
        }
    }
}
