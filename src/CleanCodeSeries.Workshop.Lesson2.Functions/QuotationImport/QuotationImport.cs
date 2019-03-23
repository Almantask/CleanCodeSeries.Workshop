using System;

namespace CleanCodeSeries.Workshop.Lesson2.Functions.QuotationImport
{
    public class QuotationImporter
    {
        public DBContext context;

        public QuotationImporter(DBContext context)
        {
            this.context = context;
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



    }
}
