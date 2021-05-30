using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ModelPai
    {
        public List<Produto> Carrinho { get; set; }
        public IList<CompraUsuario> Total { get; set; }
    }
}
