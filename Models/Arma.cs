using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RpgApi.Models;

namespace A09.Models
{
    public class Arma
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public int Dano { get; set; }

        public Personagem? Personagem { get; set; } = null!; //null -->ignora os warinings
        public int? PersonagemId { get; set; }
    }
}