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
            FuncoesSeiRPG.AlterarAtributoXML("Planilha/Habilitador/Fisico/Atletico", "Valor", atletico.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/Atletico/Escalada", atletico.Escalada.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/Atletico/Salto", atletico.Salto.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/Atletico/Natacao", atletico.Natacao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/Atletico/Esporte", atletico.Esporte.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/Atletico/Corrida", atletico.Corrida.Valor.ToString());
        }

        public void AtualizarHabilitadorCombateProximo(HabilitadorCombateProximo combateProximo)
        {
            FuncoesSeiRPG.AlterarAtributoXML("Planilha/Habilitador/Fisico/CombateProximo", "Valor", combateProximo.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateProximo/CombateDesarmado", combateProximo.CombateDesarmado.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateProximo/Evasao", combateProximo.Evasao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateProximo/ArmaBrancaCurta", combateProximo.ArmBrancaCurta.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateProximo/ArmaBrancaMedia", combateProximo.ArmBrancaMedia.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateProximo/ArmaBrancaLonga", combateProximo.ArmBrancaLonga.Valor.ToString());
        }

        public void AtualizarHabilitadorCombateAfastado(HabilitadorCombateAfastado combateAfastado)
        {
            FuncoesSeiRPG.AlterarAtributoXML("Planilha/Habilitador/Fisico/CombateAfastado", "Valor", combateAfastado.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateAfastado/Armamento", combateAfastado.Armamento.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateAfastado/ArmaImpulso", combateAfastado.ArmImpulso.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateAfastado/ArmaFogoLeve", combateAfastado.ArmFogoLeve.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateAfastado/ArmaFogoMedia", combateAfastado.ArmFogoMedia.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Fisico/CombateAfastado/ArmaFogoPesada", combateAfastado.ArmFogoPesada.Valor.ToString());
        }

        public void AtualizarHabilitadorInstrucao(HabilitadorInstrucao instrucao)
        {
            FuncoesSeiRPG.AlterarAtributoXML("Planilha/Habilitador/Mental/Instrucao", "Valor", instrucao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Instrucao/Medicina", instrucao.Medicina.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Instrucao/Computacao", instrucao.Computacao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Instrucao/Conhecimento", instrucao.Conhecimento.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Instrucao/Linguistica", instrucao.Linguistica.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Instrucao/Ocultismo", instrucao.Ocultismo.Valor.ToString());
        }

        public void AtualizarHabilitadorPerspicacia(HabilitadorPerspicacia perspicacia)
        {
            FuncoesSeiRPG.AlterarAtributoXML("Planilha/Habilitador/Mental/Perspicacia", "Valor", perspicacia.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Perspicacia/Investigacao", perspicacia.Investigacao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Perspicacia/Furtividade", perspicacia.Furtividade.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Perspicacia/Prestidigitacao", perspicacia.Prestidigitacao.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Perspicacia/Reparo", perspicacia.Reparo.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Perspicacia/Subterfugio", perspicacia.Subterfugio.Valor.ToString());
        }

        public void AtualizarHabilitadorSocial(HabilitadorSocial social)
        {
            FuncoesSeiRPG.AlterarAtributoXML("Planilha/Habilitador/Mental/Social", "Valor", social.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Social/Empatia", social.Empatia.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Social/Labia", social.Labia.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Social/Malandragem", social.Malandragem.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Social/TratoComAnimais", social.TratoAnimais.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Mental/Social/Performance", social.Performance.Valor.ToString());
        }

        public void AtualizarHabilitadorSobrenatuaral(HabilitadorSobrenatural sobrenatural, int num)
        {
            FuncoesSeiRPG.AlterarAtributoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num, "Valor", sobrenatural.Valor.ToString());
            FuncoesSeiRPG.AlterarAtributoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num, "Nome", sobrenatural.Descricao.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao1", sobrenatural.Slot1.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao2", sobrenatural.Slot2.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao3", sobrenatural.Slot3.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao4", sobrenatural.Slot4.Valor.ToString());
            FuncoesSeiRPG.AlterarConteudoXML("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao5", sobrenatural.Slot5.Valor.ToString());
        }

        public void AtualizarSaude(SaudePlanilha[] saude)
        {
            if (saude != null && saude.Length > 0)
            {
                for (int i = 1; i <= 5; i++)
                {
                    FuncoesSeiRPG.AlterarConteudoXML("Planilha/Saude/Slot" + i + "/Estado", saude[i].Estado.ToString());
                    FuncoesSeiRPG.AlterarConteudoXML("Planilha/Saude/Slot" + i + "/Penalidade", saude[i].Penalidade.ToString());
                    FuncoesSeiRPG.AlterarConteudoXML("Planilha/Saude/Slot" + i + "/Nivel", saude[i].Nivel.ToString());
                }
            }
        }

        public void AtualizarPrecedentes(PrecedentePlanilha[] precedente)
        {
            if (precedente != null && precedente.Length > 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    FuncoesSeiRPG.AlterarConteudoXML("Planilha/Precedente/Slot" + i, precedente[i].Descricao.ToString());
                    FuncoesSeiRPG.AlterarAtributoXML("Planilha/Precedente/Slot" + i, "Custo", precedente[i].Valor.ToString());
                }
            }
        }

        public void AtualizarTalentos(TalentoPlanilha[] talento)
        {
            if (talento != null && talento.Length > 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    FuncoesSeiRPG.AlterarConteudoXML("Planilha/Talento/Slot" + i, talento[i].Descricao.ToString());
                    FuncoesSeiRPG.AlterarAtributoXML("Planilha/Talento/Slot" + i, "Ajuste", talento[i].Valor.ToString());
                }
            }
        }

        public void AtualizarArmas(ArmaPlanilha[] arma)
        {
            if (arma != null && arma.Length > 0)
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
        }

        public void AtualizarEquipamentos(EquipamentoPlanilha[] equipamento)
        {
            if (equipamento != null && equipamento.Length > 0)
            {
                for (int i = 1; i <= 5; i++)
                {
                    FuncoesSeiRPG.AlterarConteudoXML("Planilha/Equipamento/Slot" + i + "/Item", equipamento[i].Item.ToString());
                    FuncoesSeiRPG.AlterarConteudoXML("Planilha/Equipamento/Slot" + i + "/Tamanho", equipamento[i].Tamanho.ToString());
                    FuncoesSeiRPG.AlterarConteudoXML("Planilha/Equipamento/Slot" + i + "/Quantidade", equipamento[i].Quantidade.ToString());
                }
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

            atributo.Prioridade = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo("Planilha/Atributo/Fisico", "Prioridade"));
            atributo.Forca.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/Atributo/Fisico/Forca"));
            atributo.Destreza.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/Atributo/Fisico/Destreza"));
            atributo.Resistencia.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/Atributo/Fisico/Resistencia"));

            return atributo;
        }

        public AtributosMentaisPlanilha ObterAtributosMentais(Planilha planilha)
        {
            AtributosMentaisPlanilha atributo = new AtributosMentaisPlanilha();

            atributo.Prioridade = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo("Planilha/Atributo/Mental", "Prioridade"));
            atributo.Intelecto.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/Atributo/Mental/Intelecto"));
            atributo.Influencia.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/Atributo/Mental/Influencia"));
            atributo.Percepcao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/Atributo/Mental/Percepcao"));

            return atributo;
        }

        public AtributosSobrenaturaisPlanilha ObterAtributosSobrenaturais(Planilha planilha)
        {
            AtributosSobrenaturaisPlanilha atributo = new AtributosSobrenaturaisPlanilha();

            atributo.Prioridade = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo("Planilha/Atributo/Sobrenatural", "Prioridade"));
            atributo.Determinacao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/Atributo/Sobrenatural/Determinacao"));
            atributo.Intuicao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/Atributo/Sobrenatural/Intuicao"));
            atributo.Imunidade.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/Atributo/Sobrenatural/Imunidade"));

            return atributo;
        }

        public HabilitadorAtletico ObterHabilitadorAtletico(Planilha planilha)
        {
            HabilitadorAtletico habilitador = new HabilitadorAtletico();

            habilitador.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo("Planilha/Habilitador/Fisico/Atletico", "Valor"));
            habilitador.Escalada.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Fisico/Atletico/Escalada"));
            habilitador.Salto.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Fisico/Atletico/Salto"));
            habilitador.Natacao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Fisico/Atletico/Natacao"));
            habilitador.Esporte.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Fisico/Atletico/Esporte"));
            habilitador.Corrida.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Fisico/Atletico/Corrida"));

            return habilitador;
        }

        public HabilitadorCombateProximo ObterHabilitadorCombateProximo(Planilha planilha)
        {
            HabilitadorCombateProximo habilitador = new HabilitadorCombateProximo();

            habilitador.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo("Planilha/Habilitador/Fisico/CombateProximo", "Valor"));
            habilitador.CombateDesarmado.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Fisico/CombateProximo/CombateDesarmado"));
            habilitador.Evasao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Fisico/CombateProximo/Evasao"));
            habilitador.ArmBrancaCurta.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Fisico/CombateProximo/ArmaBrancaCurta"));
            habilitador.ArmBrancaMedia.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Fisico/CombateProximo/ArmaBrancaMedia"));
            habilitador.ArmBrancaLonga.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Fisico/CombateProximo/ArmaBrancaLonga"));

            return habilitador;
        }

        public HabilitadorCombateAfastado ObterHabilitadorCombateAfastado(Planilha planilha)
        {
            HabilitadorCombateAfastado habilitador = new HabilitadorCombateAfastado();

            habilitador.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo("Planilha/Habilitador/Fisico/CombateAfastado", "Valor"));
            habilitador.Armamento.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Fisico/CombateAfastado/Armamento"));
            habilitador.ArmImpulso.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Fisico/CombateAfastado/ArmaImpulso"));
            habilitador.ArmFogoLeve.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Fisico/CombateAfastado/ArmaFogoLeve"));
            habilitador.ArmFogoMedia.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Fisico/CombateAfastado/ArmaFogoMedia"));
            habilitador.ArmFogoPesada.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Fisico/CombateAfastado/ArmaFogoPesada"));

            return habilitador;
        }

        public HabilitadorInstrucao ObterHabilitadorInstrucao(Planilha planilha)
        {
            HabilitadorInstrucao habilitador = new HabilitadorInstrucao();

            habilitador.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo("Planilha/Habilitador/Mental/Instrucao", "Valor"));
            habilitador.Medicina.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Mental/Instrucao/Medicina"));
            habilitador.Computacao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Mental/Instrucao/Computacao"));
            habilitador.Conhecimento.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Mental/Instrucao/Conhecimento"));
            habilitador.Linguistica.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Mental/Instrucao/Linguistica"));
            habilitador.Ocultismo.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Mental/Instrucao/Ocultismo"));

            return habilitador;
        }

        public HabilitadorSocial ObterHabilitadorSocial(Planilha planilha)
        {
            HabilitadorSocial habilitador = new HabilitadorSocial();

            habilitador.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo("Planilha/Habilitador/Mental/Social", "Valor"));
            habilitador.Empatia.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Mental/Social/Empatia"));
            habilitador.Labia.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Mental/Social/Labia"));
            habilitador.Malandragem.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Mental/Social/Malandragem"));
            habilitador.Performance.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Mental/Social/Performance"));
            habilitador.TratoAnimais.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Mental/Social/TratoComAnimais"));

            return habilitador;
        }

        public HabilitadorPerspicacia ObterHabilitadorPerspicacia(Planilha planilha)
        {
            HabilitadorPerspicacia habilitador = new HabilitadorPerspicacia();

            habilitador.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo("Planilha/Habilitador/Mental/Perspicacia", "Valor"));
            habilitador.Investigacao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Mental/Perspicacia/Investigacao"));
            habilitador.Furtividade.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Mental/Perspicacia/Furtividade"));
            habilitador.Prestidigitacao.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Mental/Perspicacia/Prestidigitacao"));
            habilitador.Reparo.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Mental/Perspicacia/Reparo"));
            habilitador.Subterfugio.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Mental/Perspicacia/Subterfugio"));

            return habilitador;
        }

        public HabilitadorSobrenatural ObterHabilitadorSobrenatural(Planilha planilha, int num)
        {
            HabilitadorSobrenatural habilitador = new HabilitadorSobrenatural();

            habilitador.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num, "Valor"));
            habilitador.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo("Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num, "Nome"));
            habilitador.Slot1.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao1"));
            habilitador.Slot2.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao2"));
            habilitador.Slot3.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao3"));
            habilitador.Slot4.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao4"));
            habilitador.Slot5.Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Habilitador/Sobrenatural/HabilitadorSobrenatural" + num + "/Especializacao5"));

            return habilitador;
        }

        public SaudePlanilha[] ObterSaude(Planilha planilha)
        {
            SaudePlanilha[] saude = new SaudePlanilha[5];
            
            for (int i = 1; i <= 5; i++)
            {
                saude[i].Nivel = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Saude/Slot"+i +"/Nivel"));
                saude[i].Estado = FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Saude/Slot" + i + "/Estado");
                saude[i].Penalidade = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Saude/Slot" + i + "/Penalidade"));
            }

            return saude;
        }

        public PrecedentePlanilha[] ObterPrecedentes(Planilha planilha)
        {
            PrecedentePlanilha[] precedentes = new PrecedentePlanilha[10];

            for (int i = 1; i <= 10; i++)
            {
                precedentes[i].Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo(" Planilha/Precedente/Slot" + i,"Custo"));
                precedentes[i].Descricao = FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Precedente/Slot" + i);                
            }

            return precedentes;
        }

        public TalentoPlanilha[] ObterTalentos(Planilha planilha)
        {
            TalentoPlanilha[] talentos = new TalentoPlanilha[10];

            for (int i = 1; i <= 10; i++)
            {
                talentos[i].Valor = Convert.ToInt16(FuncoesSeiRPG.RetornarAtributoConteudo(" Planilha/Talento/Slot" + i, "Ajuste"));
                talentos[i].Descricao = FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Talento/Slot" + i); 
            }

            return talentos;
        }

        public ArmaPlanilha[] ObterArmas(Planilha planilha)
        {
            ArmaPlanilha[] armas = new ArmaPlanilha[5];

            for (int i = 1; i <= 5; i++)
            {
                armas[i].Tipo = FuncoesSeiRPG.RetornarValorConteudo("Planilha/Arma/Slot" + i + "/Tipo");
                armas[i].Tamanho = FuncoesSeiRPG.RetornarValorConteudo("Planilha/Arma/Slot" + i + "/Tamanho");
                armas[i].Pente = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/Arma/Slot" + i + "/Pente"));
                armas[i].Alcance = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/Arma/Slot" + i + "/Alcance"));
                armas[i].Ajuste = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/Arma/Slot" + i + "/Ajuste"));
            }

            return armas;
        }

        public EquipamentoPlanilha[] ObterEquipamentos(Planilha planilha)
        {
            EquipamentoPlanilha[] equipamentos = new EquipamentoPlanilha[5];

            for (int i = 1; i <= 5; i++)
            {
                equipamentos[i].Item = FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Equipamento/Slot" + i + "/Item");
                equipamentos[i].Tamanho = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Equipamento/Slot" + i + "/Tamanho"));
                equipamentos[i].Quantidade = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo(" Planilha/Equipamento/Slot" + i + "/Quantidade"));
            }

            return equipamentos;
        }

        public BarraEnergiaPlanilha ObterBarraEnergia(Planilha planilha)
        {
            BarraEnergiaPlanilha energia = new BarraEnergiaPlanilha();

            energia.Vitalidade = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/BarraEnergia/Vitalidade"));
            energia.EnergiaVital = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/BarraEnergia/EnergiaVital"));
            energia.Corrupcao = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/BarraEnergia/Corrupcao"));

            return energia;
        }

        public CapacidadePlanilha ObterCapacidades(Planilha planilha)
        {
            CapacidadePlanilha capacidade = new CapacidadePlanilha();

            capacidade.Carga = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/Capacidade/DefesaFisica"));
            capacidade.Carga = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/Capacidade/DefesaMental"));
            capacidade.Carga = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/Capacidade/Deslocamento"));
            capacidade.Carga = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/Capacidade/Carga"));
            capacidade.Carga = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/Capacidade/ModificadorIniciativa"));
            capacidade.Carga = Convert.ToInt16(FuncoesSeiRPG.RetornarValorConteudo("Planilha/Capacidade/IndiceProtecao"));

            return capacidade;
        }
    }
}
