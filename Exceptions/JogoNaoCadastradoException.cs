using System;
using System.Runtime.Serialization;

namespace ApiListaJogo.Services
{
    public class JogoNaoCadastradoException : Exception
    {
        public JogoNaoCadastradoException()
            : base("Este jogo não está cadastrado")
        { }
    }
}