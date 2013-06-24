using SeiRPGManager.Entidades.Modelo.ClassesBasicas;
using SeiRPGManager.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeiRPGManager.Web.Fachada
{
    public class Fachada
    {
        private static Fachada fachadaSingleton = null;

        #region Atributos da classe
        AgendaNegocio agendaNegocio = new AgendaNegocio();
        AnotacaoNegocio anotacaoNegocio = new AnotacaoNegocio();
        ArmaNegocio armaNegocio = new ArmaNegocio();
        CampanhaNegocio campanhaNegocio = new CampanhaNegocio();
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        EnredoPoolNegocio enredoPoolNegocio = new EnredoPoolNegocio();
        EquipamentoNegocio equipamentoNegocio = new EquipamentoNegocio();
        EspecializacaoNegocio especializacaoNegocio = new EspecializacaoNegocio();
        HabilitadorNegocio habilitadorNegocio = new HabilitadorNegocio();
        JogadorNegocio jogadorNegocio = new JogadorNegocio();
        MensagemNegocio mensagemNegocio = new MensagemNegocio();
        NomePoolNegocio nomePoolNegocio = new NomePoolNegocio();
        OcupacaoNegocio ocupacaoNegocio = new OcupacaoNegocio();
        ParametroNegocio parametroNegocio = new ParametroNegocio();
        PersonagemNegocio personagemNegocio = new PersonagemNegocio();
        PersonalidadeNegocio personalidadeNegocio = new PersonalidadeNegocio();
        PlanilhaNegocio planilhaNegocio = new PlanilhaNegocio();
        PrecedenteNegocio precedenteNegocio = new PrecedenteNegocio();
        PrologoPoolNegocio prologoPoolNegocio = new PrologoPoolNegocio();
        RacaNegocio racaNegocio = new RacaNegocio();
        SistemaNegocio sistemaNegocio = new SistemaNegocio();
        TalentoNegocio talentoNegocio = new TalentoNegocio();
        SaudeNegocio saudeNegocio = new SaudeNegocio();        
        #endregion

        // repare no construtor privado, somente métodos dessa classe pode utiliza-lo (no caso getInstance()  
        private Fachada()
        {
            //algum código aqui  
        }

        // retorna a única instancia  
        public static Fachada ObterInstancia()
        {
            if (fachadaSingleton == null)
            {
                fachadaSingleton = new Fachada();
            }
            return fachadaSingleton;
        }

        #region Métodos Agenda       
        
        public void AtualizarAgenda(Agenda entidadeModificada)
        {
            agendaNegocio.Atualizar<Agenda>(entidadeModificada);
        }

        public void InserirAgenda(Agenda entidadeNova)
        {
            agendaNegocio.Inserir<Agenda>(entidadeNova);
        }

        public void ExcluirAgenda(Agenda entidadeExcluida)
        {
            agendaNegocio.Excluir<Agenda>(entidadeExcluida);
        }

        public List<Agenda> ObterTodasAgendas()
        {
            return agendaNegocio.ObterTodos<Agenda>();
        }

        public Agenda RetornarUmaAgenda(Func<Agenda, bool> filtro)
        {
            return agendaNegocio.ObterUm<Agenda>(filtro);
        }

        public IQueryable<Agenda> PesquisarAgenda(Func<Agenda, bool> filtro)
        {
            return agendaNegocio.Pesquisar<Agenda>(filtro);
        }

        #endregion

        #region Métodos Anotacao
        public void AtualizarAnotacao(Anotacao entidadeModificada)
        {
            saudeNegocio.Atualizar<Anotacao>(entidadeModificada);
        }

        public void InserirAnotacao(Anotacao entidadeNova)
        {
            saudeNegocio.Inserir<Anotacao>(entidadeNova);
        }

        public void ExcluirAnotacao(Anotacao entidadeExcluida)
        {
            saudeNegocio.Excluir<Anotacao>(entidadeExcluida);
        }

        public List<Anotacao> ObterTodasAnotacaos()
        {
            return saudeNegocio.ObterTodos<Anotacao>();
        }

        public Anotacao RetornarUmaAnotacao(Func<Anotacao, bool> filtro)
        {
            return saudeNegocio.ObterUm<Anotacao>(filtro);
        }

        public IQueryable<Anotacao> PesquisarAnotacao(Func<Anotacao, bool> filtro)
        {
            return saudeNegocio.Pesquisar<Anotacao>(filtro);
        }
        #endregion

        #region Métodos Arma

        public void AtualizarArma(Arma entidadeModificada)
        {
            armaNegocio.Atualizar<Arma>(entidadeModificada);
        }

        public void InserirArma(Arma entidadeNova)
        {
            armaNegocio.Inserir<Arma>(entidadeNova);
        }

        public void ExcluirArma(Arma entidadeExcluida)
        {
            armaNegocio.Excluir<Arma>(entidadeExcluida);
        }

        public List<Arma> ObterTodasArmas()
        {
            return armaNegocio.ObterTodos<Arma>();
        }

        public Arma RetornarUmaArma(Func<Arma, bool> filtro)
        {
            return armaNegocio.ObterUm<Arma>(filtro);
        }

        public IQueryable<Arma> PesquisarArma(Func<Arma, bool> filtro)
        {
            return armaNegocio.Pesquisar<Arma>(filtro);
        }

        #endregion

        #region Métodos Campanha

        public void AtualizarCampanha(Campanha entidadeModificada)
        {
            campanhaNegocio.Atualizar<Campanha>(entidadeModificada);
        }

        public void InserirCampanha(Campanha entidadeNova)
        {
            campanhaNegocio.Inserir<Campanha>(entidadeNova);
        }

        public void ExcluirCampanha(Campanha entidadeExcluida)
        {
            campanhaNegocio.Excluir<Campanha>(entidadeExcluida);
        }

        public List<Campanha> ObterTodasCampanhas()
        {
            return campanhaNegocio.ObterTodos<Campanha>();
        }

        public Campanha RetornarUmaCampanha(Func<Campanha, bool> filtro)
        {
            return campanhaNegocio.ObterUm<Campanha>(filtro);
        }

        public IQueryable<Campanha> PesquisarCampanha(Func<Campanha, bool> filtro)
        {
            return campanhaNegocio.Pesquisar<Campanha>(filtro);
        }

        #endregion

        #region Métodos Categoria

        public void AtualizarCategoria(Categoria entidadeModificada)
        {
            categoriaNegocio.Atualizar<Categoria>(entidadeModificada);
        }

        public void InserirCategoria(Categoria entidadeNova)
        {
            categoriaNegocio.Inserir<Categoria>(entidadeNova);
        }

        public void ExcluirCategoria(Categoria entidadeExcluida)
        {
            categoriaNegocio.Excluir<Categoria>(entidadeExcluida);
        }

        public List<Categoria> ObterTodasCategorias()
        {
            return categoriaNegocio.ObterTodos<Categoria>();
        }

        public Categoria RetornarUmaCategoria(Func<Categoria, bool> filtro)
        {
            return categoriaNegocio.ObterUm<Categoria>(filtro);
        }

        public IQueryable<Categoria> PesquisarCategoria(Func<Categoria, bool> filtro)
        {
            return categoriaNegocio.Pesquisar<Categoria>(filtro);
        }

        #endregion

        #region Métodos Enredo

        public void AtualizarEnredo(EnredoPool entidadeModificada)
        {
            enredoPoolNegocio.Atualizar<EnredoPool>(entidadeModificada);
        }

        public void InserirEnredo(EnredoPool entidadeNova)
        {
            enredoPoolNegocio.Inserir<EnredoPool>(entidadeNova);
        }

        public void ExcluirEnredo(EnredoPool entidadeExcluida)
        {
            enredoPoolNegocio.Excluir<EnredoPool>(entidadeExcluida);
        }

        public List<EnredoPool> ObterTodosEnredos()
        {
            return enredoPoolNegocio.ObterTodos<EnredoPool>();
        }

        public EnredoPool RetornarUmEnredo(Func<EnredoPool, bool> filtro)
        {
            return enredoPoolNegocio.ObterUm<EnredoPool>(filtro);
        }

        public IQueryable<EnredoPool> PesquisarEnredo(Func<EnredoPool, bool> filtro)
        {
            return enredoPoolNegocio.Pesquisar<EnredoPool>(filtro);
        }

        #endregion

        #region Métodos Equipamento

        public void AtualizarEquipamento(Equipamento entidadeModificada)
        {
            equipamentoNegocio.Atualizar<Equipamento>(entidadeModificada);
        }

        public void InserirEquipamento(Equipamento entidadeNova)
        {
            equipamentoNegocio.Inserir<Equipamento>(entidadeNova);
        }

        public void ExcluirEquipamento(Equipamento entidadeExcluida)
        {
            equipamentoNegocio.Excluir<Equipamento>(entidadeExcluida);
        }

        public List<Equipamento> ObterTodosEquipamentos()
        {
            return equipamentoNegocio.ObterTodos<Equipamento>();
        }

        public Equipamento RetornarUmEquipamento(Func<Equipamento, bool> filtro)
        {
            return equipamentoNegocio.ObterUm<Equipamento>(filtro);
        }

        public IQueryable<Equipamento> PesquisarEquipamento(Func<Equipamento, bool> filtro)
        {
            return equipamentoNegocio.Pesquisar<Equipamento>(filtro);
        }

        #endregion

        #region Métodos Especializacao

        public void AtualizarEspecializacao(Especializacao entidadeModificada)
        {
            especializacaoNegocio.Atualizar<Especializacao>(entidadeModificada);
        }

        public void InserirEspecializacao(Especializacao entidadeNova)
        {
            especializacaoNegocio.Inserir<Especializacao>(entidadeNova);
        }

        public void ExcluirEspecializacao(Especializacao entidadeExcluida)
        {
            especializacaoNegocio.Excluir<Especializacao>(entidadeExcluida);
        }

        public List<Especializacao> ObterTodasEspecializacoes()
        {
            return especializacaoNegocio.ObterTodos<Especializacao>();
        }

        public Especializacao RetornarUmaEspecializacao(Func<Especializacao, bool> filtro)
        {
            return especializacaoNegocio.ObterUm<Especializacao>(filtro);
        }

        public IQueryable<Especializacao> PesquisarEspecializacao(Func<Especializacao, bool> filtro)
        {
            return especializacaoNegocio.Pesquisar<Especializacao>(filtro);
        }

        #endregion

        #region Métodos Habilitador

        public void AtualizarHabilitador(Habilitador entidadeModificada)
        {
            habilitadorNegocio.Atualizar<Habilitador>(entidadeModificada);
        }

        public void InserirHabilitador(Habilitador entidadeNova)
        {
            habilitadorNegocio.Inserir<Habilitador>(entidadeNova);
        }

        public void ExcluirHabilitador(Habilitador entidadeExcluida)
        {
            habilitadorNegocio.Excluir<Habilitador>(entidadeExcluida);
        }

        public List<Habilitador> ObterTodosHabilitadors()
        {
            return habilitadorNegocio.ObterTodos<Habilitador>();
        }

        public Habilitador RetornarUmHabilitador(Func<Habilitador, bool> filtro)
        {
            return habilitadorNegocio.ObterUm<Habilitador>(filtro);
        }

        public IQueryable<Habilitador> PesquisarHabilitador(Func<Habilitador, bool> filtro)
        {
            return habilitadorNegocio.Pesquisar<Habilitador>(filtro);
        }

        #endregion

        #region Métodos Jogador

        public void AtualizarJogador(Jogador entidadeModificada)
        {
            jogadorNegocio.Atualizar<Jogador>(entidadeModificada);
        }

        public void InserirJogador(Jogador entidadeNova)
        {
            jogadorNegocio.Inserir<Jogador>(entidadeNova);
        }

        public void ExcluirJogador(Jogador entidadeExcluida)
        {
            jogadorNegocio.Excluir<Jogador>(entidadeExcluida);
        }

        public List<Jogador> ObterTodosJogadors()
        {
            return jogadorNegocio.ObterTodos<Jogador>();
        }

        public Jogador RetornarUmJogador(Func<Jogador, bool> filtro)
        {
            return jogadorNegocio.ObterUm<Jogador>(filtro);
        }

        public IQueryable<Jogador> PesquisarJogador(Func<Jogador, bool> filtro)
        {
            return jogadorNegocio.Pesquisar<Jogador>(filtro);
        }

        #endregion

        #region Métodos Mensagem

        public void AtualizarMensagem(Mensagem entidadeModificada)
        {
            mensagemNegocio.Atualizar<Mensagem>(entidadeModificada);
        }

        public void InserirMensagem(Mensagem entidadeNova)
        {
            mensagemNegocio.Inserir<Mensagem>(entidadeNova);
        }

        public void ExcluirMensagem(Mensagem entidadeExcluida)
        {
            mensagemNegocio.Excluir<Mensagem>(entidadeExcluida);
        }

        public List<Mensagem> ObterTodasMensagens()
        {
            return mensagemNegocio.ObterTodos<Mensagem>();
        }

        public Mensagem RetornarUmaMensagem(Func<Mensagem, bool> filtro)
        {
            return mensagemNegocio.ObterUm<Mensagem>(filtro);
        }

        public IQueryable<Mensagem> PesquisarMensagem(Func<Mensagem, bool> filtro)
        {
            return mensagemNegocio.Pesquisar<Mensagem>(filtro);
        }

        #endregion

        #region Métodos NomePool

        public void AtualizarNomePool(NomePool entidadeModificada)
        {
            nomePoolNegocio.Atualizar<NomePool>(entidadeModificada);
        }

        public void InserirNomePool(NomePool entidadeNova)
        {
            nomePoolNegocio.Inserir<NomePool>(entidadeNova);
        }

        public void ExcluirNomePool(NomePool entidadeExcluida)
        {
            nomePoolNegocio.Excluir<NomePool>(entidadeExcluida);
        }

        public List<NomePool> ObterTodosNomePools()
        {
            return nomePoolNegocio.ObterTodos<NomePool>();
        }

        public NomePool RetornarUmNomePool(Func<NomePool, bool> filtro)
        {
            return nomePoolNegocio.ObterUm<NomePool>(filtro);
        }

        public IQueryable<NomePool> PesquisarNomePool(Func<NomePool, bool> filtro)
        {
            return nomePoolNegocio.Pesquisar<NomePool>(filtro);
        }

        #endregion

        #region Métodos Ocupacao

        public void AtualizarOcupacao(Ocupacao entidadeModificada)
        {
            ocupacaoNegocio.Atualizar<Ocupacao>(entidadeModificada);
        }

        public void InserirOcupacao(Ocupacao entidadeNova)
        {
            ocupacaoNegocio.Inserir<Ocupacao>(entidadeNova);
        }

        public void ExcluirOcupacao(Ocupacao entidadeExcluida)
        {
            ocupacaoNegocio.Excluir<Ocupacao>(entidadeExcluida);
        }

        public List<Ocupacao> ObterTodasOcupacoes()
        {
            return ocupacaoNegocio.ObterTodos<Ocupacao>();
        }

        public Ocupacao RetornarUmaOcupacao(Func<Ocupacao, bool> filtro)
        {
            return ocupacaoNegocio.ObterUm<Ocupacao>(filtro);
        }

        public IQueryable<Ocupacao> PesquisarOcupacao(Func<Ocupacao, bool> filtro)
        {
            return ocupacaoNegocio.Pesquisar<Ocupacao>(filtro);
        }

        #endregion

        #region Métodos Parametro

        public void AtualizarParametro(Parametro entidadeModificada)
        {
            parametroNegocio.Atualizar<Parametro>(entidadeModificada);
        }

        public void InserirParametro(Parametro entidadeNova)
        {
            parametroNegocio.Inserir<Parametro>(entidadeNova);
        }

        public void ExcluirParametro(Parametro entidadeExcluida)
        {
            parametroNegocio.Excluir<Parametro>(entidadeExcluida);
        }

        public List<Parametro> ObterTodosParametros()
        {
            return parametroNegocio.ObterTodos<Parametro>();
        }

        public Parametro RetornarUmParametro(Func<Parametro, bool> filtro)
        {
            return parametroNegocio.ObterUm<Parametro>(filtro);
        }

        public IQueryable<Parametro> PesquisarParametro(Func<Parametro, bool> filtro)
        {
            return parametroNegocio.Pesquisar<Parametro>(filtro);
        }

        #endregion

        #region Métodos Personagem

        public void AtualizarPersonagem(Personagem entidadeModificada)
        {
            personagemNegocio.Atualizar<Personagem>(entidadeModificada);
        }

        public void InserirPersonagem(Personagem entidadeNova)
        {
            personagemNegocio.Inserir<Personagem>(entidadeNova);
        }

        public void ExcluirPersonagem(Personagem entidadeExcluida)
        {
            personagemNegocio.Excluir<Personagem>(entidadeExcluida);
        }

        public List<Personagem> ObterTodosPersonagems()
        {
            return personagemNegocio.ObterTodos<Personagem>();
        }

        public Personagem RetornarUmPersonagem(Func<Personagem, bool> filtro)
        {
            return personagemNegocio.ObterUm<Personagem>(filtro);
        }

        public IQueryable<Personagem> PesquisarPersonagem(Func<Personagem, bool> filtro)
        {
            return personagemNegocio.Pesquisar<Personagem>(filtro);
        }

        #endregion

        #region Métodos Planilha

        //public void AtualizarPlanilha(Planilha entidadeModificada)
        //{
        //    planilhaNegocio.Atualizar<Planilha>(entidadeModificada);
        //}

        //public void InserirPlanilha(Planilha entidadeNova)
        //{
        //    planilhaNegocio.Inserir<Planilha>(entidadeNova);
        //}

        //public void ExcluirPlanilha(Planilha entidadeExcluida)
        //{
        //    planilhaNegocio.Excluir<Planilha>(entidadeExcluida);
        //}

        //public List<Planilha> ObterTodasPlanilhas()
        //{
        //    return planilhaNegocio.ObterTodos<Planilha>();
        //}

        //public Planilha RetornarUmaPlanilha(Func<Planilha, bool> filtro)
        //{
        //    return planilhaNegocio.ObterUm<Planilha>(filtro);
        //}

        //public IQueryable<Planilha> PesquisarPlanilha(Func<Planilha, bool> filtro)
        //{
        //    return planilhaNegocio.Pesquisar<Planilha>(filtro);
        //}

        #endregion

        #region Métodos Precedentes

        public void AtualizarPrecedente(Precedente entidadeModificada)
        {
            precedenteNegocio.Atualizar<Precedente>(entidadeModificada);
        }

        public void InserirPrecedente(Precedente entidadeNova)
        {
            precedenteNegocio.Inserir<Precedente>(entidadeNova);
        }

        public void ExcluirPrecedente(Precedente entidadeExcluida)
        {
            precedenteNegocio.Excluir<Precedente>(entidadeExcluida);
        }

        public List<Precedente> ObterTodosPrecedentes()
        {
            return precedenteNegocio.ObterTodos<Precedente>();
        }

        public Precedente RetornarUmPrecedente(Func<Precedente, bool> filtro)
        {
            return precedenteNegocio.ObterUm<Precedente>(filtro);
        }

        public IQueryable<Precedente> PesquisarPrecedente(Func<Precedente, bool> filtro)
        {
            return precedenteNegocio.Pesquisar<Precedente>(filtro);
        }

        #endregion

        #region Métodos PrologoPool

        public void AtualizarPrologoPool(PrologoPool entidadeModificada)
        {
            prologoPoolNegocio.Atualizar<PrologoPool>(entidadeModificada);
        }

        public void InserirPrologoPool(PrologoPool entidadeNova)
        {
            prologoPoolNegocio.Inserir<PrologoPool>(entidadeNova);
        }

        public void ExcluirPrologoPool(PrologoPool entidadeExcluida)
        {
            prologoPoolNegocio.Excluir<PrologoPool>(entidadeExcluida);
        }

        public List<PrologoPool> ObterTodosPrologoPools()
        {
            return prologoPoolNegocio.ObterTodos<PrologoPool>();
        }

        public PrologoPool RetornarUmPrologoPool(Func<PrologoPool, bool> filtro)
        {
            return prologoPoolNegocio.ObterUm<PrologoPool>(filtro);
        }

        public IQueryable<PrologoPool> PesquisarPrologoPool(Func<PrologoPool, bool> filtro)
        {
            return prologoPoolNegocio.Pesquisar<PrologoPool>(filtro);
        }

        #endregion

        #region Métodos Raca

        public void AtualizarRaca(Raca entidadeModificada)
        {
            racaNegocio.Atualizar<Raca>(entidadeModificada);
        }

        public void InserirRaca(Raca entidadeNova)
        {
            racaNegocio.Inserir<Raca>(entidadeNova);
        }

        public void ExcluirRaca(Raca entidadeExcluida)
        {
            racaNegocio.Excluir<Raca>(entidadeExcluida);
        }

        public List<Raca> ObterTodasRacas()
        {
            return racaNegocio.ObterTodos<Raca>();
        }

        public Raca RetornarUmaRaca(Func<Raca, bool> filtro)
        {
            return racaNegocio.ObterUm<Raca>(filtro);
        }

        public IQueryable<Raca> PesquisarRaca(Func<Raca, bool> filtro)
        {
            return racaNegocio.Pesquisar<Raca>(filtro);
        }

        #endregion

        #region Métodos Saude

        public void AtualizarSaude(Saude entidadeModificada)
        {
            saudeNegocio.Atualizar<Saude>(entidadeModificada);
        }

        public void InserirSaude(Saude entidadeNova)
        {
            saudeNegocio.Inserir<Saude>(entidadeNova);
        }

        public void ExcluirSaude(Saude entidadeExcluida)
        {
            saudeNegocio.Excluir<Saude>(entidadeExcluida);
        }

        public List<Saude> ObterTodasSaudes()
        {
            return saudeNegocio.ObterTodos<Saude>();
        }

        public Saude RetornarUmaSaude(Func<Saude, bool> filtro)
        {
            return saudeNegocio.ObterUm<Saude>(filtro);
        }

        public IQueryable<Saude> PesquisarSaude(Func<Saude, bool> filtro)
        {
            return saudeNegocio.Pesquisar<Saude>(filtro);
        }

        #endregion

        #region Métodos Sistema

        public void AtualizarSistema(Sistema entidadeModificada)
        {
            sistemaNegocio.Atualizar<Sistema>(entidadeModificada);
        }

        public void InserirSistema(Sistema entidadeNova)
        {
            sistemaNegocio.Inserir<Sistema>(entidadeNova);
        }

        public void ExcluirSistema(Sistema entidadeExcluida)
        {
            sistemaNegocio.Excluir<Sistema>(entidadeExcluida);
        }

        public List<Sistema> ObterTodosSistemas()
        {
            return sistemaNegocio.ObterTodos<Sistema>();
        }

        public Sistema RetornarUmSistema(Func<Sistema, bool> filtro)
        {
            return sistemaNegocio.ObterUm<Sistema>(filtro);
        }

        public IQueryable<Sistema> PesquisarSistema(Func<Sistema, bool> filtro)
        {
            return sistemaNegocio.Pesquisar<Sistema>(filtro);
        }

        #endregion

        #region Métodos Talento
        public void AtualizarTalento(Talento entidadeModificada)
        {
            talentoNegocio.Atualizar<Talento>(entidadeModificada);
        }

        public void InserirTalento(Talento entidadeNova)
        {
            talentoNegocio.Inserir<Talento>(entidadeNova);
        }

        public void ExcluirTalento(Talento entidadeExcluida)
        {
            talentoNegocio.Excluir<Talento>(entidadeExcluida);
        }

        public List<Talento> ObterTodosTalentos()
        {
            return talentoNegocio.ObterTodos<Talento>();
        }

        public Talento RetornarUmTalento(Func<Talento, bool> filtro)
        {
            return talentoNegocio.ObterUm<Talento>(filtro);
        }

        public IQueryable<Talento> PesquisarTalento(Func<Talento, bool> filtro)
        {
            return talentoNegocio.Pesquisar<Talento>(filtro);
        }


        #endregion

    }  
}