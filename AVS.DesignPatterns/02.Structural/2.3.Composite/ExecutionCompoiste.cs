namespace AVS.DesignPatterns.Structural.Composite
{
    public class ExecutionCompoiste
    {
        public static void Run()
        {
            var validacaoCadastro = new Mensagem("O cadastro não foi realizado!");
            var usuarioFormErro = new Mensagem("O usuário informou um nome inválido");

            var tamanhoNomeForm = new InputFormMessage("O nome precisa possuir mais de 2 caracteres");
            var nomeVazioForm = new InputFormMessage("Campo obrigatório.");

            usuarioFormErro.AdicionarFilha(tamanhoNomeForm);
            usuarioFormErro.AdicionarFilha(nomeVazioForm);
            validacaoCadastro.AdicionarFilha(usuarioFormErro);

            var domainUsuarioErro = new Mensagem("Problemas ao processar o cadastro de usuario");
            var cpfUsuarioDomain = new DomainMessage("O CPF informado está em uso!");
            var emailUsuarioDomain = new DomainMessage("O Email informado está em uso!");

            domainUsuarioErro.AdicionarFilha(cpfUsuarioDomain);
            domainUsuarioErro.AdicionarFilha(emailUsuarioDomain);
            validacaoCadastro.AdicionarFilha(domainUsuarioErro);

            var msgNivel_1 = new Mensagem("Nível 1");
            var msgNivel_2 = new Mensagem("Nível 2");
            var msgNivel_3 = new Mensagem("Nível 3");
            var msgNivel_4 = new Mensagem("Nível 4");
            var msgNivel_5 = new Mensagem("Nível 5");

            msgNivel_4.AdicionarFilha(msgNivel_5);
            msgNivel_3.AdicionarFilha(msgNivel_4);
            msgNivel_2.AdicionarFilha(msgNivel_3);
            msgNivel_1.AdicionarFilha(msgNivel_2);

            validacaoCadastro.AdicionarFilha(msgNivel_1);
            validacaoCadastro.ExibirMensagens(2);
        }
    }
}
