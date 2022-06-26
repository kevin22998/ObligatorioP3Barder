using DataAccess.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataModel.Repositories
{
    public class UsuarioRepository
    {
        private readonly BarderDB _context;

        public UsuarioRepository(BarderDB context)
        {
            this._context = context;
        }

        public void AddUsuario(Usuario usuario)
        {
            this._context.Usuario.Add(usuario);
        }

        public Usuario GetUsuario(long id)
        {
            return this._context.Usuario.FirstOrDefault(u => u.IdUsuario == id);
        }

        public void RemoveUsuario(Usuario usuario)
        {
            this._context.Usuario.Remove(usuario);
        }
    }
}
