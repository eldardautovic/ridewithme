using System;
using System.Collections.Generic;
using System.Text;

namespace ridewithme.Model.Messages
{
    public class ZalbaActivated
    {
        public Zalbe Zalba { get; set; }

        public List<string> AdminEmails { get; set; }
    }
}
