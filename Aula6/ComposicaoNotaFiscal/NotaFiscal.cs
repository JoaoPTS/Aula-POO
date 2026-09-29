using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
	public class NotaFiscal
	{
		public int NumeroNF { get; set; }
		public string? Data { get; set; }
		public List<ItemNotaFiscal> VetItem { get; set; }

		public NotaFiscal(int numero, string? data, List<ItemNotaFiscal> vetItem)
		{
			NumeroNF = numero;
			Data = data;
			VetItem = vetItem;
		}

		public void Mostrar()
		{
			Console.WriteLine("Numero da nota fiscal: " + NumeroNF);
			Console.WriteLine("Data: " + Data);
			foreach (var item in VetItem)
			{
				item.Mostrar();	
			}
		}
		~NotaFiscal()
		{
			Console.WriteLine("Destrutor da nota fiscal");
		}
	}
}