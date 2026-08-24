using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassProduto
{
    public class Produto
    {
        //Declaração de atribtos
        public string Nome;
        public double Preco;
        public double Quantidade;
        //Declaração de métodos
        public void ValorTotalEstoque()
        {
            double valorTotal = Preco * Quantidade;
            Console.WriteLine($"Valor total em estoque: {valorTotal}");
        }

        public void AdicionarProdutos(double quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(double quantidade)
        {
            Quantidade -= quantidade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Produto: {Nome}, Preço: {Preco}, Quantidade: {Quantidade}");
        }        
    }
}