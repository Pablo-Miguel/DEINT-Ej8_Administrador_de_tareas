using DEINT_Ej8_Administrador_de_tareas.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej8_Administrador_de_tareas.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class TareasViewModel
    {
        public ObservableCollection<CategoriaModel> Categorias { get; set; }
        public ObservableCollection<TareaModel> Tareas { get; set; }

        public TareasViewModel()
        {
            Categorias = new ObservableCollection<CategoriaModel>() {
                new CategoriaModel(){
                    Id = 0,
                    Nombre = "Curso .NET MAUI"
                },
                new CategoriaModel(){
                    Id = 1,
                    Nombre = "Tutoriales"
                },
                new CategoriaModel(){
                    Id = 2,
                    Nombre = "Compras"
                }
            };

            Tareas = new ObservableCollection<TareaModel>()
            {
                new TareaModel()
                {
                    Nombre = "Actualizar ficheros",
                    Categ_id = 0
                },
                new TareaModel()
                {
                    Nombre = "Planear siguiente curso",
                    Categ_id = 0
                },
                new TareaModel()
                {
                    Nombre = "ASP .NET en YouTube",
                    Categ_id = 1
                },
                new TareaModel()
                {
                    Nombre = "XAML",
                    Categ_id = 1
                },
                new TareaModel()
                {
                    Nombre = "JavaScript",
                    Categ_id = 2,
                    Completado = true
                },
            };

            updateTasks();
        }

        public void updateTasks()
        {
            foreach (CategoriaModel categoria in Categorias)
            {
                double totalTasks = Tareas.Where(x => x.Categ_id == categoria.Id).ToList().Count();
                int contTasks = Tareas.Where(x => x.Categ_id == categoria.Id && !x.Completado).ToList().Count();
                double complTasks = totalTasks - contTasks;
                categoria.ContTareas = contTasks;
                categoria.Progress = complTasks / totalTasks;
            }
        }
    }
}
