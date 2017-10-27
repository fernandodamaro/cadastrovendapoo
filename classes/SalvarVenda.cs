using System;
using System.IO;

namespace cadastrovendaspoo.classes
{
    public class SalvarVenda
    {
        public string Salvar(Venda venda)
        {
            string msg = "";

            StreamWriter arquivo = null;
            try
            {
                    arquivo = new StreamWriter("cadVendas.csv", true);
                    arquivo.WriteLine(

                            venda.Cpf + ";" +
                            venda.Id + ";" +
                            venda.Datavenda
                            );
                    msg = "Venda salva com sucesso!";

             }


            catch (Exception ex)
            {
                msg = "Erro ao tentar gravar a venda!" + ex.Message;
            }
            finally
            {
                arquivo.Close();
            }

            return msg;

        }


}}