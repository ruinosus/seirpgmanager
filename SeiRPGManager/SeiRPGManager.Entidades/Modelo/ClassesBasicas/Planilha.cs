// -----------------------------------------------------------------------
// <copyright file="Planilha.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesBasicas
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
            set
            {
                if (value < 0)
                {
                    Forca = 1;
                }else if (value > 10)
                {
                    Forca = 10;
                }
                else
                {
                    Forca = value;
                }
            }
        }

        public int Destreza
        {
            get;
            set
            {
                if (value < 0)
                {
                    Destreza = 1;
                }
                else if (value > 10)
                {
                    Destreza = 10;
                }
                else
                {
                    Destreza = value;
                }
            }
        }

        public int Resistencia
        {
            get;
            set
            {
                if (value < 0)
                {
                    Resistencia = 1;
                }
                else if (value > 10)
                {
                    Resistencia = 10;
                }
                else
                {
                    Resistencia = value;
                }
            }
        }

        public int Intelecto
        {
            get;
            set
            {
                if (value < 0)
                {
                    Intelecto = 1;
                }
                else if (value > 10)
                {
                    Intelecto = 10;
                }
                else
                {
                    Intelecto = value;
                }
            }
        }

        public int Influencia
        {
            get;
            set
            {
                if (value < 0)
                {
                    Influencia = 1;
                }
                else if (value > 10)
                {
                    Influencia = 10;
                }
                else
                {
                    Influencia = value;
                }
            }
        }

        public int Percepcao
        {
            get;
            set
            {
                if (value < 0)
                {
                    Percepcao = 1;
                }
                else if (value > 10)
                {
                    Percepcao = 10;
                }
                else
                {
                    Percepcao = value;
                }
            }
        }

        public int Determinacao
        {
            get;
            set
            {
                if (value < 0)
                {
                    Determinacao = 1;
                }
                else if (value > 10)
                {
                    Determinacao = 10;
                }
                else
                {
                    Determinacao = value;
                }
            }
        }

        public int Intuicao
        {
            get;
            set
            {
                if (value < 0)
                {
                    Intuicao = 1;
                }
                else if (value > 10)
                {
                    Intuicao = 10;
                }
                else
                {
                    Intuicao = value;
                }
            }
        }

        public int Imunidade
        {
            get;
            set
            {
                if (value < 0)
                {
                    Imunidade = 1;
                }
                else if (value > 10)
                {
                    Imunidade = 10;
                }
                else
                {
                    Imunidade = value;
                }
            }
        }

        #endregion

        #region Habilitadores

        public int Atletico
        {
            get;
            set
            {
                if (value < 0)
                {
                    Atletico = 1;
                }
                else if (value > 5)
                {
                    Atletico = 5;
                }
                else
                {
                    Atletico = value;
                }
            }
        }

        #region Especializacoes Atletico

        public int Salto
        {
            get;
            set
            {
                if (value < 0)
                {
                    Salto = 0;
                }else if(value > Atletico)
	            {
                    value = Atletico;
	            }
                else if (value > 3)
                {
                    Salto = 3;
                }
                else
                {
                    Salto = value;
                }
            }
        }

        public int Corrida
        {
            get;
            set
            {
                if (value < 0)
                {
                    Corrida = 0;
                }
                else if (value > Atletico)
                {
                    value = Atletico;
                }
                else if (value > 3)
                {
                    Corrida = 3;
                }
                else
                {
                    Corrida = value;
                }
            }
        }

        public int Natacao
        {
            get;
            set
            {
                if (value < 0)
                {
                    Natacao = 0;
                }
                else if (value > Atletico)
                {
                    value = Atletico;
                }
                else if (value > 3)
                {
                    Natacao = 3;
                }
                else
                {
                    Natacao = value;
                }
            }
        }

        public int Escalada
        {
            get;
            set
            {
                if (value < 0)
                {
                    Escalada = 0;
                }
                else if (value > Atletico)
                {
                    value = Atletico;
                }
                else if (value > 3)
                {
                    Escalada = 3;
                }
                else
                {
                    Escalada = value;
                }
            }
        }

        public int Esporte
        {
            get;
            set
            {
                if (value < 0)
                {
                    Esporte = 0;
                }
                else if (value > Atletico)
                {
                    value = Atletico;
                }
                else if (value > 3)
                {
                    Esporte = 3;
                }
                else
                {
                    Esporte = value;
                }
            }
        }

        #endregion

        public int CombateProximo
        {
            get;
            set
            {
                if (value < 0)
                {
                    CombateProximo = 1;
                }
                else if (value > 5)
                {
                    CombateProximo = 5;
                }
                else
                {
                    CombateProximo = value;
                }
            }
        }

        #region Especializacoes Combate Proximo

        public int CombateDesarmado
        {
            get;
            set
            {
                if (value < 0)
                {
                    CombateDesarmado = 0;
                }
                else if (value > CombateProximo)
                {
                    value = CombateProximo;
                }
                else if (value > 3)
                {
                    CombateDesarmado = 3;
                }
                else
                {
                    CombateDesarmado = value;
                }
            }
        }

        public int Evasao
        {
            get;
            set
            {
                if (value < 0)
                {
                    Evasao = 0;
                }
                else if (value > CombateProximo)
                {
                    value = CombateProximo;
                }
                else if (value > 3)
                {
                    Evasao = 3;
                }
                else
                {
                    Evasao = value;
                }
            }
        }

        public int ArmaBrancaCurta
        {
            get;
            set
            {
                if (value < 0)
                {
                    ArmaBrancaCurta = 0;
                }
                else if (value > CombateProximo)
                {
                    value = CombateProximo;
                }
                else if (value > 3)
                {
                    ArmaBrancaCurta = 3;
                }
                else
                {
                    ArmaBrancaCurta = value;
                }
            }
        }

        public int ArmaBrancaMedia
        {
            get;
            set
            {
                if (value < 0)
                {
                    ArmaBrancaMedia = 0;
                }
                else if (value > CombateProximo)
                {
                    value = CombateProximo;
                }
                else if (value > 3)
                {
                    ArmaBrancaMedia = 3;
                }
                else
                {
                    ArmaBrancaMedia = value;
                }
            }
        }

        public int ArmaBrancaPesada
        {
            get;
            set
            {
                if (value < 0)
                {
                    ArmaBrancaPesada = 0;
                }
                else if (value > CombateProximo)
                {
                    value = CombateProximo;
                }
                else if (value > 3)
                {
                    ArmaBrancaPesada = 3;
                }
                else
                {
                    ArmaBrancaPesada = value;
                }
            }
        }
        #endregion

        public int CombateAfastado
        {
            get;
            set
            {
                if (value < 0)
                {
                    CombateAfastado = 1;
                }
                else if (value > 5)
                {
                    CombateAfastado = 5;
                }
                else
                {
                    CombateAfastado = value;
                }
            }
        }

        #region Especializacoes Combate Afastado

        public int Armamento
        {
            get;
            set
            {
                if (value < 0)
                {
                    Armamento = 0;
                }
                else if (value > CombateAfastado)
                {
                    value = CombateAfastado;
                }
                else if (value > 3)
                {
                    Armamento = 3;
                }
                else
                {
                    Armamento = value;
                }
            }
        }

        public int ArmaImpulso
        {
            get;
            set
            {
                if (value < 0)
                {
                    ArmaImpulso = 0;
                }
                else if (value > CombateAfastado)
                {
                    value = CombateAfastado;
                }
                else if (value > 3)
                {
                    ArmaImpulso = 3;
                }
                else
                {
                    ArmaImpulso = value;
                }
            }
        }

        public int ArmaFogoLeve
        {
            get;
            set
            {
                if (value < 0)
                {
                    ArmaFogoLeve = 0;
                }
                else if (value > CombateAfastado)
                {
                    value = CombateAfastado;
                }
                else if (value > 3)
                {
                    ArmaFogoLeve = 3;
                }
                else
                {
                    ArmaFogoLeve = value;
                }
            }
        }

        public int ArmaFogoMedia
        {
            get;
            set
            {
                if (value < 0)
                {
                    ArmaFogoMedia = 0;
                }
                else if (value > CombateAfastado)
                {
                    value = CombateAfastado;
                }
                else if (value > 3)
                {
                    ArmaFogoMedia = 3;
                }
                else
                {
                    ArmaFogoMedia = value;
                }
            }
        }

        public int ArmaFogoPesada
        {
            get;
            set
            {
                if (value < 0)
                {
                    ArmaFogoPesada = 0;
                }
                else if (value > CombateAfastado)
                {
                    value = CombateAfastado;
                }
                else if (value > 3)
                {
                    ArmaFogoPesada = 3;
                }
                else
                {
                    ArmaFogoPesada = value;
                }
            }
        }

        #endregion

        public int Instrucao
        {
            get;
            set
            {
                if (value < 0)
                {
                    Instrucao = 1;
                }
                else if (value > 5)
                {
                    Instrucao = 5;
                }
                else
                {
                    Instrucao = value;
                }
            }
        }

        #region Especializacoes Instrucao

        public int Medicina
        {
            get;
            set
            {
                if (value < 0)
                {
                    Medicina = 0;
                }
                else if (value > Instrucao)
                {
                    value = Instrucao;
                }
                else if (value > 3)
                {
                    Medicina = 3;
                }
                else
                {
                    Medicina = value;
                }
            }
        }

        public int Computacao
        {
            get;
            set
            {
                if (value < 0)
                {
                    Computacao = 0;
                }
                else if (value > Instrucao)
                {
                    value = Instrucao;
                }
                else if (value > 3)
                {
                    Computacao = 3;
                }
                else
                {
                    Computacao = value;
                }
            }
        }

        public int Conhecimento
        {
            get;
            set
            {
                if (value < 0)
                {
                    Conhecimento = 0;
                }
                else if (value > Instrucao)
                {
                    value = Instrucao;
                }
                else if (value > 3)
                {
                    Conhecimento = 3;
                }
                else
                {
                    Conhecimento = value;
                }
            }
        }

        public int Linguistica
        {
            get;
            set
            {
                if (value < 0)
                {
                    Linguistica = 0;
                }
                else if (value > Instrucao)
                {
                    value = Instrucao;
                }
                else if (value > 3)
                {
                    Linguistica = 3;
                }
                else
                {
                    Linguistica = value;
                }
            }
        }

        public int Ocultismo
        {
            get;
            set
            {
                if (value < 0)
                {
                    Ocultismo = 0;
                }
                else if (value > Instrucao)
                {
                    value = Instrucao;
                }
                else if (value > 3)
                {
                    Ocultismo = 3;
                }
                else
                {
                    Ocultismo = value;
                }
            }
        }
        #endregion

        public int Social
        {
            get;
            set
            {
                if (value < 0)
                {
                    Social = 1;
                }
                else if (value > 5)
                {
                    Social = 5;
                }
                else
                {
                    Social = value;
                }
            }
        }

        #region Especializacoes Social

        public int Empatia
        {
            get;
            set
            {
                if (value < 0)
                {
                    Empatia = 0;
                }
                else if (value > Social)
                {
                    value = Social;
                }
                else if (value > 3)
                {
                    Empatia = 3;
                }
                else
                {
                    Empatia = value;
                }
            }
        }

        public int TratoAnimais
        {
            get;
            set
            {
                if (value < 0)
                {
                    TratoAnimais = 0;
                }
                else if (value > Social)
                {
                    value = Social;
                }
                else if (value > 3)
                {
                    TratoAnimais = 3;
                }
                else
                {
                    TratoAnimais = value;
                }
            }
        }

        public int Labia
        {
            get;
            set
            {
                if (value < 0)
                {
                    Labia = 0;
                }
                else if (value > Social)
                {
                    value = Social;
                }
                else if (value > 3)
                {
                    Labia = 3;
                }
                else
                {
                    Labia = value;
                }
            }
        }

        public int Malandragem
        {
            get;
            set
            {
                if (value < 0)
                {
                    Malandragem = 0;
                }
                else if (value > Social)
                {
                    value = Social;
                }
                else if (value > 3)
                {
                    Malandragem = 3;
                }
                else
                {
                    Malandragem = value;
                }
            }
        }

        public int Performance
        {
            get;
            set
            {
                if (value < 0)
                {
                    Performance = 0;
                }
                else if (value > Social)
                {
                    value = Social;
                }
                else if (value > 3)
                {
                    Performance = 3;
                }
                else
                {
                    Performance = value;
                }
            }
        }

        #endregion

        public int Perspicacia
        {
            get;
            set
            {
                if (value < 0)
                {
                    Perspicacia = 1;
                }
                else if (value > 5)
                {
                    Perspicacia = 5;
                }
                else
                {
                    Perspicacia = value;
                }
            }
        }

        #region Especializacoes Perspicacia

        public int Investigacao
        {
            get;
            set
            {
                if (value < 0)
                {
                    Investigacao = 0;
                }
                else if (value > Perspicacia)
                {
                    value = Perspicacia;
                }
                else if (value > 3)
                {
                    Investigacao = 3;
                }
                else
                {
                    Investigacao = value;
                }
            }
        }

        public int Furtividade
        {
            get;
            set
            {
                if (value < 0)
                {
                    Furtividade = 0;
                }
                else if (value > Perspicacia)
                {
                    value = Perspicacia;
                }
                else if (value > 3)
                {
                    Furtividade = 3;
                }
            }
        }
                
        public int Prestidigitacao
        {
            get;
            set
            {
                if (value < 0)
                {
                    Prestidigitacao = 0;
                }
                else if (value > Perspicacia)
                {
                    value = Perspicacia;
                }
                else if (value > 3)
                {
                    Prestidigitacao = 3;
                }
                else
                {
                    Investigacao = value;
                }
            }
        }

        public int Subterfugio
        {
            get;
            set
            {
                if (value < 0)
                {
                    Subterfugio = 0;
                }
                else if (value > Perspicacia)
                {
                    value = Perspicacia;
                }
                else if (value > 3)
                {
                    Subterfugio = 3;
                }
                else
                {
                    Subterfugio = value;
                }
            }
        }
        
        #endregion

        public int HabilitadorSobrenatural1
        {
            get;
            set
            {
                if (value < 0)
                {
                    HabilitadorSobrenatural1 = 1;
                }
                else if (value > 5)
                {
                    HabilitadorSobrenatural1 = 5;
                }
                else
                {
                    HabilitadorSobrenatural1 = value;
                }
            }
        }

        #region Especializacoes HabilitadorSobrenatural1

        public int Especializacao1HabilitadorSobrenatural1
        {
            get;
            set
            {
                if (value < 0)
                {
                    Especializacao1HabilitadorSobrenatural1 = 0;
                }
                else if (value > HabilitadorSobrenatural1)
                {
                    value = HabilitadorSobrenatural1;
                }
                else if (value > 3)
                {
                    Especializacao1HabilitadorSobrenatural1 = 3;
                }
                else
                {
                    Especializacao1HabilitadorSobrenatural1 = value;
                }
            }
        }

        #endregion

        public int HabilitadorSobrenatural2
        {
            get;
            set
            {
                if (value < 0)
                {
                    HabilitadorSobrenatural2 = 1;
                }
                else if (value > 5)
                {
                    HabilitadorSobrenatural2 = 5;
                }
                else
                {
                    HabilitadorSobrenatural2 = value;
                }
            }
        }

        #region Especializacoes HabilitadorSobrenatural2

        #endregion

        public int HabilitadorSobrenatural3
        {
            get;
            set
            {
                if (value < 0)
                {
                    HabilitadorSobrenatural3 = 1;
                }
                else if (value > 5)
                {
                    HabilitadorSobrenatural3 = 5;
                }
                else
                {
                    HabilitadorSobrenatural3 = value;
                }
            }
        }

        #region Especializacoes HabilitadorSobrenatural3

        #endregion

        #endregion

    }
}
