using System.Collections.Generic;

namespace Padaria.Domain.Model
{
    public class Caixa : IEntity
    {
        public int Id { get; set; }
        public List<Produto> Produtos { get; set; }

        public void SomarValores()
        {
            // code here
        }
        public void FinalizarCompra()
        {
            // code here
        }
    }
}
