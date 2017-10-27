using System;

namespace cadastrovendaspoo.classes{
    public class Produto{
        private int id;
        private string nomeproduto;
        private double preco;

    public Produto()
    {

    }

    public Produto(int id, string nomeproduto, double preco)
    {
        this.id = id;
        this.nomeproduto = nomeproduto;
        this.preco = preco;
            }

        public int Id { get{return id;} set{id=value;} }
        public string Nomeproduto  { get{return nomeproduto;} set{nomeproduto=value;} }
        public double Preco { get{return preco;} set{preco=value;} }
    }
}