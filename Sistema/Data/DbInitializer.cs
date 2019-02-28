using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Data
{
	public class DbInitializer
	{
		public static void Initialize (SistemaContext contex)
		{
			contex.Database.EnsureCreated();

			//Buscar si existen registros en la tabla categoría
			if (contex.Categoria.Any())
			{
				return;
			}
			var categorias = new Categoria[]
			{
				new Categoria{Nombre = "Programación", Descripcion = "Curso de programación", Estado= true},
				new Categoria{Nombre = "Diseño gráfico", Descripcion = "Curso de diseño gráfico", Estado= true}
			};

			foreach(Categoria c in categorias){
				contex.Categoria.Add(c);
			}

			contex.SaveChanges();
		}
			 
	}
}
