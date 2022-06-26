using DataAccess.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataModel.Repositories
{
    public class FotosRepository
    {
        private readonly BarderDB _context;

        public FotosRepository(BarderDB context)
        {
            this._context = context;
        }

        public void AddFoto(Fotos foto)
        {
            this._context.Fotos.Add(foto);
        }

        public void RemoveFoto(Fotos foto)
        {
            this._context.Fotos.Remove(foto);
        }

        public List<Fotos> GetFotosByUsuario(long id)
        {
            return this._context.Fotos.Where(f => f.UsuarioId == id).ToList();
        }
    }
}
