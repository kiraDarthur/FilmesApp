using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace FilmesApp
{
    internal class Categoria
    {
        this.idCategoria = idCategoria;
        this.descricao = descricao;
    }
    public override bool Equals(object obj)
        {
            
            var categoria = obj as Categoria;

            return categoria != null && idCategoria == categoria.idCategoria; 

        }

    public override int GetHashCode()
        {
            return -964325053 + idCategoria.GetHashCode();
        }
    public override string ToString()
        {
            return base.ToString();
        }



    }
