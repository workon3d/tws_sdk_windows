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
    public partial class CreateOrderOptions :  IEquatable<CreateOrderOptions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderOptions" /> class.
        /// Initializes a new instance of the <see cref="CreateOrderOptions" />class.
        /// </summary>
        /// <param name="QuoteId">QuoteId.</param>
        /// <param name="BillingAddressId">BillingAddressId.</param>
        /// <param name="ShippingAddressId">ShippingAddressId.</param>
        /// <param name="Payment">Payment.</param>
        /// <param name="Shipping">QuickParts will ship the order with QuickParts courier account if this property is null.</param>

        public CreateOrderOptions(int? QuoteId = null, int? BillingAddressId = null, int? ShippingAddressId = null, Payment Payment = null, Shipping Shipping = null)
        {
            this.QuoteId = QuoteId;
            this.BillingAddressId = BillingAddressId;
            this.ShippingAddressId = ShippingAddressId;
            this.Payment = Payment;
            this.Shipping = Shipping;
            
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrderOptions {\n");
            sb.Append("  QuoteId: ").Append(QuoteId).Append("\n");
            sb.Append("  BillingAddressId: ").Append(BillingAddressId).Append("\n");
            sb.Append("  ShippingAddressId: ").Append(ShippingAddressId).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            
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
            return this.Equals(obj as CreateOrderOptions);
        }

        /// <summary>
        /// Returns true if CreateOrderOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateOrderOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOrderOptions other)
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
                
                return hash;
            }
        }

    }
}
