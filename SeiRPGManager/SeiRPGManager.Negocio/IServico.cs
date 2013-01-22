

namespace SeiRPGManager.Negocio
{
    public interface IServico<T, in TBaseCadastroModel>
        where T : Entidade
        where TBaseCadastroModel : EntidadeFormModel<T>
    {
        T Consultar(long id, Carga<T> carga = null);
        void Consultar(TBaseCadastroModel model, long id, Carga<T> carga);
        void Excluir(params long[] ids);
        void Filtrar(FiltrarModel<T> model);
        void Salvar(TBaseCadastroModel model);
        bool BloquearOperacao(long id, string usuarioCorrente);
    }
}
