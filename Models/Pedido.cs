using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeadPageBlazor.Models
{
    public class Pedido
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
    }
}