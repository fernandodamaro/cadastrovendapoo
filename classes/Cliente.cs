using System;

namespace cadastrovendaspoo.classes{
    /// <summary>
    /// A classe cliente possui informações sobre o cliente
    /// </summary>
    public class Cliente{

private string nome;
private string email;
private string cpf;
private DateTime datacadastro;

public Cliente ()
{}
/// <summary>
/// Constroi o objeto cliente e vc precisa passar os dados como parametro
/// </summary>
/// <param name="nome">nome em texto</param>
/// <param name="email">email em texto</param>
/// <param name="cpf">cpf em texto</param>
/// <param name="datacadastro">data de cadastro como DateTime</param>
public Cliente(string nome, string email, string cpf, DateTime datacadastro)
    {
    this.nome = nome;
    this.email= email;
    this.cpf= cpf;
    this.datacadastro= datacadastro;

        }

        public string Nome { get{return nome;} set{nome=value;}}
        public string Email { get{return email;} set{email=value;}}
        public string Cpf { get{return cpf;} set{cpf=value;}}
        public DateTime Datacadastro { get{return datacadastro;} set{datacadastro=value;}}

    }
}