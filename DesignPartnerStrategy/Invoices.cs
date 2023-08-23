using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartnerStrategy
{
    public class Invoices : IDocument
    {
        public String Cadastra(BusinessPartner businessPartner)
        {
            return businessPartner.CardCode;
        }
    }
}
