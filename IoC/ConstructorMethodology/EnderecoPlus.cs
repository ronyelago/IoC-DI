namespace IoC.ConstructorMethodology
{
    public class EnderecoPlus : IObjetoEndereco
    {
        private string _tipoLogradouro;
        private string _logradouro;
        private int _numero;

        public string TipoLogradouro
        {
            get { return _tipoLogradouro; }
            set { _tipoLogradouro = value; }
        }

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
