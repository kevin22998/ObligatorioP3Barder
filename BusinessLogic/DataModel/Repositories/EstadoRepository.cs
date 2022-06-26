using DataAccess.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataModel.Repositories
{
    public class EstadoRepository
    {
        private readonly BarderDB _context;

        public EstadoRepository(BarderDB context)
        {
            this._context = context;
        }

        public void AddEstado(Estado estado)
        {
            this._context.Estado.Add(estado);
        }

        public Estado GetEstado(long id)
        {
            return this._context.Estado.FirstOrDefault(e => e.IdEstado == id);
        }

        public void RemoveEstado(Estado estado)
        {
            this._context.Estado.Remove(estado);
        }
    }
}
