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
    public partial class Shipping :  IEquatable<Shipping>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Shipping" /> class.
        /// Initializes a new instance of the <see cref="Shipping" />class.
        /// </summary>
        /// <param name="CourierId">CourierId.</param>
        /// <param name="AccountNumber">AccountNumber.</param>
        /// <param name="AccountBillingZip">AccountBillingZip.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="MethodId">MethodId.</param>
        /// <param name="OtherMethod">OtherMethod.</param>
        /// <param name="MultipleShipping">MultipleShipping.</param>

        public Shipping(int? CourierId = null, string AccountNumber = null, string AccountBillingZip = null, string Notes = null, int? MethodId = null, string OtherMethod = null, bool? MultipleShipping = null)
        {
            this.CourierId = CourierId;
            this.AccountNumber = AccountNumber;
            this.AccountBillingZip = AccountBillingZip;
            this.Notes = Notes;
            this.MethodId = MethodId;
            this.OtherMethod = OtherMethod;
            this.MultipleShipping = MultipleShipping;
            
        }
        
    
        /// <summary>
        /// Gets or Sets CourierId
        /// </summary>
        [DataMember(Name="courier_id", EmitDefaultValue=false)]
        public int? CourierId { get; set; }
    
        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="account_number", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets AccountBillingZip
        /// </summary>
        [DataMember(Name="account_billing_zip", EmitDefaultValue=false)]
        public string AccountBillingZip { get; set; }
    
        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }
    
        /// <summary>
        /// Gets or Sets MethodId
        /// </summary>
        [DataMember(Name="method_id", EmitDefaultValue=false)]
        public int? MethodId { get; set; }
    
        /// <summary>
        /// Gets or Sets OtherMethod
        /// </summary>
        [DataMember(Name="other_method", EmitDefaultValue=false)]
        public string OtherMethod { get; set; }
    
        /// <summary>
        /// Gets or Sets MultipleShipping
        /// </summary>
        [DataMember(Name="multiple_shipping", EmitDefaultValue=false)]
        public bool? MultipleShipping { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Shipping {\n");
            sb.Append("  CourierId: ").Append(CourierId).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AccountBillingZip: ").Append(AccountBillingZip).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  MethodId: ").Append(MethodId).Append("\n");
            sb.Append("  OtherMethod: ").Append(OtherMethod).Append("\n");
            sb.Append("  MultipleShipping: ").Append(MultipleShipping).Append("\n");
            
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
            return this.Equals(obj as Shipping);
        }

        /// <summary>
        /// Returns true if Shipping instances are equal
        /// </summary>
        /// <param name="other">Instance of Shipping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Shipping other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CourierId == other.CourierId ||
                    this.CourierId != null &&
                    this.CourierId.Equals(other.CourierId)
                ) && 
                (
                    this.AccountNumber == other.AccountNumber ||
                    this.AccountNumber != null &&
                    this.AccountNumber.Equals(other.AccountNumber)
                ) && 
                (
                    this.AccountBillingZip == other.AccountBillingZip ||
                    this.AccountBillingZip != null &&
                    this.AccountBillingZip.Equals(other.AccountBillingZip)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) && 
                (
                    this.MethodId == other.MethodId ||
                    this.MethodId != null &&
                    this.MethodId.Equals(other.MethodId)
                ) && 
                (
                    this.OtherMethod == other.OtherMethod ||
                    this.OtherMethod != null &&
                    this.OtherMethod.Equals(other.OtherMethod)
                ) && 
                (
                    this.MultipleShipping == other.MultipleShipping ||
                    this.MultipleShipping != null &&
                    this.MultipleShipping.Equals(other.MultipleShipping)
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
                
                if (this.CourierId != null)
                    hash = hash * 59 + this.CourierId.GetHashCode();
                
                if (this.AccountNumber != null)
                    hash = hash * 59 + this.AccountNumber.GetHashCode();
                
                if (this.AccountBillingZip != null)
                    hash = hash * 59 + this.AccountBillingZip.GetHashCode();
                
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                
                if (this.MethodId != null)
                    hash = hash * 59 + this.MethodId.GetHashCode();
                
                if (this.OtherMethod != null)
                    hash = hash * 59 + this.OtherMethod.GetHashCode();
                
                if (this.MultipleShipping != null)
                    hash = hash * 59 + this.MultipleShipping.GetHashCode();
                
                return hash;
            }
        }

    }
}
