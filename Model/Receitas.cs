using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeFinanças.Model
{
    internal class Receitas
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string Observacao { get; set; }
        public int CategoriaId { get; set; }
        public DateTime Data { get; set; }



    }
}
