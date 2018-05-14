namespace IoC.ConstructorMethodology
{
    public class Endereco : IObjetoEndereco
    {
        private string _logradouro;
        private int _numero;
        public string Logradouro
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
    }
}