using SeiRPGManager.DAL.Repositorio;
using SeiRPGManager.Entidades.Modelo.ClassesBasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeiRPGManager.Negocio
{
    public class SeiRPGManagerNegocios<T> where T: Entidade
    {
        SeiRPGManagerDAO<T> seiRPGManagerDAO = new SeiRPGManagerDAO<T>();

        public void Atualizar<T>(T entidade)
        {
            //seiRPGManagerDAO.Inserir<T>(entidade);
        }
    }
}
