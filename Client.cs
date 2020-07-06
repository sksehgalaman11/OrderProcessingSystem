using System;
using System.Collections.Generic;

namespace OrderProcessingSystem.Models
{
    /// <summary>
    ///     Client model
    /// </summary>
    public class Client : Entity<int>
    {
        /// <summary>
        ///     FirstName of client
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        ///     LastName of client
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        ///     Company name
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        ///     Email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        ///     Home or work phone number
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        ///     Contract date. The value can be null if no contract date exits
        /// </summary>
        public DateTime? MemberShipDate { get; set; }

        /// <summary>
        ///     Type of client
        ///     possible values are : Small Business, Individual, Corporation
        /// </summary>
        public string ClientType { get; set; }

        /// <summary>
        ///     Extra notes
        /// </summary>
        public string Notes { get; set; }


        /// <summary>
        ///     Billing Address
        /// </summary>
        public virtual Address BillingAddress { get; set; }

        /// <summary>
        ///     Mailing Address
        /// </summary>
        public virtual Address MailingAddress { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}