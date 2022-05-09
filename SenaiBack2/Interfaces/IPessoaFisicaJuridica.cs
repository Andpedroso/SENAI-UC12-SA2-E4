namespace SenaiBack2.Interfaces
{
    public interface IPessoaFisicaJuridica
    {
        public interface IPessoaJuridica
        {
            bool validarCnpj( string cnpj );
        }
    }
}