using Org.BouncyCastle.Crypto.Agreement.Srp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace VendasWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamentos Departamentos { get; set; }
        //relação vendedor para um Departamento
        public ICollection<Vendas> Vendas { get; set; } = new List<Vendas>();
        //Associação um para muitos vendedor-vendas

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamentos departamentos)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamentos = departamentos;
        }

        public void AddVendas(Vendas vds)
        {
            Vendas.Add(vds);
        }

        public void RemoveVendas(Vendas vds)
        {
            Vendas.Remove(vds);
        }

        public double TotalVendas(DateTime inicio, DateTime final)
        {
            return Vendas.Where(vds => vds.Data >= inicio && vds.Data <= final).Sum(vds => vds.Amount);//soma das vendas
            //filtrar lista de vendas pra obter nova lista contendo vendas no intervalo de datas
        }
    }
}
