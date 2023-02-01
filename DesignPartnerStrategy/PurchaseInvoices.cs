using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartnerStrategy
{
    public class PurchaseInvoices : Document
    {
        public String Cadastra(BusinessPartner businessPartner)
        {
            return businessPartner.CardCode;
        }
    }
}
