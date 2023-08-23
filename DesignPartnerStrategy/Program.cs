using System;

namespace DesignPartnerStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IDocument invoices = new Invoices();
            IDocument purchaseInvoices = new PurchaseInvoices();

            BusinessPartner businessPartner = new BusinessPartner("C00001");

            DocumentModel documentModel = new DocumentModel();

            documentModel.Cadastra(businessPartner, invoices);
            documentModel.Cadastra(businessPartner, purchaseInvoices);
        }
    }
}
