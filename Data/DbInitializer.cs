using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaNotas.Models;
namespace SistemaNotas.Data
{
    public class DbInitializer
    {
        public static void Initialize (SistemaNotasContext context)
        {
            context.Database.EnsureCreated();

            //Buscar si exsite registros en la tabla categoria
            if(context.Categoria.Any())
            {
                return;
            }
            var categorias = new Categoria[]
            {
                new Categoria{Nombre="Ingenieria de Software", Descripccion="Curso de Programacion", Estado=true},
                new Categoria{Nombre="Ingles", Descripccion="Curso de Ingles", Estado=true},
            };

            foreach(Categoria c in categorias)
            {
                context.Categoria.Add(c);
            }
            context.SaveChanges();
        }
    }
}
