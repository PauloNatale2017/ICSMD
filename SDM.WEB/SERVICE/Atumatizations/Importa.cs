using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using Domain.Entities.EntitiModel;

namespace SERVICE.Atumatizations
{
    public class Importa
    {
        public List<Cadastro> ImportExcel(string Path)
        {
            Path = @"C:\Users\paulo.natale\Desktop\Ronaldo\Casos.xlsx";
            OleDbConnection conexao = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + ";Extended Properties='Excel 12.0 Xml;HDR=YES';");
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from [Plan1$]", conexao);
            DataSet ds = new DataSet();

            List<Cadastro> list = new List<Cadastro>();

            try
            {
                conexao.Open();
                adapter.Fill(ds);
                foreach (DataRow linha in ds.Tables[0].Rows)
                {
                    var entity = new Cadastro
                    {
                        DataCreate = DateTime.Now.ToString(),
                        DataCadastro = "2019-06-06 16:53:19.450",//null.//DateTime.Now,//DateTime.Parse(linha["Data"].ToString()),
                        NumeroCadastrado = linha["numero"].ToString(),
                        DatadeNascimento = "2019-06-06 16:53:19.450", //null,//DateTime.Now,//DateTime.Parse(linha["Data de Nascimento"].ToString()),
                        Escolaridade = linha["Escolaridade"].ToString(),
                        Cidade = linha["Cidade"].ToString(),
                        Bairro = linha["Bairro"].ToString(),
                        EstadoCivil = linha["Estado Civil"].ToString(),
                        Filhos = linha["Filhos"].ToString(),
                        TipodeViolência = linha["Tipo de Violência"].ToString(),
                        UsoDeAlcool_Drogas_Agressor = linha["Uso de álcool e drogas (agressor)"].ToString(),
                        UsoDeAlcool_Drogas_Vitima = "",
                        VínculoComAgressor = linha["Vínculo com agressor"].ToString(),
                        EncaminhadaPor = linha["Encaminhada por:"].ToString(),
                        BO = linha["BO"].ToString(),
                        MP = linha["MP"].ToString(),
                        Situacao = linha["Situação"].ToString(),
                        Motivododesligamento = linha["Motivo do desligamento"].ToString(),
                        Desligamento = linha["Desligamento"].ToString(),
                        Observacoes = linha["Observações"].ToString()
                    };
                    list.Add(entity);
                }
            }
            catch (Exception ex)
            {
              
            }
            finally
            {
               conexao.Close();            
            }

            return list;
        }

        public void ImportText()
        {
        }

        public void ImportJson()
        {
        }

        public void ImportXml()
        {
        }

    }
}
