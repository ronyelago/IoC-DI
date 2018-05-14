namespace IoC.ConstructorMethodology
{
    public class Empresa
    {
        private int _cod;

        public Empresa(IObjetoEndereco endereco)
        {
            _endereco = endereco;
        }

        public int Cod
        {
            get { return _cod; }
            set { _cod = value; }
        }
        private string _razaoSocial;

        public string RazaoSocial
        {
            get { return _razaoSocial; }
            set { _razaoSocial = value; }
        }

        private IObjetoEndereco _endereco;

        public IObjetoEndereco Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }
    }
}
