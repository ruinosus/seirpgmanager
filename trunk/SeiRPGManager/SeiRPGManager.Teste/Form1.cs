using SeiRPGManager.DAL.Repositorio;
using SeiRPGManager.Entidades.Modelo.ClassesBasicas;
using SeiRPGManager.Entidades.Modelo.ClassesPlanilha;
using SeiRPGManager.Entidades.Modelo.Enum;
using SeiRPGManager.Entidades.Util;
using SeiRPGManager.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SeiRPGManager.Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Raca r = new Raca();

            r.Descricao = "Descrição";
            r.Nome = "Nome";

            SeiRPGManagerDAO<Raca> rDao = new SeiRPGManagerDAO<Raca>();
            rDao.Inserir(r);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = FuncoesSeiRPG.ParadaDados(8, Facilidade.Um, Ajuste.SemAjuste, Ajuste.SemAjuste);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlanilhaNegocios neg = new PlanilhaNegocios();

            XmlDocument p = new XmlDocument();

            p.LoadXml("<?xml version='1.0' encoding='iso-8859-1'?> <Planilha>   <Conceito>     <Nome>Obscurus</Nome>     <Campanha>CAMPANHA</Campanha>     <Personalidade>ABC</Personalidade>     <Raca>     </Raca>     <Ocupacao>     </Ocupacao>     <Estilo>     </Estilo>   </Conceito>   <Atributo>     <Fisico Prioridade=''>       <Forca></Forca>       <Destreza>       </Destreza>       <Resistencia>       </Resistencia>     </Fisico>     <Metal Prioridade=''>       <Intelecto>       </Intelecto>       <Influencia>       </Influencia>       <Percepcao>       </Percepcao>     </Metal>     <Sobrenatural Prioridade=''>       <Vontade>       </Vontade>       <Intuicao>       </Intuicao>       <Imunidade>       </Imunidade>     </Sobrenatural>   </Atributo>   <Habilitador>     <Fisico>       <Atletico Valor=''>         <Salto Requerido='N'>         </Salto>         <Escalada Requerido='N'>         </Escalada>         <Corrida Requerido='N'>         </Corrida>         <Natacao Requerido='S'>         </Natacao>         <Esporte Requerido='N'>         </Esporte>       </Atletico>       <CombateProximo Valor=''>         <CombateDesarmado Requerido='N'>         </CombateDesarmado>         <Evasao Requerido='N'>         </Evasao>         <ArmaBrancaCurta Requerido='N'>         </ArmaBrancaCurta>         <ArmaBrancaMedia Requerido='N'>         </ArmaBrancaMedia>         <ArmaBrancaLonga Requerido='N'>         </ArmaBrancaLonga>       </CombateProximo>       <CombateAfastado Valor=''>         <Armamento Requerido='N'>         </Armamento>         <ArmaImpulso Requerido='N'>         </ArmaImpulso>         <ArmaFogoLeve Requerido='N'>         </ArmaFogoLeve>         <ArmaFogoMedia Requerido='N'>         </ArmaFogoMedia>         <ArmaFogoPesada Requerido='N'>         </ArmaFogoPesada>       </CombateAfastado>     </Fisico>     <Mental>       <Instrucao Valor=''>         <Medicina Requerido='N'>         </Medicina>         <Computacao Requerido='S'>         </Computacao>         <Conhecimento Requerido='S'>         </Conhecimento>         <Linguistica Requerido='S'>         </Linguistica>         <Ocultismo Requerido='N'>         </Ocultismo>       </Instrucao>       <Social Valor=''>         <Empatia Requerido='N'>         </Empatia>         <TratoComAnimais Requerido='N'>         </TratoComAnimais>         <Labia Requerido='N'>         </Labia>         <Malandragem Requerido='S'>         </Malandragem>         <Performance Requerido='N'>         </Performance>       </Social>       <Perspicacia Valor=''>         <Investigacao Requerido='N'>         </Investigacao>         <Furtividade Requerido='N'>         </Furtividade>         <Prestidigitacao Requerido='S'>         </Prestidigitacao>         <Reparo Requerido='N'>         </Reparo>         <Subterfugio Requerido='N'>         </Subterfugio>       </Perspicacia>     </Mental>     <Sobrenatural>       <HabilitadorSobrenatural1 Nome='' Valor=''>         <Especializacao1 Requerido='S'>         </Especializacao1>         <Especializacao2 Requerido='S'>         </Especializacao2>         <Especializacao3 Requerido='S'>         </Especializacao3>         <Especializacao4 Requerido='S'>         </Especializacao4>         <Especializacao5 Requerido='S'>         </Especializacao5>       </HabilitadorSobrenatural1>       <HabilitadorSobrenatural2 Nome='' Valor=''>         <Especializacao1 Requerido='S'>         </Especializacao1>         <Especializacao2 Requerido='S'>         </Especializacao2>         <Especializacao3 Requerido='S'>         </Especializacao3>         <Especializacao4 Requerido='S'>         </Especializacao4>         <Especializacao5 Requerido='S'>         </Especializacao5>       </HabilitadorSobrenatural2>       <HabilitadorSobrenatural3 Nome='' Valor=''>         <Especializacao1 Requerido='S'>         </Especializacao1>         <Especializacao2 Requerido='S'>         </Especializacao2>         <Especializacao3 Requerido='S'>         </Especializacao3>         <Especializacao4 Requerido='S'>         </Especializacao4>         <Especializacao5 Requerido='S'>         </Especializacao5>       </HabilitadorSobrenatural3>     </Sobrenatural>   </Habilitador>   <Talento>     <Slot1 Ajuste=''>     </Slot1>     <Slot2 Ajuste=''>     </Slot2>     <Slot3 Ajuste=''>     </Slot3>     <Slot4 Ajuste=''>     </Slot4>     <Slot5 Ajuste=''>     </Slot5>     <Slot6 Ajuste=''>     </Slot6>     <Slot7 Ajuste=''>     </Slot7>     <Slot8 Ajuste=''>     </Slot8>     <Slot9 Ajuste=''>     </Slot9>     <Slot10 Ajuste=''>     </Slot10>   </Talento>   <Precedente>     <Slot1 Custo=''>     </Slot1>     <Slot2 Custo=''>     </Slot2>     <Slot3 Custo=''>     </Slot3>     <Slot4 Custo=''>     </Slot4>     <Slot5 Custo=''>     </Slot5>     <Slot6 Custo=''>     </Slot6>     <Slot7 Custo=''>     </Slot7>     <Slot8 Custo=''>     </Slot8>     <Slot9 Custo=''>     </Slot9>     <Slot10 Custo=''>     </Slot10>   </Precedente>   <Arma>     <Slot1>       <Tipo>       </Tipo>       <Ajuste>       </Ajuste>       <Tamanho>       </Tamanho>       <Pente>       </Pente>       <Alcance>       </Alcance>     </Slot1>     <Slot2>       <Tipo>       </Tipo>       <Ajuste>       </Ajuste>       <Tamanho>       </Tamanho>       <Pente>       </Pente>       <Alcance>       </Alcance>     </Slot2>     <Slot3>       <Tipo>       </Tipo>       <Ajuste>       </Ajuste>       <Tamanho>       </Tamanho>       <Pente>       </Pente>       <Alcance>       </Alcance>     </Slot3>     <Slot4>       <Tipo>       </Tipo>       <Ajuste>       </Ajuste>       <Tamanho>       </Tamanho>       <Pente>       </Pente>       <Alcance>       </Alcance>     </Slot4>     <Slot5>       <Tipo>       </Tipo>       <Ajuste>       </Ajuste>       <Tamanho>       </Tamanho>       <Pente>       </Pente>       <Alcance>       </Alcance>     </Slot5>   </Arma>   <Equipamento>     <Slot1>       <Item>       </Item>       <Quantidade>       </Quantidade>       <Tamanho>       </Tamanho>     </Slot1>     <Slot2>       <Item>       </Item>       <Quantidade>       </Quantidade>       <Tamanho>       </Tamanho>     </Slot2>     <Slot3>       <Item>       </Item>       <Quantidade>       </Quantidade>       <Tamanho>       </Tamanho>     </Slot3>     <Slot4>       <Item>       </Item>       <Quantidade>       </Quantidade>       <Tamanho>       </Tamanho>     </Slot4>     <Slot5>       <Item>       </Item>       <Quantidade>       </Quantidade>       <Tamanho>       </Tamanho>     </Slot5>   </Equipamento>   <Capacidade>     <DefesaFisica></DefesaFisica>     <DefesaMental></DefesaMental>     <ModificadorIniciativa></ModificadorIniciativa>     <Deslocamento></Deslocamento>     <Carga></Carga>     <IndiceProtecao></IndiceProtecao>     <Subturno></Subturno>   </Capacidade>   <Saude>     <Slot1>       <Estado>       </Estado>       <Penalidade>       </Penalidade>       <Nivel>       </Nivel>     </Slot1>     <Slot2>       <Estado>       </Estado>       <Penalidade>       </Penalidade>       <Nivel>       </Nivel>     </Slot2>     <Slot3>       <Estado>       </Estado>       <Penalidade>       </Penalidade>       <Nivel>       </Nivel>     </Slot3>     <Slot4>       <Estado>       </Estado>       <Penalidade>       </Penalidade>       <Nivel>       </Nivel>     </Slot4>     <Slot5>       <Estado>       </Estado>       <Penalidade>       </Penalidade>       <Nivel>       </Nivel>     </Slot5>   </Saude>   <BarraEnergia>     <Vitalidade>     </Vitalidade>     <EnergiaVital>     </EnergiaVital>     <Corrupcao>     </Corrupcao>   </BarraEnergia>   <Experiencia>     <Atributo>     </Atributo>     <Habilitador>     </Habilitador>     <Precedente>     </Precedente>     <Talento>     </Talento>     <Corrupcao>     </Corrupcao>   </Experiencia> </Planilha>");

            ConceitoPlanilha c = new ConceitoPlanilha();

            c = neg.ObterConceito(p);

            

            c.Nome = "Elbert";
            c.Campanha = "Campanha Alterada";
            c.Personalidade = "Personalidade Alterada";

            textBox1.Text = (neg.AtualizarConceito(p, c)).InnerXml;
        }
    }
}
