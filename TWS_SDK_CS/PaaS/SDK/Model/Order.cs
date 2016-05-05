using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PaaS.SDK.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Order :  IEquatable<Order>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// Initializes a new instance of the <see cref="Order" />class.
        /// </summary>
        /// <param name="QuoteId">QuoteId.</param>
        /// <param name="BillingAddressId">BillingAddressId.</param>
        /// <param name="ShippingAddressId">ShippingAddressId.</param>
        /// <param name="Payment">Payment.</param>
        /// <param name="Shipping">QuickParts will ship the order with QuickParts courier account if this property is null.</param>
        /// <param name="TrackingInfo">is null when the information is not available.</param>
        /// <param name="Pdf">Pdf.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        /// <param name="OrderedAt">OrderedAt.</param>
        /// <param name="Price">Price.</param>
        /// <param name="Status">Status.</param>

        public Order(int? QuoteId = null, int? BillingAddressId = null, int? ShippingAddressId = null, Payment Payment = null, Shipping Shipping = null, Tracking TrackingInfo = null, string Pdf = null, string CreatedAt = null, string UpdatedAt = null, string OrderedAt = null, Price Price = null, string Status = null)
        {
            this.QuoteId = QuoteId;
            this.BillingAddressId = BillingAddressId;
            this.ShippingAddressId = ShippingAddressId;
            this.Payment = Payment;
            this.Shipping = Shipping;
            this.TrackingInfo = TrackingInfo;
            this.Pdf = Pdf;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.OrderedAt = OrderedAt;
            this.Price = Price;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// Gets or Sets QuoteId
        /// </summary>
        [DataMember(Name="quote_id", EmitDefaultValue=false)]
        public int? QuoteId { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingAddressId
        /// </summary>
        [DataMember(Name="billing_address_id", EmitDefaultValue=false)]
        public int? BillingAddressId { get; set; }
    
        /// <summary>
        /// Gets or Sets ShippingAddressId
        /// </summary>
        [DataMember(Name="shipping_address_id", EmitDefaultValue=false)]
        public int? ShippingAddressId { get; set; }
    
        /// <summary>
        /// Gets or Sets Payment
        /// </summary>
        [DataMember(Name="payment", EmitDefaultValue=false)]
        public Payment Payment { get; set; }
    
        /// <summary>
        /// QuickParts will ship the order with QuickParts courier account if this property is null
        /// </summary>
        /// <value>QuickParts will ship the order with QuickParts courier account if this property is null</value>
        [DataMember(Name="shipping", EmitDefaultValue=false)]
        public Shipping Shipping { get; set; }
    
        /// <summary>
        /// is null when the information is not available
        /// </summary>
        /// <value>is null when the information is not available</value>
        [DataMember(Name="tracking_info", EmitDefaultValue=false)]
        public Tracking TrackingInfo { get; set; }
    
        /// <summary>
        /// Gets or Sets Pdf
        /// </summary>
        [DataMember(Name="pdf", EmitDefaultValue=false)]
        public string Pdf { get; set; }
    
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
    
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderedAt
        /// </summary>
        [DataMember(Name="ordered_at", EmitDefaultValue=false)]
        public string OrderedAt { get; set; }
    
        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public Price Price { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  QuoteId: ").Append(QuoteId).Append("\n");
            sb.Append("  BillingAddressId: ").Append(BillingAddressId).Append("\n");
            sb.Append("  ShippingAddressId: ").Append(ShippingAddressId).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  TrackingInfo: ").Append(TrackingInfo).Append("\n");
            sb.Append("  Pdf: ").Append(Pdf).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  OrderedAt: ").Append(OrderedAt).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Order);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="other">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Order other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.QuoteId == other.QuoteId ||
                    this.QuoteId != null &&
                    this.QuoteId.Equals(other.QuoteId)
                ) && 
                (
                    this.BillingAddressId == other.BillingAddressId ||
                    this.BillingAddressId != null &&
                    this.BillingAddressId.Equals(other.BillingAddressId)
                ) && 
                (
                    this.ShippingAddressId == other.ShippingAddressId ||
                    this.ShippingAddressId != null &&
                    this.ShippingAddressId.Equals(other.ShippingAddressId)
                ) && 
                (
                    this.Payment == other.Payment ||
                    this.Payment != null &&
                    this.Payment.Equals(other.Payment)
                ) && 
                (
                    this.Shipping == other.Shipping ||
                    this.Shipping != null &&
                    this.Shipping.Equals(other.Shipping)
                ) && 
                (
                    this.TrackingInfo == other.TrackingInfo ||
                    this.TrackingInfo != null &&
                    this.TrackingInfo.Equals(other.TrackingInfo)
                ) && 
                (
                    this.Pdf == other.Pdf ||
                    this.Pdf != null &&
                    this.Pdf.Equals(other.Pdf)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.OrderedAt == other.OrderedAt ||
                    this.OrderedAt != null &&
                    this.OrderedAt.Equals(other.OrderedAt)
                ) && 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.QuoteId != null)
                    hash = hash * 59 + this.QuoteId.GetHashCode();
                
                if (this.BillingAddressId != null)
                    hash = hash * 59 + this.BillingAddressId.GetHashCode();
                
                if (this.ShippingAddressId != null)
                    hash = hash * 59 + this.ShippingAddressId.GetHashCode();
                
                if (this.Payment != null)
                    hash = hash * 59 + this.Payment.GetHashCode();
                
                if (this.Shipping != null)
                    hash = hash * 59 + this.Shipping.GetHashCode();
                
                if (this.TrackingInfo != null)
                    hash = hash * 59 + this.TrackingInfo.GetHashCode();
                
                if (this.Pdf != null)
                    hash = hash * 59 + this.Pdf.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                
                if (this.OrderedAt != null)
                    hash = hash * 59 + this.OrderedAt.GetHashCode();
                
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
