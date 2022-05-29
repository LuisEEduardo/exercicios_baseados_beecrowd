namespace Bee_1001.Exceptions
{
    public class OpcaoErradaException : Exception
    {
        public OpcaoErradaException() { }

        public OpcaoErradaException(string mensagem)
            : base(mensagem) { }

        public OpcaoErradaException(string mensagem, Exception inner)
            : base(mensagem, inner) { }
    }
}