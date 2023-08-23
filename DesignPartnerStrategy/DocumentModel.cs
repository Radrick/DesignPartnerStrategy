using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartnerStrategy
{
    class DocumentModel
    {
        public void Cadastra(BusinessPartner businessPartner, IDocument document)
        {
            String response = document.Cadastra(businessPartner);
            Console.WriteLine(response);
        }
    }
}
