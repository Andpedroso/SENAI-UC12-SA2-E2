using Cadastro_Pessoa_FS1.Interface;

namespace Cadastro_Pessoa_FS1.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string ?cnpj { get; set; }

        public string ?razaoSocial { get; set; }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool validarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}