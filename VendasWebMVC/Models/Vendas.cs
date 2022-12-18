using System;
using System.Data;
using VendasWebMVC.Models.Enums;

namespace VendasWebMVC.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Amount { get; set; }
        public VendasStatus Status { get; set; }
        public Vendedor Vendedor { get; set; }
        //Associação muitos para um vendas-vendedor

        public Vendas()
        {

        }

        public Vendas(int id, DateTime data, double amount, VendasStatus status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Amount = amount;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
