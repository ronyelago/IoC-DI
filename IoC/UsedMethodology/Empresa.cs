namespace IoC.UsedMethodology
{
    public class Empresa
    {
        private int _cod;

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

        private Endereco _endereco;

        public Endereco Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }
    }
}
