using DEINT_Ej8_Administrador_de_tareas.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej8_Administrador_de_tareas.MVVM.ViewModels
{
    public class TareasViewModel
    {
        public ObservableCollection<CategoriaModel> Categorias { get; set; }

        public TareasViewModel()
        {
            Categorias = new ObservableCollection<CategoriaModel>() {
                new CategoriaModel(){
                    Nombre = "Curso .NET MAUI",
                    Tareas = new List<TareaModel>()
                    {
                        new TareaModel()
                        {
                            Nombre = "Actualizar ficheros",
                            Terminada = false
                        },
                        new TareaModel()
                        {
                            Nombre = "Planear siguiente curso",
                            Terminada = true
                        }
                    }
                },
                new CategoriaModel(){
                    Nombre = "Tutoriales",
                    Tareas = new List<TareaModel>()
                    {
                        new TareaModel()
                        {
                            Nombre = "ASP.NET en YouTube",
                            Terminada = false
                        },
                        new TareaModel()
                        {
                            Nombre = "XAML",
                            Terminada = true
                        }
                    }
                },
                new CategoriaModel(){
                    Nombre = "Compras",
                    Tareas = new List<TareaModel>()
                    {
                        new TareaModel()
                        {
                            Nombre = "JavaScript",
                            Terminada = false
                        },
                        new TareaModel()
                        {
                            Nombre = "Java",
                            Terminada = true
                        }
                    }
                },
            };
        }
    }
}
