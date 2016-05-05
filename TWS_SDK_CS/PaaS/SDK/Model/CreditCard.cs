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
    public partial class CreditCard :  IEquatable<CreditCard>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCard" /> class.
        /// Initializes a new instance of the <see cref="CreditCard" />class.
        /// </summary>
        /// <param name="CcId">CcId.</param>
        /// <param name="CreditcardTypeId">CreditcardTypeId.</param>
        /// <param name="ExpDate">format (YYYY-MM).</param>
        /// <param name="Number">Number.</param>
        /// <param name="NameOnCard">NameOnCard.</param>
        /// <param name="SecurityCode">SecurityCode.</param>
        /// <param name="BillingAddress">BillingAddress.</param>
        /// <param name="IsDefault">IsDefault.</param>

        public CreditCard(int? CcId = null, int? CreditcardTypeId = null, string ExpDate = null, string Number = null, string NameOnCard = null, string SecurityCode = null, CCBillingAddress BillingAddress = null, bool? IsDefault = null)
        {
            this.CcId = CcId;
            this.CreditcardTypeId = CreditcardTypeId;
            this.ExpDate = ExpDate;
            this.Number = Number;
            this.NameOnCard = NameOnCard;
            this.SecurityCode = SecurityCode;
            this.BillingAddress = BillingAddress;
            this.IsDefault = IsDefault;
            
        }
        
    
        /// <summary>
        /// Gets or Sets CcId
        /// </summary>
        [DataMember(Name="cc_id", EmitDefaultValue=false)]
        public int? CcId { get; set; }
    
        /// <summary>
        /// Gets or Sets CreditcardTypeId
        /// </summary>
        [DataMember(Name="creditcard_type_id", EmitDefaultValue=false)]
        public int? CreditcardTypeId { get; set; }
    
        /// <summary>
        /// format (YYYY-MM)
        /// </summary>
        /// <value>format (YYYY-MM)</value>
        [DataMember(Name="exp_date", EmitDefaultValue=false)]
        public string ExpDate { get; set; }
    
        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }
    
        /// <summary>
        /// Gets or Sets NameOnCard
        /// </summary>
        [DataMember(Name="name_on_card", EmitDefaultValue=false)]
        public string NameOnCard { get; set; }
    
        /// <summary>
        /// Gets or Sets SecurityCode
        /// </summary>
        [DataMember(Name="security_code", EmitDefaultValue=false)]
        public string SecurityCode { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="billing_address", EmitDefaultValue=false)]
        public CCBillingAddress BillingAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name="is_default", EmitDefaultValue=false)]
        public bool? IsDefault { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditCard {\n");
            sb.Append("  CcId: ").Append(CcId).Append("\n");
            sb.Append("  CreditcardTypeId: ").Append(CreditcardTypeId).Append("\n");
            sb.Append("  ExpDate: ").Append(ExpDate).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  NameOnCard: ").Append(NameOnCard).Append("\n");
            sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            
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
            return this.Equals(obj as CreditCard);
        }

        /// <summary>
        /// Returns true if CreditCard instances are equal
        /// </summary>
        /// <param name="other">Instance of CreditCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditCard other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CcId == other.CcId ||
                    this.CcId != null &&
                    this.CcId.Equals(other.CcId)
                ) && 
                (
                    this.CreditcardTypeId == other.CreditcardTypeId ||
                    this.CreditcardTypeId != null &&
                    this.CreditcardTypeId.Equals(other.CreditcardTypeId)
                ) && 
                (
                    this.ExpDate == other.ExpDate ||
                    this.ExpDate != null &&
                    this.ExpDate.Equals(other.ExpDate)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.NameOnCard == other.NameOnCard ||
                    this.NameOnCard != null &&
                    this.NameOnCard.Equals(other.NameOnCard)
                ) && 
                (
                    this.SecurityCode == other.SecurityCode ||
                    this.SecurityCode != null &&
                    this.SecurityCode.Equals(other.SecurityCode)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.IsDefault == other.IsDefault ||
                    this.IsDefault != null &&
                    this.IsDefault.Equals(other.IsDefault)
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
                
                if (this.CcId != null)
                    hash = hash * 59 + this.CcId.GetHashCode();
                
                if (this.CreditcardTypeId != null)
                    hash = hash * 59 + this.CreditcardTypeId.GetHashCode();
                
                if (this.ExpDate != null)
                    hash = hash * 59 + this.ExpDate.GetHashCode();
                
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                
                if (this.NameOnCard != null)
                    hash = hash * 59 + this.NameOnCard.GetHashCode();
                
                if (this.SecurityCode != null)
                    hash = hash * 59 + this.SecurityCode.GetHashCode();
                
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                
                if (this.IsDefault != null)
                    hash = hash * 59 + this.IsDefault.GetHashCode();
                
                return hash;
            }
        }

    }
}
