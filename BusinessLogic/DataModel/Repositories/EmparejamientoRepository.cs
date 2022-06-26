using DataAccess.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataModel.Repositories
{
    public class EmparejamientoRepository
    {
        private readonly BarderDB _context;

        public EmparejamientoRepository(BarderDB context)
        {
            this._context = context;
        }

        public void AddEmparejamiento(Emparejamiento emparejamiento)
        {
            this._context.Emparejamiento.Add(emparejamiento);
        }

        public void RemoveEmparejamiento(Emparejamiento emparejamiento)
        {
            this._context.Emparejamiento.Remove(emparejamiento);
        }

        public bool ComprobarEleccionMutua(long idusuario, long peleadorelegido)
        {
            return this._context.Emparejamiento.Any(emp => emp.UsuarioId == peleadorelegido && emp.IdPeleadorElegido == idusuario);
        }
    }
}
