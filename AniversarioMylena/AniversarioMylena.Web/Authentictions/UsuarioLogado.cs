using System;

namespace AniversarioMylena.Web.Authentictions
{
    public class UsuarioLogado
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string[] Permissoes { get; set; }

        public bool IsValid
        {
            get { return DateTime.Now.Day == 8 && DateTime.Now.Month == 1; }
        }

        public UsuarioLogado(string email, string[] permissoes, string nome)
        {
            this.Email = email;
            this.Permissoes = permissoes;
            this.Nome = nome;
        }
    }
}