
namespace SeiRPGManager.Entidades.Util
{
    using SeiRPGManager.Entidades.Modelo.ClassesBasicas;
using SeiRPGManager.Entidades.Modelo.ClassesPlanilha;
using SeiRPGManager.Entidades.Modelo.Enum;
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
        #region Construtor

        static FuncoesSeiRPG()
        {
            random = new Random();
        }

        #endregion

        #region Manipulação de XML

        //private static string caminhoXML = @"../../../SeiRPGManager.Entidades/Util/Planilha.xml";

        public static XmlDocument CarregarPlanilha(string xmlString)
        {
            XmlDocument planilha = new XmlDocument();
            planilha.LoadXml(xmlString);
            return planilha;
        }

        public static XmlDocument AlterarConteudoXML(XmlDocument planilha, string campo, string valor)
        {
            //XmlNode no = planilha.SelectSingleNode("Planilha/Atributo/Fisico/Forca");
            //no.InnerText = "8";

            XmlNode no = planilha.SelectSingleNode(campo);
            no.InnerText = valor;
            return planilha;
        }

        public static XmlDocument AlterarAtributoXML(XmlDocument planilha, string campo, string atributo, string valor)
        {
            //XmlNode no = planilha.SelectSingleNode("Planilha/Atributo/Fisico");
            //no.Attributes["Prioridade"].Value = "1";

            XmlNode no = planilha.SelectSingleNode(campo);
            no.Attributes[atributo].Value = valor;
            return planilha;
        }

        public static string RetornarValorConteudo(XmlDocument planilha, string campo)
        {            
            return planilha.SelectSingleNode(campo).InnerText;
        }

        public static string RetornarAtributoConteudo(XmlDocument planilha, string campo, string atributo)
        {
            XmlNode no = planilha.SelectSingleNode(campo);
            return no.Attributes[atributo].Value;
        }
        #endregion

        #region Parada de dados

        private static Random random;
        private static StringBuilder jogada;
        private static int sucessos;
        private static int noveFora;

        public static string ParadaDados(int qtdDados, Facilidade facilidade, Ajuste bonus, Ajuste penalidade)
        {
            jogada = new StringBuilder();
            sucessos = 0;            
            noveFora = 0;
            
            int resultadoDado = 0;
            int zeroOuro = 0;

            int dificuldade = ((int)facilidade + (int)bonus) - (int)penalidade;

            if (dificuldade == 0)
            {
                dificuldade = 1;
            }

            if (dificuldade > 0)
            {
                for (int i = 1; i <= qtdDados; i++)
                {
                    resultadoDado = RolarDados(Dado.D10);

                    if (resultadoDado <= dificuldade)
                    {
                        sucessos++;                        
                    }

                    if (resultadoDado == 0)
                    {
                        zeroOuro++;
                    }

                    if (resultadoDado == 9)
                    {
                        noveFora++;
                    }

                    FormatarResultadoDado(resultadoDado, i == qtdDados);
                }

                if (zeroOuro > 0)
                {
                    jogada.AppendLine("");
                    jogada.Append("Dados extra: ");

                    for (int i = 0; i < zeroOuro; i++)
                    {
                        resultadoDado = RolarDados(Dado.D10);

                        if (resultadoDado <= dificuldade)
                        {
                            sucessos++;
                        }

                        if (resultadoDado == 9)
                        {
                            noveFora++;
                        }
                        
                        FormatarResultadoDado(resultadoDado, i == zeroOuro);
                    }
                }

                VerificarResultado();
            }
            else
            {
                jogada.Clear();
                jogada.Append("Falha crítica automática!");
            }

            return jogada.ToString();
        }

        private static int RolarDados(Dado dado)
        {
            return random.Next(0, (int)dado);
        }

        private static void FormatarResultadoDado(int dado, bool ultimo)
        {
            jogada.Append(dado);

            if (ultimo)
            {
                jogada.Append(".");
            }
            else
            {
                jogada.Append(",");
            }
        }

        private static void VerificarResultado()
        {            
            jogada.AppendLine("");


            if (sucessos > noveFora)
            {
                jogada.Append("Sucesso!");
            }

            if (sucessos == noveFora)
            {
                jogada.Append("Fracasso");
            }

            if (noveFora > sucessos)
            {
                jogada.Append("Falha crítica!!!");
            }
        }
        #endregion

        #region Planilha

        public static Planilha MontarPlanilha(Personagem personagem)
        {
            Planilha planilha = new Planilha();
            XmlDocument planilhaXMl = new XmlDocument();
            
            planilhaXMl = CarregarPlanilha(personagem.Planilha.ToString());

            //planilha.Forca = 1;

            return planilha;
        }

        public static string TransformarPlanilha(Personagem personagem)
        {
            Planilha planilha = new Planilha();
            XmlDocument planilhaXMl = new XmlDocument();

            planilhaXMl = CarregarPlanilha(personagem.Planilha.ToString());

            //planilha.Forca = 1;

            return planilha.ToString();
        }

        #endregion
    }
}
