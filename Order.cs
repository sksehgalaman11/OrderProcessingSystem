using System;

namespace OrderProcessingSystem.Models
{
    /// <summary>
    ///     Order Model
    /// </summary>
    public class Order : Entity<int>
    {
        /// <summary>
        ///     Client information who has placed the order
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        ///     Order's current stage
        /// </summary>
        public int OrderStageId { get; set; }

        /// <summary>
        ///     Item id whose order is placed.
        ///     Limitation: Each order can contain only 1 item
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// Order Date and Time
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        ///     Shipping Address : -
        ///     Mailing Address of Client
        ///     Billing Address of Client
        /// </summary>
        public string ShippingAddress { get; set; }

        /// <summary>
        ///     Special Instruction if Any
        /// </summary>
        public string SpecialOrderInstructions { get; set; }

        /// <summary>
        ///     Additional Notes if any
        /// </summary>
        public string AdditionalNotes { get; set; }

        /// <summary>
        /// Last updated date time of order
        /// </summary>
        public DateTime LastUpdatedDTTM { get; set; } = DateTime.Now;

        /// <summary>
        ///     Navigational Property: Client
        /// </summary>
        public virtual Client Client { get; set; }

        /// <summary>
        ///     Navigational Property: Item
        /// </summary>
        public virtual Item Item { get; set; }


      
    }
}