using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystem
{
    public class BookProduct : IOrderType
    {
        private string _bookName;

        public List<Client> globalmembers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void PackingSlip()
        {

            Console.WriteLine("Enter the Royalty Team name");
            string royaltyTeamName = Console.ReadLine();
            Console.WriteLine("Enter the Royalty Team email id where the duplicate slip needs to be forwarded");
            string royaltyTeamEmailId = Console.ReadLine();
            DuplicateParkingSlip(royaltyTeamName, royaltyTeamEmailId);
            CommissionPayment();
        }

        private void DuplicateParkingSlip(string royaltydeptname, string royaldeptemailid)
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
                new Address
                {
                    Id = 2, Street = "Electronic City phase1 ", City = "Bangalore", State = "Karnataka", Zip = "560102"
                };

            Console.WriteLine(
                "====================Packing Slip Generated for Book Product with the  Client details====================");
            Console.WriteLine(
                $"{ClientObj.FirstName}\n{ClientObj.LastName}\n{ClientObj.ClientType}\n{ClientObj.Email}\n{ClientObj.Phone}\n{ClientObj.Notes}\n{ClientObj.CompanyName}\n{ClientObj.BillingAddress.Id}\n{ClientObj.BillingAddress.Street}\n{ClientObj.BillingAddress.City}\n{ClientObj.BillingAddress.State}\n{ClientObj.BillingAddress.Zip}");

            Console.WriteLine(
                "====================Duplicate Packing Slip Generated for Royalty Department====================\n");
            Console.WriteLine("Duplicate Packing Slip generated for {0} and forwarded to {1}", royaltydeptname,
                royaldeptemailid);
        }

        public string BookDetails(string bookName)
        {
            if (bookName == String.Empty)
            {
                return "InvalidBookName";
            }
            Console.WriteLine("the book name is {0}", _bookName);
           
            return ("book order Successful: " + bookName);

           
        }


        private void CommissionPayment()
        {
            int commissionAmt = 2000;
            Console.WriteLine("Please provide the commission amount {0} to the agent  ", commissionAmt);
        }

    }

}

