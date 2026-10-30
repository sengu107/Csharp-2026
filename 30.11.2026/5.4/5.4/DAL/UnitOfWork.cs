using System;
using MySql.Data.MySqlClient;

namespace HotelManagement.DAL
{
   
    public sealed class UnitOfWork : IDisposable
    {
        private readonly MySqlConnection _conn;
        private readonly MySqlTransaction _tran;
        private bool _done;

        public UnitOfWork()
        {
            _conn = DbHelper.CreateConnection();
            _conn.Open();
            _tran = _conn.BeginTransaction();
        }

        internal MySqlTransaction Tran
        {
            get { return _tran; }
        }

        public void Commit()
        {
            _tran.Commit();
            _done = true;
        }

        public void Rollback()
        {
            if (_done) return;
            _tran.Rollback();
            _done = true;
        }

        public void Dispose()
        {
            if (!_done)
            {
                try { _tran.Rollback(); }
                catch (Exception) { }
                _done = true;
            }
            _tran.Dispose();
            _conn.Dispose();
        }
    }
}
