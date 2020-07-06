using OrderProcessingSystem.Models;
using System;
using System.Collections.Generic;

namespace OrderProcessingSystem
{
    class PhysicalProduct : IOrderType
    {
        public List<Client> globalmembers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void PackingSlip()
        {
           GeneratePackingSlip();
           CommissionPayment();

        }

        private void CommissionPayment()
        {
            int commissionAmt = 2000;
            Console.WriteLine("Please provide the commission amount {0} to the agent  ",commissionAmt);
        }

        private void GeneratePackingSlip()
        {
            Client ClientObj = new Client();
            ClientObj.FirstName = "Aman ";
            ClientObj.LastName = "Sehgal";
            ClientObj.ClientType = "Individual";
            ClientObj.Email = "sksehgalaman11@gmail.com";
            ClientObj.Phone = "9742153369";
            ClientObj.Notes = "Test Notes";
            ClientObj.CompanyName = "XYZ";
            ClientObj.BillingAddress =
                new Address {Id = 1, Street = "Neeladri Road", City = "Bangalore", State = "Karnataka", Zip = "560100"};
            ClientObj.MailingAddress =
                new Address {Id = 2, Street = "Electronic City phase1 ", City = "Bangalore", State = "Karnataka", Zip = "560102"};

            Console.WriteLine("====================Packing Slip Generated for Physical Product with the  Client details====================");
            Console.WriteLine($"{ClientObj.FirstName}\n{ClientObj.LastName}\n{ClientObj.ClientType}\n{ClientObj.Email}\n{ClientObj.Phone}\n{ClientObj.Notes}\n{ClientObj.CompanyName}\n{ClientObj.BillingAddress.Id}\n{ClientObj.BillingAddress.Street}\n{ClientObj.BillingAddress.City}\n{ClientObj.BillingAddress.State}\n{ClientObj.BillingAddress.Zip}");

        }

    }
}
