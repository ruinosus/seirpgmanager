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
        public Planilha AtualizarPlanilha(Planilha planilha)
        {
            AtualizarAtributosFisicos(planilha.AtributosFisicos);
            AtualizarAtributosMentais(planilha.AtributosMentais);
            AtualizarAtributosSobrenaturais(planilha.AtributosSobrenaturais);

            AtualizarHabilitadorAtletico(planilha.Atletico);
            AtualizarHabilitadorCombateProximo(planilha.CombateProximo);
            AtualizarHabilitadorCombateAfastado(planilha.CombateAfastado);
            
            AtualizarHabilitadorInstrucao(planilha.Instrucao);
            AtualizarHabilitadorSocial(planilha.Social);
            AtualizarHabilitadorPerspicacia(planilha.Perspicacia);

            AtualizarArmas(planilha.Armas);
            AtualizarBarraEnergia(planilha.BarraEnergia);
            AtualizarCapacidades(planilha.Capacidade);
            AtualizarConceito(planilha.Conceito);
            AtualizarEquipamentos(planilha.Equipamentos);
            AtualizarSaude(planilha.EstadosSaude);
            AtualizarPrecedentes(planilha.Precedentes);
            AtualizarTalentos(planilha.Talentos);
            
            return planilha;
        }

        public void AtualizarConceito(ConceitoPlanilha conceito)
        {
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Conceito/Nome", conceito.Nome);
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Conceito/Campanha", conceito.Campanha);
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Conceito/Personalidade", conceito.Personalidade);
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Conceito/Raca", conceito.Raca);
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Conceito/Ocupacao", conceito.Ocupacao);
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Conceito/Estilo", conceito.Estilo);
        }

        public void AtualizarAtributosFisicos(AtributosFisicosPlanilha atributosFisicos)
        {
            FuncoesSeiRPG.AlterarAtributoXML("Planilha/Atributo/Fisico", "Prioridade", atributosFisicos.Prioridade.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Atributo/Fisico/Forca", atributosFisicos.Forca.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Atributo/Fisico/Destreza", atributosFisicos.Destreza.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Atributo/Fisico/Resistencia", atributosFisicos.Resistencia.Valor.ToString());
        }

        public void AtualizarAtributosMentais(AtributosMentaisPlanilha atributosMentais)
        {
            FuncoesSeiRPG.AlterarAtributoXML("Planilha/Atributo/Mental", "Prioridade", atributosMentais.Prioridade.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Atributo/Mental/Intelecto", atributosMentais.Intelecto.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Atributo/Mental/Influencia", atributosMentais.Influencia.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Atributo/Mental/Percepcao", atributosMentais.Percepcao.Valor.ToString());
        }

        public void AtualizarAtributosSobrenaturais(AtributosSobrenaturaisPlanilha atributosSobrenaturais)
        {
            FuncoesSeiRPG.AlterarAtributoXML("Planilha/Atributo/Sobrenatural", "Prioridade", atributosSobrenaturais.Prioridade.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Atributo/Sobrenatural/Determinacao", atributosSobrenaturais.Determinacao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Atributo/Sobrenatural/Intuicao", atributosSobrenaturais.Intuicao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Atributo/Sobrenatural/Imunidade", atributosSobrenaturais.Imunidade.Valor.ToString());
        }

        public void AtualizarHabilitadorAtletico(HabilitadorAtletico atletico)
        {
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/Atletico", atletico.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/Atletico/Escalada", atletico.Escalada.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/Atletico/Salto", atletico.Salto.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/Atletico/Natacao", atletico.Natacao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/Atletico/Esporte", atletico.Esporte.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/Atletico/Corrida", atletico.Corrida.Valor.ToString());
        }

        public void AtualizarHabilitadorCombateProximo(HabilitadorCombateProximo combateProximo)
        {
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateProximo", combateProximo.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateProximo/CombateDesarmado", combateProximo.CombateDesarmado.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateProximo/Evasao", combateProximo.Evasao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateProximo/ArmaBrancaCurta", combateProximo.ArmBrancaCurta.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateProximo/ArmaBrancaMedia", combateProximo.ArmBrancaMedia.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateProximo/ArmaBrancaLonga", combateProximo.ArmBrancaLonga.Valor.ToString());
        }

        public void AtualizarHabilitadorCombateAfastado(HabilitadorCombateAfastado combateAfastado)
        {
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateAfastado", combateAfastado.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateAfastado/Armamento", combateAfastado.Armamento.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateAfastado/ArmaImpulso", combateAfastado.ArmImpulso.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateAfastado/ArmaFogoLeve", combateAfastado.ArmFogoLeve.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateAfastado/ArmaFogoMedia", combateAfastado.ArmFogoMedia.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateAfastado/ArmaFogoPesada", combateAfastado.ArmFogoPesada.Valor.ToString());
        }

        public void AtualizarHabilitadorInstrucao(HabilitadorInstrucao instrucao)
        {
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Instrucao", instrucao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Instrucao/Medicina", instrucao.Medicina.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Instrucao/Computacao", instrucao.Computacao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Instrucao/Conhecimento", instrucao.Conhecimento.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Instrucao/Linguistica", instrucao.Linguistica.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Instrucao/Ocultismo", instrucao.Ocultismo.Valor.ToString());
        }

        public void AtualizarHabilitadorPerspicacia(HabilitadorPerspicacia perspicacia)
        {
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Perspicacia", perspicacia.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Perspicacia/Investigacao", perspicacia.Investigacao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Perspicacia/Furtividade", perspicacia.Furtividade.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Perspicacia/Prestidigitacao", perspicacia.Prestidigitacao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Perspicacia/Reparo", perspicacia.Reparo.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Perspicacia/Subterfugio", perspicacia.Subterfugio.Valor.ToString());
        }

        public void AtualizarHabilitadorSocial(HabilitadorSocial social)
        {
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Social", social.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Social/Empatia", social.Empatia.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Social/Labia", social.Labia.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Social/Malandragem", social.Malandragem.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Social/TratoComAnimais", social.TratoAnimais.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Social/Performance", social.Performance.Valor.ToString());
        }

        public void AtualizarHabilitadorSobrenatuaral1(HabilitadorSobrenatural sobrenatural)
        {
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural1", sobrenatural.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural1/Especializacao1", sobrenatural.Slot1.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural1/Especializacao2", sobrenatural.Slot2.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural1/Especializacao3", sobrenatural.Slot3.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural1/Especializacao4", sobrenatural.Slot4.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural1/Especializacao5", sobrenatural.Slot5.Valor.ToString());
        }

        public void AtualizarHabilitadorSobrenatuaral2(HabilitadorSobrenatural sobrenatural)
        {
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural2", sobrenatural.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural2/Especializacao1", sobrenatural.Slot1.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural2/Especializacao2", sobrenatural.Slot2.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural2/Especializacao3", sobrenatural.Slot3.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural2/Especializacao4", sobrenatural.Slot4.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural2/Especializacao5", sobrenatural.Slot5.Valor.ToString());
        }

        public void AtualizarHabilitadorSobrenatuaral3(HabilitadorSobrenatural sobrenatural)
        {
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural3", sobrenatural.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural3/Especializacao1", sobrenatural.Slot1.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural3/Especializacao2", sobrenatural.Slot2.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural3/Especializacao3", sobrenatural.Slot3.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural3/Especializacao4", sobrenatural.Slot4.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural3/Especializacao5", sobrenatural.Slot5.Valor.ToString());
        }

        public void AtualizarSaude(SaudePlanilha[] saude)
        {
            for (int i = 1; i <= 5; i++)
            {
                FuncoesSeiRPG.AlterarConteudoXML("Planilha/Saude/Slot" + i + "/Estado", saude[i].Estado.ToString());
                FuncoesSeiRPG.AlterarConteudoXML("Planilha/Saude/Slot" + i + "/Penalidade", saude[i].Penalidade.ToString());
                FuncoesSeiRPG.AlterarConteudoXML("Planilha/Saude/Slot" + i + "/Nivel", saude[i].Nivel.ToString());
            }
        }

        public void AtualizarPrecedentes(PrecedentePlanilha[] precedente)
        {
            for (int i = 1; i <= 10; i++)
            {
                FuncoesSeiRPG.AlterarConteudoXML("Planilha/Precedente/Slot" + i, precedente[i].Descricao.ToString());
                FuncoesSeiRPG.AlterarAtributoXML("Planilha/Precedente/Slot" + i, "Custo", precedente[i].Valor.ToString());
            }
        }

        public void AtualizarTalentos(TalentoPlanilha[] talento)
        {
            for (int i = 1; i <= 10; i++)
            {
                FuncoesSeiRPG.AlterarConteudoXML("Planilha/Talento/Slot" + i, talento[i].Descricao.ToString());
                FuncoesSeiRPG.AlterarAtributoXML("Planilha/Talento/Slot" + i, "Ajuste", talento[i].Valor.ToString());
            }            
        }

        public void AtualizarArmas(ArmaPlanilha[] arma)
        {
            for (int i = 1; i <= 5; i++)
            {
                FuncoesSeiRPG.AlterarConteudoXML("Planilha/Arma/Slot" + i + "/Tipo", arma[i].Tipo.ToString());
                FuncoesSeiRPG.AlterarConteudoXML("Planilha/Arma/Slot" + i + "/Tamanho", arma[i].Tamanho.ToString());
                FuncoesSeiRPG.AlterarConteudoXML("Planilha/Arma/Slot" + i + "/Pente", arma[i].Pente.ToString());
                FuncoesSeiRPG.AlterarConteudoXML("Planilha/Arma/Slot" + i + "/Alcance", arma[i].Alcance.ToString());
                FuncoesSeiRPG.AlterarConteudoXML("Planilha/Arma/Slot" + i + "/Ajuste", arma[i].Ajuste.ToString());
            }
        }

        public void AtualizarEquipamentos(EquipamentoPlanilha[] equipamento)
        {
            for (int i = 1; i <= 5; i++)
            {
                FuncoesSeiRPG.AlterarConteudoXML("Planilha/Equipamento/Slot" + i + "/Item", equipamento[i].Item.ToString());
                FuncoesSeiRPG.AlterarConteudoXML("Planilha/Equipamento/Slot" + i + "/Tamanho", equipamento[i].Tamanho.ToString());
                FuncoesSeiRPG.AlterarConteudoXML("Planilha/Equipamento/Slot" + i + "/Quantidade", equipamento[i].Quantidade.ToString());
            }
        }

        public void AtualizarBarraEnergia(BarraEnergiaPlanilha energia)
        {
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/BarraEnergia/Vitalidade", energia.Vitalidade.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/BarraEnergia/EnergiaVital", energia.EnergiaVital.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/BarraEnergia/Corrupcao", energia.Corrupcao.ToString());
        }

        public void AtualizarCapacidades(CapacidadePlanilha capacidade)
        {
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Capacidade/DefesaFisica", capacidade.DefesaFisica.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Capacidade/DefesaMental", capacidade.DefesaMental.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Capacidade/Deslocamento", capacidade.Deslocamento.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Capacidade/Carga", capacidade.Carga.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Capacidade/ModificadorIniciativa", capacidade.ModificadorIniciativa.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Capacidade/IndiceProtecao", capacidade.IndiceProtecao.ToString());
        }

        public AtributosFisicosPlanilha ObterAtributosFisicos(Planilha planilha)
        {
            AtributosFisicosPlanilha atributo = new AtributosFisicosPlanilha();

            planilha.AtributosFisicos.Prioridade = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo("",""));
            planilha.AtributosFisicos.Forca.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(""));
            planilha.AtributosFisicos.Destreza.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(""));
            planilha.AtributosFisicos.Resistencia.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(""));

            return atributo;
        }

        public AtributosMentaisPlanilha ObterAtributosMentais(Planilha planilha)
        {
            AtributosMentaisPlanilha atributo = new AtributosMentaisPlanilha();

            planilha.AtributosMentais.Prioridade = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo("", ""));
            planilha.AtributosMentais.Intelecto.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(""));
            planilha.AtributosMentais.Influencia.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(""));
            planilha.AtributosMentais.Percepcao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(""));

            return atributo;
        }

        public AtributosSobrenaturaisPlanilha ObterAtributosFisicos(Planilha planilha)
        {
            AtributosSobrenaturaisPlanilha atributo = new AtributosSobrenaturaisPlanilha();

            planilha.AtributosSobrenaturais.Prioridade = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo("", ""));
            planilha.AtributosSobrenaturais.Determinacao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(""));
            planilha.AtributosSobrenaturais.Intuicao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(""));
            planilha.AtributosSobrenaturais.Imunidade.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(""));

            return atributo;
        }

    }
}
