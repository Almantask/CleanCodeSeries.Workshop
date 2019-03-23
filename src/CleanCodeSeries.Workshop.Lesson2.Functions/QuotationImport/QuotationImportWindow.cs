using System;
using CleanCodeSeries.Workshop.Lesson2.Functions.EventHandlers;

namespace CleanCodeSeries.Workshop.Lesson2.Functions.QuotationImport
{
    class QuotationImportWindow
    {
        private Quotation quotation;

        public QuotationImportWindow(Quotation quotation)
        {
            this.quotation = quotation;
        }

        public void ButtonImportQuotation_OnClick(object sender, EventArgs e)
        {
            ImportQuotation();
        } 

        public void ButtonUpdateQuotation_OnClick(object sender, EventArgs e)
        {
            UpdateQuotation();
        }

        private void ImportQuotation()
        {
            Logger.Log("Import started");
            var importer = new QuotationImporter(new DBContext(), quotation);
            importer.ImportQuotation();
            Logger.Log("Import done");
        }

        private void UpdateQuotation()
        {
            Logger.Log("Import started");
            var importer = new QuotationImporter(new DBContext(), quotation);
            importer.UpdateQuotation();
            Logger.Log("Import done");
        }


    }
}
