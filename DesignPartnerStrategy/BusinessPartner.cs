using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartnerStrategy
{
    public class BusinessPartner
    {
        public String CardCode { get; private set; }
        

        public BusinessPartner(String cardCode)
        {
            this.CardCode = cardCode;
        }
    }
}
