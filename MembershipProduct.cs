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
        IOrderType _obj = new MembershipProduct();
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
            _obj.globalmembers.Add(CI);

            return _obj.globalmembers;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        List<Client> GetExistingMembers(string name)
        {
            var member = _obj.globalmembers.Where(x => x.FirstName == name).Select(x=>x).ToList();
            return member;
            
        }

        /// <summary>
        /// ProcessMembership
        /// </summary>
        public void ProcessMembership(string name)
        {
           
            var member=  _obj.globalmembers.Select(x => x.FirstName).ToList();
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
            var member = _obj.globalmembers.Where(x => x.Id == clientId).Select(x => x.MemberShipDate).ToList();
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
