using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson2.Functions.EventHandlers
{
    public class QuotationImporter
    {
        public DBContext context;

        public QuotationImporter(DBContext context)
        {
            this.context = context;
        }

        public bool ReadHeader(Quotation quotation)
        {
            var table = context.RunSelect($"select id from Quotation where OrderNumber = {quotation.Header.OrderCode}");
            return table.Rows.Count > 0;
        }

        public void ValidateHeader(Quotation quotation)
        {
            if (!context.Validate(quotation.Header))
            {
                throw new Exception($"Invalid header {quotation.Header.OrderCode}");
            }
        }

        public void ValidateLines(Quotation quotation)
        {
            foreach (var line in quotation.Lines)
            {
                if (!context.Validate(line))
                {
                    throw new Exception($"Invalid line {line.LineNumber}");
                }
            }
        }

        public void CreateLines(Quotation quotation)
        {
            foreach (var line in quotation.Lines)
            {
                context.Create(line);
            }
        }

        public void CreateHeader(Quotation quotation)
        {
            context.Create(quotation.Header);
        }

        public void UpdateLines(Quotation quotation)
        {
            foreach (var line in quotation.Lines)
            {
                context.Update(line);
            }
        }

        public void UpdateHeader(Quotation quotation)
        {
            context.Update(quotation.Header);
        }

    }
}
