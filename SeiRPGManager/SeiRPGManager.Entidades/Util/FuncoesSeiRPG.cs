
namespace SeiRPGManager.Entidades.Util
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml;

    /// <summary>
    /// Classe que fornece vários métodos que serão comuns para toda a aplicação.
    /// </summary>
    public static class FuncoesSeiRPG
    {
        #region Manipulação de XML
        
        private static string caminhoXML = @"../../../SeiRPGManager.Entidades/Util/Planilha.xml";

        public static XmlDocument CarregarPlanilha()
        {
            XmlDocument planilha = new XmlDocument();
            planilha.Load(caminhoXML);
            return planilha;
        }

        public static void AlterarConteudoXML(string campo, string valor)
        {
            XmlDocument planilha = CarregarPlanilha();

            //XmlNode no = planilha.SelectSingleNode("Planilha/Atributo/Fisico/Forca");
            //no.InnerText = "8";

            XmlNode no = planilha.SelectSingleNode(campo);
            no.InnerText = valor;
            planilha.Save(caminhoXML);
        }

        public static void AlterarAtributoXML(string campo, string atributo, string valor)
        {
            XmlDocument planilha = CarregarPlanilha();

            //XmlNode no = planilha.SelectSingleNode("Planilha/Atributo/Fisico");
            //no.Attributes["Prioridade"].Value = "1";

            XmlNode no = planilha.SelectSingleNode(campo);
            no.Attributes[atributo].Value = valor;
            planilha.Save(caminhoXML);
        }

        public static string RetornarValorConteudo(string campo, string valor)
        {
            XmlDocument planilha = CarregarPlanilha();
            return planilha.SelectSingleNode(campo).InnerText;
        }

        public static string RetornarAtributoConteudo(string campo, string atributo, string valor)
        {
            XmlDocument planilha = CarregarPlanilha();
            XmlNode no = planilha.SelectSingleNode(campo);
            return no.Attributes[atributo].Value;
        } 
        #endregion
    }
}
