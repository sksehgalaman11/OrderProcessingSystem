using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystem
{
   abstract class OrderTypeCreator
    {
        public abstract IOrderType ProcessOrderType(string type);
    }
}
