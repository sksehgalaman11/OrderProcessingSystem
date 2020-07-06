using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystem
{
    interface IOrderType
    {
        void  PackingSlip();
        List<Client> globalmembers { get; set; }

    }
}
