using System;
using CleanCodeSeries.Workshop.Lesson2.Functions.EventHandlers;

namespace CleanCodeSeries.Workshop.Lesson2.Functions.QuotationImport
{
    public class QuotationImporter
    {
        private DBContext _context;
        private Quotation _quotation;

        public QuotationImporter(DBContext context, Quotation quotation)
        {
            _context = context;
            _quotation = quotation;
        }

        public void ImportQuotation()
        {
            _context.StartTransaction();
            try
            {
                ValidateHeader();
                ValidateLines();
                CreateHeader();
                CreateLines();
                _context.CommitTransaction();
            }
            catch
            {
                _context.Rollback();
            }
        }

        public void UpdateQuotation()
        {
            if (ReadHeader())
            {
                _context.StartTransaction();
                try
                {
                    ValidateHeader();
                    ValidateLines();
                    UpdateHeader();
                    UpdateLines();
                    _context.CommitTransaction();
                }
                catch
                {
                    _context.Rollback();
                }
            }
        }

        private bool ReadHeader()
        {
            var table = _context.RunSelect($"select id from Quotation where OrderNumber = {_quotation.Header.OrderCode}");
            return table.Rows.Count > 0;
        }

        private void ValidateHeader()
        {
            if (!_context.Validate(_quotation.Header))
            {
                throw new Exception($"Invalid header {_quotation.Header.OrderCode}");
            }
        }

        private void ValidateLines()
        {
            foreach (var line in _quotation.Lines)
            {
                if (!_context.Validate(line))
                {
                    throw new Exception($"Invalid line {line.LineNumber}");
                }
            }
        }

        private void CreateLines()
        {
            foreach (var line in _quotation.Lines)
            {
                _context.Create(line);
            }
        }

        private void CreateHeader()
        {
            _context.Create(_quotation.Header);
        }

        private void UpdateLines()
        {
            foreach (var line in _quotation.Lines)
            {
                _context.Update(line);
            }
        }

        private void UpdateHeader()
        {
            _context.Update(_quotation.Header);
        }

    }
}
