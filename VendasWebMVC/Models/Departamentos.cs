using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace VendasWebMVC.Models
{
    public class Departamentos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedor { get; set; } = new List<Vendedor>();
        // implementando a relação Departamento com Vendas
        //Relação lista de vendedor para um departamento

        public Departamentos()
        {

        }

       //Construtor com argumento sem incluir listas
        public Departamentos(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddVendedor(Vendedor vendedor) 
        {
            Vendedor.Add(vendedor);
        }

        public double TotalVendas(DateTime inicio, DateTime final)
        {
            return Vendedor.Sum(vendedor => vendedor.TotalVendas(inicio,final));//para cada vendedo, aplicar total de venda no periodo inicio e final e soma.
            //filtrar lista de vendas(de cada vendedor) pra obter nova lista contendo vendas no intervalo de datas
        }
    }
}
