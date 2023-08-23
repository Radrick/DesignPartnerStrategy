using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartnerStrategy
{
    public class PurchaseInvoices : IDocument
    {
        public String Cadastra(BusinessPartner businessPartner)
        {
            return businessPartner.CardCode;
        }
    }
}
