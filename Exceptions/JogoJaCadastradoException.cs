using System;
using System.Runtime.Serialization;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace ApiListaJogo.Services
{
    public class JogoJaCadastradoException : Exception
    {
        public JogoJaCadastradoException()
            : base("Este já jogo está cadastrado")
        { }
    }
}