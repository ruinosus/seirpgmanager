using SeiRPGManager.Entidades.Modelo.ClassesPlanilha;
using SeiRPGManager.Entidades.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeiRPGManager.Negocio
{
    public class PlanilhaNegocios
    {
        public void AlterarPlanilha(Planilha planilha)
        {
            AlterarAtributosFisicos(planilha.AtributosFisicos);
            AlterarAtributosMentais(planilha.AtributosMentais);
            AlterarAtributosSobrenaturais(planilha.AtributosSobrenaturais);
        }

        public void AlterarConceito(ConceitoPlanilha conceito)
        {
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Conceito/Nome", conceito.Nome);
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Conceito/Campanha", conceito.Campanha);
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Conceito/Personalidade", conceito.Personalidade);
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Conceito/Raca", conceito.Raca);
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Conceito/Ocupacao", conceito.Ocupacao);
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Conceito/Estilo", conceito.Estilo);
        }

        public void AlterarAtributosFisicos(AtributosFisicosPlanilha atributosFisicos)
        {
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Atributo/Fisico/Forca", atributosFisicos.Forca.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Atributo/Fisico/Destreza", atributosFisicos.Destreza.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Atributo/Fisico/Resistencia", atributosFisicos.Resistencia.Valor.ToString());            
        }

        public void AlterarAtributosMentais(AtributosMentaisPlanilha atributosMentais)
        {
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Atributo/Fisico/Intelecto", atributosMentais.Intelecto.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Atributo/Fisico/Influencia", atributosMentais.Influencia.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Atributo/Fisico/Percepcao", atributosMentais.Percepcao.Valor.ToString());
        }

        public void AlterarAtributosSobrenaturais(AtributosSobrenaturaisPlanilha atributosSobrenaturais)
        {
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Atributo/Fisico/Determinacao", atributosSobrenaturais.Determinacao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Atributo/Fisico/Intuicao", atributosSobrenaturais.Intuicao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Atributo/Fisico/Imunidade", atributosSobrenaturais.Imunidade.Valor.ToString());
        }

        public void AlterarHabilitadorAtletico(Planilha planilha)
        {

        }

        public void AlterarHabilitadorCombateProximo(Planilha planilha)
        {

        }

        public void AlterarHabilitadorCombateAfastado(Planilha planilha)
        {

        }

        public void AlterarHabilitadorInstrucao(Planilha planilha)
        {

        }

        public void AlterarHabilitadorPerspicacia(Planilha planilha)
        {

        }

        public void AlterarHabilitadorSocial(Planilha planilha)
        {

        }

        public void AlterarHabilitadorSobrenatuaral1(Planilha planilha)
        {

        }

        public void AlterarHabilitadorSobrenatuaral2(Planilha planilha)
        {

        }

        public void AlterarHabilitadorSobrenatuaral3(Planilha planilha)
        {

        }
    }
}
