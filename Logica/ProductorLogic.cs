using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entidades;

namespace Logica
{
    public class ProductorLogic
    {
        public ProductorAdapter ProductorAdapter { get; set; }

        public ProductorLogic()
        {
            ProductorAdapter = new ProductorAdapter();
        }

        public void AltaProductor(Productor p)
        {
            ProductorAdapter.AltaProductor(p);
        }

        public List<Productor> GetAll()
        {
            return ProductorAdapter.GetAll();
        }

        public Productor GetOne(string cuit)
        {
           return ProductorAdapter.GetOne(cuit);
        }

        public void ModificarProductor(Productor productor, string cuit)
        {
            ProductorAdapter.ModificarProductor(productor, cuit);
        }
    }
}
