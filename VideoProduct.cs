using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystem
{
    class VideoProduct : IOrderType
    {

        /// <summary>
        /// PackingSlip
        /// </summary>
        public  void   PackingSlip()
        {
            VideoDetails("Learning to SKI");
        }

        public string VideoDetails(string vedioname)
        {
            if (vedioname == "Learning to SKI")
            {
                AttachNewVideo();
                GeneratePackingSlip();
                Console.WriteLine("attached the new video as per the result of court decison in 1997");
            }
            GeneratePackingSlip();
            Console.WriteLine("the video name is {0}", vedioname);

            return ("video order Successful: " + vedioname);


        }

        /// <summary>
        /// AttachNewVideo
        /// </summary>
        /// <returns></returns>
        private string AttachNewVideo()
        {
            var vedioname = "FirstAid";
            return vedioname;
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
                new Address { Id = 1, Street = "Neeladri Road", City = "Bangalore", State = "Karnataka", Zip = "560100" };
            ClientObj.MailingAddress =
                new Address { Id = 2, Street = "Electronic City phase1 ", City = "Bangalore", State = "Karnataka", Zip = "560102" };

            Console.WriteLine("====================Packing Slip Generated for video Product with the  Client details====================");
            Console.WriteLine($"{ClientObj.FirstName}\n{ClientObj.LastName}\n{ClientObj.ClientType}\n{ClientObj.Email}\n{ClientObj.Phone}\n{ClientObj.Notes}\n{ClientObj.CompanyName}\n{ClientObj.BillingAddress.Id}\n{ClientObj.BillingAddress.Street}\n{ClientObj.BillingAddress.City}\n{ClientObj.BillingAddress.State}\n{ClientObj.BillingAddress.Zip}");


        }

        public List<Client> globalmembers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
