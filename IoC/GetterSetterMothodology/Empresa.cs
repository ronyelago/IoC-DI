namespace IoC.GetterSetterMothodology
{
    class Empresa
    {
        private IObjetoEndereco _endereco;

        public IObjetoEndereco Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }
    }
}
