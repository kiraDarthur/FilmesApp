using Org.BouncyCastle.Utilities.IO.Pem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmesApp
{
    internal class Filme
    {
        [DisplayName("Número Filme")]
        public int NumeroFilme {get; set; }
        [DisplayName("Número Filme")]
        public int Nome {get; set; }
        public string Nome {get; set; }
        [DisplayName("Nome  Realizador")]
        public int NomeRealizador {get; set; }
        [DisplayName("Duração")]
        public int Duracao {get; set; }
        [DisplayName("Ano Realizador")]
        public Categotia Tipo { get; set; }
        [DisplayName("Númer Filme")]
        public string Resumo { get; set; }

        public byte[] Foto { get; set; }

        public Filme(int numeroFilme, int nome, string nomeRealizador, int duracao, int ano, Categotia tipo, string resumo, byte[] foto)
        {
            NumeroFilme = numeroFilme;
            Nome = nome;
            NomeRealizador = nomeRealizador;
            Duracao = duracao;
            Ano = ano;
            Tipo = tipo;
            Resumo = resumo;
            Foto = foto;
        }
        public Filme()
        {

        }

      
    
    
    }   


}
