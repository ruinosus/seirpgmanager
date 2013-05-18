using SeiRPGManager.Entidades.Modelo.ClassesPlanilha;
using SeiRPGManager.Entidades.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SeiRPGManager.Negocio
{
    public class PlanilhaNegocios
    {
        public string AtualizarPlanilha(XmlDocument planilhaXml, Planilha planilha)
        {
            AtualizarAtributosFisicos(planilhaXml, planilha.AtributosFisicos);
            AtualizarAtributosMentais(planilhaXml, planilha.AtributosMentais);
            AtualizarAtributosSobrenaturais(planilhaXml, planilha.AtributosSobrenaturais);

            AtualizarHabilitadorAtletico(planilhaXml, planilha.Atletico);
            AtualizarHabilitadorCombateProximo(planilhaXml, planilha.CombateProximo);
            AtualizarHabilitadorCombateAfastado(planilhaXml, planilha.CombateAfastado);

            AtualizarHabilitadorInstrucao(planilhaXml, planilha.Instrucao);
            AtualizarHabilitadorSocial(planilhaXml, planilha.Social);
            AtualizarHabilitadorPerspicacia(planilhaXml, planilha.Perspicacia);

            AtualizarHabilitadorSobrenatuaral(planilhaXml, planilha.HabilitadorSobrenatural1, 1);
            AtualizarHabilitadorSobrenatuaral(planilhaXml, planilha.HabilitadorSobrenatural2, 2);
            AtualizarHabilitadorSobrenatuaral(planilhaXml, planilha.HabilitadorSobrenatural3, 3);

            AtualizarArmas(planilhaXml, planilha.Armas);
            AtualizarBarraEnergia(planilhaXml, planilha.BarraEnergia);
            AtualizarCapacidades(planilhaXml, planilha.Capacidade);
            AtualizarConceito(planilhaXml, planilha.Conceito);
            AtualizarEquipamentos(planilhaXml, planilha.Equipamentos);
            AtualizarSaude(planilhaXml, planilha.EstadosSaude);
            AtualizarPrecedentes(planilhaXml, planilha.Precedentes);
            AtualizarTalentos(planilhaXml, planilha.Talentos);

            return planilhaXml.Value;
        }

        public Planilha ObterPlanilha(XmlDocument planilhaXml)
        {
            Planilha planilha = new Planilha();

            planilha.AtributosFisicos = ObterAtributosFisicos(planilhaXml);
            planilha.AtributosMentais = ObterAtributosMentais(planilhaXml);
            planilha.AtributosSobrenaturais = ObterAtributosSobrenaturais(planilhaXml);

            planilha.Atletico = ObterHabilitadorAtletico(planilhaXml);
            planilha.CombateProximo = ObterHabilitadorCombateProximo(planilhaXml);
            planilha.CombateAfastado = ObterHabilitadorCombateAfastado(planilhaXml);

            planilha.Instrucao = ObterHabilitadorInstrucao(planilhaXml);
            planilha.Perspicacia = ObterHabilitadorPerspicacia(planilhaXml);
            planilha.Social = ObterHabilitadorSocial(planilhaXml);

            planilha.HabilitadorSobrenatural1 = ObterHabilitadorSobrenatural(planilhaXml, 1);
            planilha.HabilitadorSobrenatural2 = ObterHabilitadorSobrenatural(planilhaXml, 2);
            planilha.HabilitadorSobrenatural3 = ObterHabilitadorSobrenatural(planilhaXml, 3);

            planilha.Armas = ObterArmas(planilhaXml);
            planilha.Equipamentos = ObterEquipamentos(planilhaXml);
            planilha.Talentos = ObterTalentos(planilhaXml);
            planilha.Precedentes = ObterPrecedentes(planilhaXml);
            planilha.EstadosSaude = ObterSaude(planilhaXml);
            planilha.Conceito = ObterConceito(planilhaXml);
            planilha.Capacidade = ObterCapacidades(planilhaXml);
            planilha.BarraEnergia = ObterBarraEnergia(planilhaXml);
            
            return planilha;
        }

        public XmlDocument AtualizarConceito(XmlDocument planilha, ConceitoPlanilha conceito)
        {
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Conceito/Nome", conceito.Nome);
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Conceito/Campanha", conceito.Campanha);
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Conceito/Personalidade", conceito.Personalidade);
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Conceito/Raca", conceito.Raca);
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Conceito/Ocupacao", conceito.Ocupacao);
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Conceito/Estilo", conceito.Estilo);

            return planilha;
        }

        public XmlDocument AtualizarAtributosFisicos(XmlDocument planilha, AtributosFisicosPlanilha atributosFisicos)
        {
            FuncoesSeiRPG.AlterarAtributoXML(planilha, "planilha/Atributo/Fisico", "Prioridade", atributosFisicos.Prioridade.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Atributo/Fisico/Forca", atributosFisicos.Forca.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Atributo/Fisico/Destreza", atributosFisicos.Destreza.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Atributo/Fisico/Resistencia", atributosFisicos.Resistencia.Valor.ToString());

            return planilha;
        }

        public XmlDocument AtualizarAtributosMentais(XmlDocument planilha, AtributosMentaisPlanilha atributosMentais)
        {
            FuncoesSeiRPG.AlterarAtributoXML(planilha, "Planilha/Atributo/Mental", "Prioridade", atributosMentais.Prioridade.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Atributo/Mental/Intelecto", atributosMentais.Intelecto.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Atributo/Mental/Influencia", atributosMentais.Influencia.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Atributo/Mental/Percepcao", atributosMentais.Percepcao.Valor.ToString());

            return planilha;
        }

        public XmlDocument AtualizarAtributosSobrenaturais(XmlDocument planilha, AtributosSobrenaturaisPlanilha atributosSobrenaturais)
        {
            FuncoesSeiRPG.AlterarAtributoXML(planilha, "Planilha/Atributo/Sobrenatural", "Prioridade", atributosSobrenaturais.Prioridade.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Atributo/Sobrenatural/Determinacao", atributosSobrenaturais.Determinacao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Atributo/Sobrenatural/Intuicao", atributosSobrenaturais.Intuicao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Atributo/Sobrenatural/Imunidade", atributosSobrenaturais.Imunidade.Valor.ToString());

            return planilha;
        }

        public XmlDocument AtualizarHabilitadorAtletico(XmlDocument planilha, HabilitadorAtletico atletico)
        {
            FuncoesSeiRPG.AlterarAtributoXML(planilha, "Planilha/Habilitador/Fisico/Atletico", "Valor", atletico.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Fisico/Atletico/Escalada", atletico.Escalada.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Fisico/Atletico/Salto", atletico.Salto.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Fisico/Atletico/Natacao", atletico.Natacao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Fisico/Atletico/Esporte", atletico.Esporte.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Fisico/Atletico/Corrida", atletico.Corrida.Valor.ToString());

            return planilha;
        }

        public XmlDocument AtualizarHabilitadorCombateProximo(XmlDocument planilha, HabilitadorCombateProximo combateProximo)
        {
            FuncoesSeiRPG.AlterarAtributoXML(planilha, "Planilha/Habilitador/Fisico/CombateProximo", "Valor", combateProximo.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Fisico/CombateProximo/CombateDesarmado", combateProximo.CombateDesarmado.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Fisico/CombateProximo/Evasao", combateProximo.Evasao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Fisico/CombateProximo/ArmaBrancaCurta", combateProximo.ArmBrancaCurta.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Fisico/CombateProximo/ArmaBrancaMedia", combateProximo.ArmBrancaMedia.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Fisico/CombateProximo/ArmaBrancaLonga", combateProximo.ArmBrancaLonga.Valor.ToString());

            return planilha;
        }

        public XmlDocument AtualizarHabilitadorCombateAfastado(XmlDocument planilha, HabilitadorCombateAfastado combateAfastado)
        {
            FuncoesSeiRPG.AlterarAtributoXML(planilha, "Planilha/Habilitador/Fisico/CombateAfastado", "Valor", combateAfastado.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Fisico/CombateAfastado/Armamento", combateAfastado.Armamento.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Fisico/CombateAfastado/ArmaImpulso", combateAfastado.ArmImpulso.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Fisico/CombateAfastado/ArmaFogoLeve", combateAfastado.ArmFogoLeve.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Fisico/CombateAfastado/ArmaFogoMedia", combateAfastado.ArmFogoMedia.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Fisico/CombateAfastado/ArmaFogoPesada", combateAfastado.ArmFogoPesada.Valor.ToString());

            return planilha;
        }

        public XmlDocument AtualizarHabilitadorInstrucao(XmlDocument planilha, HabilitadorInstrucao instrucao)
        {
            FuncoesSeiRPG.AlterarAtributoXML(planilha, "Planilha/Habilitador/Mental/Instrucao", "Valor", instrucao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Mental/Instrucao/Medicina", instrucao.Medicina.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Mental/Instrucao/Computacao", instrucao.Computacao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Mental/Instrucao/Conhecimento", instrucao.Conhecimento.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Mental/Instrucao/Linguistica", instrucao.Linguistica.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Mental/Instrucao/Ocultismo", instrucao.Ocultismo.Valor.ToString());

            return planilha;
        }

        public XmlDocument AtualizarHabilitadorPerspicacia(XmlDocument planilha, HabilitadorPerspicacia perspicacia)
        {
            FuncoesSeiRPG.AlterarAtributoXML(planilha, "Planilha/Habilitador/Mental/Perspicacia", "Valor", perspicacia.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Mental/Perspicacia/Investigacao", perspicacia.Investigacao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Mental/Perspicacia/Furtividade", perspicacia.Furtividade.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Mental/Perspicacia/Prestidigitacao", perspicacia.Prestidigitacao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Mental/Perspicacia/Reparo", perspicacia.Reparo.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Mental/Perspicacia/Subterfugio", perspicacia.Subterfugio.Valor.ToString());

            return planilha;
        }

        public XmlDocument AtualizarHabilitadorSocial(XmlDocument planilha, HabilitadorSocial social)
        {
            FuncoesSeiRPG.AlterarAtributoXML(planilha, "Planilha/Habilitador/Mental/Social", "Valor", social.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Mental/Social/Empatia", social.Empatia.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Mental/Social/Labia", social.Labia.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Mental/Social/Malandragem", social.Malandragem.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Mental/Social/TratoComAnimais", social.TratoAnimais.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Mental/Social/Performance", social.Performance.Valor.ToString());

            return planilha;
        }

        public XmlDocument AtualizarHabilitadorSobrenatuaral(XmlDocument planilha, HabilitadorSobrenatural sobrenatural, int num)
        {
            FuncoesSeiRPG.AlterarAtributoXML(planilha, "Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num, "Valor", sobrenatural.Valor.ToString());
            FuncoesSeiRPG.AlterarAtributoXML(planilha, "Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num, "Nome", sobrenatural.Descricao.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao1", sobrenatural.Slot1.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao2", sobrenatural.Slot2.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao3", sobrenatural.Slot3.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao4", sobrenatural.Slot4.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao5", sobrenatural.Slot5.Valor.ToString());

            return planilha;
        }

        public XmlDocument AtualizarSaude(XmlDocument planilha, SaudePlanilha[] saude)
        {
            if (saude != null && saude.Length > 0)
            {
                for (int i = 1; i <= 5; i++)
                {
                    FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Saude/Slot" + i + "/Estado", saude[i].Estado.ToString());
                    FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Saude/Slot" + i + "/Penalidade", saude[i].Penalidade.ToString());
                    FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Saude/Slot" + i + "/Nivel", saude[i].Nivel.ToString());
                }
            }

            return planilha;
        }

        public XmlDocument AtualizarPrecedentes(XmlDocument planilha, PrecedentePlanilha[] precedente)
        {
            if (precedente != null && precedente.Length > 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Precedente/Slot" + i, precedente[i].Descricao.ToString());
                    FuncoesSeiRPG.AlterarAtributoXML(planilha, "Planilha/Precedente/Slot" + i, "Custo", precedente[i].Valor.ToString());
                }
            }

            return planilha;
        }

        public XmlDocument AtualizarTalentos(XmlDocument planilha, TalentoPlanilha[] talento)
        {
            if (talento != null && talento.Length > 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Talento/Slot" + i, talento[i].Descricao.ToString());
                    FuncoesSeiRPG.AlterarAtributoXML(planilha, "Planilha/Talento/Slot" + i, "Ajuste", talento[i].Valor.ToString());
                }
            }

            return planilha;
        }

        public XmlDocument AtualizarArmas(XmlDocument planilha, ArmaPlanilha[] arma)
        {
            if (arma != null && arma.Length > 0)
            {
                for (int i = 1; i <= 5; i++)
                {
                    FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Arma/Slot" + i + "/Tipo", arma[i].Tipo.ToString());
                    FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Arma/Slot" + i + "/Tamanho", arma[i].Tamanho.ToString());
                    FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Arma/Slot" + i + "/Pente", arma[i].Pente.ToString());
                    FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Arma/Slot" + i + "/Alcance", arma[i].Alcance.ToString());
                    FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Arma/Slot" + i + "/Ajuste", arma[i].Ajuste.ToString());
                }
            }

            return planilha;
        }

        public XmlDocument AtualizarEquipamentos(XmlDocument planilha, EquipamentoPlanilha[] equipamento)
        {
            if (equipamento != null && equipamento.Length > 0)
            {
                for (int i = 1; i <= 5; i++)
                {
                    FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Equipamento/Slot" + i + "/Item", equipamento[i].Item.ToString());
                    FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Equipamento/Slot" + i + "/Tamanho", equipamento[i].Tamanho.ToString());
                    FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Equipamento/Slot" + i + "/Quantidade", equipamento[i].Quantidade.ToString());
                }
            }

            return planilha;
        }

        public XmlDocument AtualizarBarraEnergia(XmlDocument planilha, BarraEnergiaPlanilha energia)
        {
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/BarraEnergia/Vitalidade", energia.Vitalidade.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/BarraEnergia/EnergiaVital", energia.EnergiaVital.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/BarraEnergia/Corrupcao", energia.Corrupcao.ToString());

            return planilha;
        }

        public XmlDocument AtualizarCapacidades(XmlDocument planilha, CapacidadePlanilha capacidade)
        {
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Capacidade/DefesaFisica", capacidade.DefesaFisica.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Capacidade/DefesaMental", capacidade.DefesaMental.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Capacidade/Deslocamento", capacidade.Deslocamento.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Capacidade/Carga", capacidade.Carga.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Capacidade/ModificadorIniciativa", capacidade.ModificadorIniciativa.ToString());
            FuncoesSeiRPG.AlterarConteudoXML(planilha, "Planilha/Capacidade/IndiceProtecao", capacidade.IndiceProtecao.ToString());

            return planilha;
        }

        public AtributosFisicosPlanilha ObterAtributosFisicos(XmlDocument planilha)
        {
            AtributosFisicosPlanilha atributo = new AtributosFisicosPlanilha();

            atributo.Prioridade = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo(planilha, "Planilha/Atributo/Fisico", "Prioridade"));
            atributo.Forca.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Atributo/Fisico/Forca"));
            atributo.Destreza.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Atributo/Fisico/Destreza"));
            atributo.Resistencia.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Atributo/Fisico/Resistencia"));

            return atributo;
        }

        public AtributosMentaisPlanilha ObterAtributosMentais(XmlDocument planilha)
        {
            AtributosMentaisPlanilha atributo = new AtributosMentaisPlanilha();

            atributo.Prioridade = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo(planilha, "Planilha/Atributo/Mental", "Prioridade"));
            atributo.Intelecto.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Atributo/Mental/Intelecto"));
            atributo.Influencia.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Atributo/Mental/Influencia"));
            atributo.Percepcao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Atributo/Mental/Percepcao"));

            return atributo;
        }

        public AtributosSobrenaturaisPlanilha ObterAtributosSobrenaturais(XmlDocument planilha)
        {
            AtributosSobrenaturaisPlanilha atributo = new AtributosSobrenaturaisPlanilha();

            atributo.Prioridade = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo(planilha, "Planilha/Atributo/Sobrenatural", "Prioridade"));
            atributo.Determinacao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Atributo/Sobrenatural/Determinacao"));
            atributo.Intuicao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Atributo/Sobrenatural/Intuicao"));
            atributo.Imunidade.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Atributo/Sobrenatural/Imunidade"));

            return atributo;
        }

        public HabilitadorAtletico ObterHabilitadorAtletico(XmlDocument planilha)
        {
            HabilitadorAtletico habilitador = new HabilitadorAtletico();

            habilitador.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo(planilha, "Planilha/Habilitador/Fisico/Atletico", "Valor"));
            habilitador.Escalada.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Fisico/Atletico/Escalada"));
            habilitador.Salto.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Fisico/Atletico/Salto"));
            habilitador.Natacao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Fisico/Atletico/Natacao"));
            habilitador.Esporte.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Fisico/Atletico/Esporte"));
            habilitador.Corrida.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Fisico/Atletico/Corrida"));

            return habilitador;
        }

        public HabilitadorCombateProximo ObterHabilitadorCombateProximo(XmlDocument planilha)
        {
            HabilitadorCombateProximo habilitador = new HabilitadorCombateProximo();

            habilitador.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo(planilha, "Planilha/Habilitador/Fisico/CombateProximo", "Valor"));
            habilitador.CombateDesarmado.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Fisico/CombateProximo/CombateDesarmado"));
            habilitador.Evasao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Fisico/CombateProximo/Evasao"));
            habilitador.ArmBrancaCurta.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Fisico/CombateProximo/ArmaBrancaCurta"));
            habilitador.ArmBrancaMedia.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Fisico/CombateProximo/ArmaBrancaMedia"));
            habilitador.ArmBrancaLonga.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Fisico/CombateProximo/ArmaBrancaLonga"));

            return habilitador;
        }

        public HabilitadorCombateAfastado ObterHabilitadorCombateAfastado(XmlDocument planilha)
        {
            HabilitadorCombateAfastado habilitador = new HabilitadorCombateAfastado();

            habilitador.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo(planilha, "Planilha/Habilitador/Fisico/CombateAfastado", "Valor"));
            habilitador.Armamento.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Fisico/CombateAfastado/Armamento"));
            habilitador.ArmImpulso.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Fisico/CombateAfastado/ArmaImpulso"));
            habilitador.ArmFogoLeve.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Fisico/CombateAfastado/ArmaFogoLeve"));
            habilitador.ArmFogoMedia.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Fisico/CombateAfastado/ArmaFogoMedia"));
            habilitador.ArmFogoPesada.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Fisico/CombateAfastado/ArmaFogoPesada"));

            return habilitador;
        }

        public HabilitadorInstrucao ObterHabilitadorInstrucao(XmlDocument planilha)
        {
            HabilitadorInstrucao habilitador = new HabilitadorInstrucao();

            habilitador.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo(planilha, "Planilha/Habilitador/Mental/Instrucao", "Valor"));
            habilitador.Medicina.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Mental/Instrucao/Medicina"));
            habilitador.Computacao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Mental/Instrucao/Computacao"));
            habilitador.Conhecimento.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Mental/Instrucao/Conhecimento"));
            habilitador.Linguistica.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Mental/Instrucao/Linguistica"));
            habilitador.Ocultismo.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Mental/Instrucao/Ocultismo"));

            return habilitador;
        }

        public HabilitadorSocial ObterHabilitadorSocial(XmlDocument planilha)
        {
            HabilitadorSocial habilitador = new HabilitadorSocial();

            habilitador.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo(planilha, "P lanilha/Habilitador/Mental/Social", "Valor"));
            habilitador.Empatia.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Mental/Social/Empatia"));
            habilitador.Labia.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Mental/Social/Labia"));
            habilitador.Malandragem.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Mental/Social/Malandragem"));
            habilitador.Performance.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Mental/Social/Performance"));
            habilitador.TratoAnimais.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Mental/Social/TratoComAnimais"));

            return habilitador;
        }

        public HabilitadorPerspicacia ObterHabilitadorPerspicacia(XmlDocument planilha)
        {
            HabilitadorPerspicacia habilitador = new HabilitadorPerspicacia();

            habilitador.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo(planilha, "P lanilha/Habilitador/Mental/Perspicacia", "Valor"));
            habilitador.Investigacao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Mental/Perspicacia/Investigacao"));
            habilitador.Furtividade.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Mental/Perspicacia/Furtividade"));
            habilitador.Prestidigitacao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Mental/Perspicacia/Prestidigitacao"));
            habilitador.Reparo.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Mental/Perspicacia/Reparo"));
            habilitador.Subterfugio.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Mental/Perspicacia/Subterfugio"));

            return habilitador;
        }

        public HabilitadorSobrenatural ObterHabilitadorSobrenatural(XmlDocument planilha, int num)
        {
            HabilitadorSobrenatural habilitador = new HabilitadorSobrenatural();

            habilitador.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo(planilha, "P lanilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num, "Valor"));
            habilitador.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo(planilha, "P lanilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num, "Nome"));
            habilitador.Slot1.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao1"));
            habilitador.Slot2.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao2"));
            habilitador.Slot3.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao3"));
            habilitador.Slot4.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao4"));
            habilitador.Slot5.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao5"));

            return habilitador;
        }

        public SaudePlanilha[] ObterSaude(XmlDocument planilha)
        {
            SaudePlanilha[] saude = new SaudePlanilha[5];

            for (int i = 1; i <= 5; i++)
            {
                saude[i].Nivel = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Saude/Slot" + i + "/Nivel"));
                saude[i].Estado = FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Saude/Slot" + i + "/Estado");
                saude[i].Penalidade = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Saude/Slot" + i + "/Penalidade"));
            }

            return saude;
        }

        public PrecedentePlanilha[] ObterPrecedentes(XmlDocument planilha)
        {
            PrecedentePlanilha[] precedentes = new PrecedentePlanilha[10];

            for (int i = 1; i <= 10; i++)
            {
                precedentes[i].Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo(planilha, "Planilha/Precedente/Slot" + i, "Custo"));
                precedentes[i].Descricao = FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Precedente/Slot" + i);
            }

            return precedentes;
        }

        public TalentoPlanilha[] ObterTalentos(XmlDocument planilha)
        {
            TalentoPlanilha[] talentos = new TalentoPlanilha[10];

            for (int i = 1; i <= 10; i++)
            {
                talentos[i].Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo(planilha, "Planilha/Talento/Slot" + i, "Ajuste"));
                talentos[i].Descricao = FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Talento/Slot" + i);
            }

            return talentos;
        }

        public ArmaPlanilha[] ObterArmas(XmlDocument planilha)
        {
            ArmaPlanilha[] armas = new ArmaPlanilha[5];

            for (int i = 1; i <= 5; i++)
            {
                armas[i].Tipo = FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Arma/Slot" + i + "/Tipo");
                armas[i].Tamanho = FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Arma/Slot" + i + "/Tamanho");
                armas[i].Pente = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Arma/Slot" + i + "/Pente"));
                armas[i].Alcance = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Arma/Slot" + i + "/Alcance"));
                armas[i].Ajuste = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Arma/Slot" + i + "/Ajuste"));
            }

            return armas;
        }

        public EquipamentoPlanilha[] ObterEquipamentos(XmlDocument planilha)
        {
            EquipamentoPlanilha[] equipamentos = new EquipamentoPlanilha[5];

            for (int i = 1; i <= 5; i++)
            {
                equipamentos[i].Item = FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Equipamento/Slot" + i + "/Item");
                equipamentos[i].Tamanho = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Equipamento/Slot" + i + "/Tamanho"));
                equipamentos[i].Quantidade = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Equipamento/Slot" + i + "/Quantidade"));
            }

            return equipamentos;
        }

        public BarraEnergiaPlanilha ObterBarraEnergia(XmlDocument planilha)
        {
            BarraEnergiaPlanilha energia = new BarraEnergiaPlanilha();

            energia.Vitalidade = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/BarraEnergia/Vitalidade"));
            energia.EnergiaVital = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/BarraEnergia/EnergiaVital"));
            energia.Corrupcao = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/BarraEnergia/Corrupcao"));

            return energia;
        }

        public CapacidadePlanilha ObterCapacidades(XmlDocument planilha)
        {
            CapacidadePlanilha capacidade = new CapacidadePlanilha();

            capacidade.DefesaFisica = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Capacidade/DefesaFisica"));
            capacidade.DefesaMental = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Capacidade/DefesaMental"));
            capacidade.Deslocamento = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Capacidade/Deslocamento"));
            capacidade.Carga = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Capacidade/Carga"));
            capacidade.ModificadorIniciativa = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Capacidade/ModificadorIniciativa"));
            capacidade.IndiceProtecao = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Capacidade/IndiceProtecao"));

            return capacidade;
        }

        public ConceitoPlanilha ObterConceito(XmlDocument planilha)
        {
            ConceitoPlanilha conceito = new ConceitoPlanilha();

            conceito.Nome = FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Conceito/Nome");
            conceito.Ocupacao = FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Conceito/Ocupacao");
            conceito.Personalidade = FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Conceito/Personalidade");
            conceito.Raca = FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Conceito/Raca");
            conceito.Campanha = FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Conceito/Campanha");
            conceito.Estilo = FuncoesSeiRPG.RetornarValorConteudo(planilha, "Planilha/Conceito/Estilo");

            return conceito;
        }
    }
}
