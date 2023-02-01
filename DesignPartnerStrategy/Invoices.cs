using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartnerStrategy
{
    public class Invoices : Document
    {
        public String Cadastra(BusinessPartner businessPartner)
        {
            return businessPartner.CardCode;
        }
    }
}
