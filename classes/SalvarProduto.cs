using System;
using System.IO;

namespace cadastrovendaspoo.classes
{
    public class SalvarProduto
    {
        public string Salvar(Produto produto)
        {
            string msg = "";

            StreamWriter arquivo = null;
            try
            {
                    arquivo = new StreamWriter("cadProdutos.csv", true);
                    arquivo.WriteLine(

                            produto.Id + ";" +
                            produto.Nomeproduto + ";" +
                            produto.Preco
                            );
                    msg = "Produto Salvo com sucesso!";

             }


            catch (Exception ex)
            {
                msg = "Erro ao tentar gravar o produto!" + ex.Message;
            }
            finally
            {
                arquivo.Close();
            }

            return msg;

        }


}}