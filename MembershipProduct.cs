using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystem
{
     public class MembershipProduct : IOrderType
    {
        //List<Client> Members = new List<Client>();

        //IOrderType _obj = null;
        private List<Client>  _globalmembers { get; set; }
        public List<Client> globalmembers
        {
            get
            {
                return _globalmembers;
            }
            set
            {
                _globalmembers = value;
            }
        }
        public MembershipProduct()
        {
            // Initialize here

            this.globalmembers = new List<Client>();
            Client CIObj = new Client();
            CIObj.FirstName = "Aman";
            CIObj.LastName = "Sehgal";
            CIObj.Id = 1;
            CIObj.MemberShipDate = DateTime.Today.AddDays(-2);

            CIObj.ClientType = "Individual";
            CIObj.Email = "sksehgalaman11@gmail.com";
            CIObj.Phone = "9742153369";
            CIObj.Notes = "Test Notes";
            CIObj.CompanyName = "XYZ";
            CIObj.BillingAddress =
                new Address { Id = 1, Street = "Neeladri Road", City = "Bangalore", State = "Karnataka", Zip = "560100" };
            CIObj.MailingAddress =
                new Address { Id = 2, Street = "Electronic City phase1 ", City = "Bangalore", State = "Karnataka", Zip = "560102" };
           this.globalmembers.Add(CIObj);

            Client CIObj2 = new Client();
            CIObj2.FirstName = "ankur";
            CIObj2.LastName = "bhagat";
            CIObj2.Id = 2;
            CIObj2.MemberShipDate = DateTime.Today.AddDays(1);
            CIObj2.ClientType = "Individual";
            CIObj2.Email = "sksehgalaman11@gmail.com";
            CIObj2.Phone = "9742153369";
            CIObj2.Notes = "Test Notes";
            CIObj2.CompanyName = "XYZ";
            CIObj2.BillingAddress =
                new Address { Id = 1, Street = "Neeladri Road", City = "Bangalore", State = "Karnataka", Zip = "560100" };
            CIObj2.MailingAddress =
                new Address { Id = 2, Street = "Electronic City phase1 ", City = "Bangalore", State = "Karnataka", Zip = "560102" };
            _globalmembers.Add(CIObj2);
        }

      
        List<Client> IOrderType.globalmembers { get ; set ; }
        
       

        /// <summary>
        /// NewMember
        /// </summary>
        /// <returns>List<Client></returns>
        public List<Client> NewMember()
        {
            // fill all properties from client class 
            Client CI = new Client();
            CI.FirstName = "Rohit";
            CI.LastName = "Gandhi";
            globalmembers.Add(CI);

            return globalmembers;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        List<Client> GetExistingMembers(string name)
        {
            var member = globalmembers.Where(x => x.FirstName == name).Select(x=>x).ToList();
            return member;
            
        }

        /// <summary>
        /// ProcessMembership
        /// </summary>
        public void ProcessMembership(string name)
        {
           
            var member= globalmembers.Select(x => x.FirstName).ToList();
            if (member.Count > 0)
            {
               var _memberdetails =  GetExistingMembers(name);
               var ischeck = ValidateMembership(_memberdetails[0].Id);
               if (!ischeck)
               {
                   UpgradeMembership();
               }

            }
            else
            {
                NewMember();
            }
        }

        private string UpgradeMembership()
        {
            Console.WriteLine("Membership upgraded");
            return "Membership upgraded";
        }

        bool ValidateMembership(int clientId)
        {
            var member = globalmembers.Where(x => x.Id == clientId).Select(x => x.MemberShipDate).ToList();
            DateTime _curreDateTime = DateTime.Now;
            if (member[0] > _curreDateTime)
            {
                return true; // activation
            }

            else
                return false; // upgrade

        }

        public void PackingSlip()
        {
            throw new NotImplementedException();
        }
        // create two methods , activate 


    }
}
