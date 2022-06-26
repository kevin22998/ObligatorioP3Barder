using BusinessLogic.DataModel.Repositories;
using DataAccess.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataModel
{
    public class UnitOfWork : IDisposable
    {
        protected readonly BarderDB _context;
        protected DbContextTransaction Transaction;

        public UsuarioRepository UsuarioRepository { get; set; }
        public FotosRepository FotosRepository { get; set; }
        public EmparejamientoRepository EmparejamientoRepository { get; set; }
        public EstadoRepository EstadoRepository { get; set; }

        public UnitOfWork()
        {
            this._context = new BarderDB();

            this.UsuarioRepository = new UsuarioRepository(this._context);
            this.FotosRepository = new FotosRepository(this._context);
            this.EmparejamientoRepository = new EmparejamientoRepository(this._context);
            this.EstadoRepository = new EstadoRepository(this._context);
        }

        public void SaveChanges()
        {
            this._context.SaveChanges();
        }

        public void BeginTransaction()
        {
            this.Transaction = this._context.Database.BeginTransaction();
        }

        public void Commit()
        {
            if (this.Transaction != null)
                this.Transaction.Commit();
        }

        public void Rollback()
        {
            if (this.Transaction != null)
                this.Transaction.Rollback();
        }

        public void Dispose()
        {
            if (this.Transaction != null)
                this.Transaction.Dispose();

            this._context.Dispose();
        }
    }
}
