using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystem
{
   class OrderTypeConcreteCreator : OrderTypeCreator
    {
        public override IOrderType  ProcessOrderType(string type)
        {

            switch (type)
            {
                case "PhysicalProduct": return new PhysicalProduct();
                case "BookProduct": return new BookProduct();
                case "MembershipProduct": return new MembershipProduct();
                case "VideoProduct": return new VideoProduct();

                default: throw new ArgumentException("Invalid type", "type");
            }
        }

    }


}
