// -----------------------------------------------------------------------
// <copyright file="Planilha.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesPlanilha
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Planilha
    {
        #region Conceito
        
        public string Nome { get; set; }
        public string Campanha { get; set; }
        public string Personalidade { get; set; }
        public string Raca { get; set; }
        public string Ocupacao { get; set; }
        public string Estilo { get; set; }

        #endregion

        #region Atributos

        public int Forca
        {
            get;
            set;
        }

        public int Destreza
        {
            get;
            set;
        }

        public int Resistencia
        {
            get;
            set;
        }

        public int Intelecto
        {
            get;
            set;
        }

        public int Influencia
        {
            get;
            set;
        }

        public int Percepcao
        {
            get;
            set;
        }

        public int Determinacao
        {
            get;
            set;
        }

        public int Intuicao
        {
            get;
            set;
        }

        public int Imunidade
        {
            get;
            set;
        }

        #endregion

        #region Habilitadores

        public int Atletico
        {
            get;
            set;
        }

        #region Especializacoes Atletico

        public int Salto
        {
            get;
            set;
        }

        public int Corrida
        {
            get;
            set;
        }

        public int Natacao
        {
            get;
            set;
        }

        public int Escalada
        {
            get;
            set;
        }

        public int Esporte
        {
            get;
            set;
        }

        #endregion

        public int CombateProximo
        {
            get;
            set;
        }

        #region Especializacoes Combate Proximo

        public int CombateDesarmado
        {
            get;
            set;
        }

        public int Evasao
        {
            get;
            set;
        }

        public int ArmaBrancaCurta
        {
            get;
            set;
        }

        public int ArmaBrancaMedia
        {
            get;
            set;
        }

        public int ArmaBrancaPesada
        {
            get;
            set;
        }
        #endregion

        public int CombateAfastado
        {
            get;
            set;
        }

        #region Especializacoes Combate Afastado

        public int Armamento
        {
            get;
            set;
        }

        public int ArmaImpulso
        {
            get;
            set;
        }

        public int ArmaFogoLeve
        {
            get;
            set;
        }

        public int ArmaFogoMedia
        {
            get;
            set;
        }

        public int ArmaFogoPesada
        {
            get;
            set;
        }

        #endregion

        public int Instrucao
        {
            get;
            set;
        }

        #region Especializacoes Instrucao

        public int Medicina
        {
            get;
            set;
        }

        public int Computacao
        {
            get;
            set;
        }

        public int Conhecimento
        {
            get;
            set;
        }

        public int Linguistica
        {
            get;
            set;
        }

        public int Ocultismo
        {
            get;
            set;
        }
        #endregion

        public int Social
        {
            get;
            set;
        }

        #region Especializacoes Social

        public int Empatia
        {
            get;
            set;
        }

        public int TratoAnimais
        {
            get;
            set;
        }

        public int Labia
        {
            get;
            set;
        }

        public int Malandragem
        {
            get;
            set;
        }

        public int Performance
        {
            get;
            set;
        }

        #endregion

        public int Perspicacia
        {
            get;
            set;
        }

        #region Especializacoes Perspicacia

        public int Investigacao
        {
            get;
            set;
        }

        public int Furtividade
        {
            get;
            set;
        }

        public int Prestidigitacao
        {
            get;
            set;
        }

        public int Subterfugio
        {
            get;
            set;
        }
        
        #endregion

        public int HabilitadorSobrenatural1
        {
            get;
            set;
        }

        #region Especializacoes HabilitadorSobrenatural1

        public int EspHabSob1Slot1
        {
            get;
            set;
        }

        public int EspHabSob1Slot2
        {
            get;
            set;
        }

        public int EspHabSob1Slot3
        {
            get;
            set;
        }

        public int EspHabSob1Slot4
        {
            get;
            set;
        }

        public int EspHabSob1Slot5
        {
            get;
            set;
        }
        #endregion

        public int HabilitadorSobrenatural2
        {
            get;
            set;
        }

        #region Especializacoes HabilitadorSobrenatural2

        public int EspHabSob2Slot1
        {
            get;
            set;
        }

        public int EspHabSob2Slot2
        {
            get;
            set;
        }

        public int EspHabSob2Slot3
        {
            get;
            set;
        }

        public int EspHabSob2Slot4
        {
            get;
            set;
        }

        public int EspHabSob2Slot5
        {
            get;
            set;
        }

        #endregion

        public int HabilitadorSobrenatural3
        {
            get;
            set;
        }

        #region Especializacoes HabilitadorSobrenatural3

        public int EspHabSob3Slot1
        {
            get;
            set;
        }

        public int EspHabSob3Slot2
        {
            get;
            set;
        }

        public int EspHabSob3Slot3
        {
            get;
            set;
        }

        public int EspHabSob3Slot4
        {
            get;
            set;
        }

        public int EspHabSob3Slot5
        {
            get;
            set;
        }

        #endregion

        #endregion

        #region Talentos

        public List<string> Talentos { get; set; }

        #endregion

        #region Precedentes

        public List<string> Precedentes { get; set; }

        #endregion

        #region Capacidades

        public int DefesaFisica { get; set; }

        public int DefesaMental { get; set; }

        public int Deslocamento { get; set; }

        public int Carga { get; set; }

        public int Subturno { get; set; }

        public int IndiceProtecao { get; set; }

        public int ModificadorIniciativa { get; set; }

        #endregion

        #region Armas

        public List<ArmaPlanilha> Armas { get; set; }

        #endregion

        #region Equipamentos

        public List<EquipamentoPlanilha> Equipamentos { get; set; }

        #endregion

        #region Barra Saude

        public List<SaudePlanilha> EstadosSaude { get; set; }

        #endregion

        #region Barra Energia

        public int Vitalidade { get; set; }

        public int EnergiaVital { get; set; }

        public int Corrupcao { get; set; }

        #endregion

    }
}
