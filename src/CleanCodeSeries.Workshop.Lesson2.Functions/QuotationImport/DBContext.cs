using System;
using System.Data;

namespace CleanCodeSeries.Workshop.Lesson2.Functions.QuotationImport
{
    public class DBContext
    {
        public void Add(object obj) { }

        public bool Validate(object obj) => true;

        public void Create(object obj){ }

        public void StartTransaction() { }

        public void CommitTransaction() { }

        public void Rollback() { }

        internal DataTable RunSelect(string query)
        {
            return new DataTable();
        }

        internal void Update(QuotationLine line)
        {
            throw new NotImplementedException();
        }

        internal void Update(QuotationHeader header)
        {
            throw new NotImplementedException();
        }
    }
}