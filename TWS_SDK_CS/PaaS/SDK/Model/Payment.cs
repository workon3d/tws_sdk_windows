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
    public partial class Payment :  IEquatable<Payment>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// Initializes a new instance of the <see cref="Payment" />class.
        /// </summary>
        /// <param name="CcId">CcId.</param>
        /// <param name="SecurityCode">SecurityCode.</param>
        /// <param name="PoNumber">PoNumber.</param>
        /// <param name="Attachments">Attachments.</param>

        public Payment(int? CcId = null, string SecurityCode = null, string PoNumber = null, List<Attachment> Attachments = null)
        {
            this.CcId = CcId;
            this.SecurityCode = SecurityCode;
            this.PoNumber = PoNumber;
            this.Attachments = Attachments;
            
        }
        
    
        /// <summary>
        /// Gets or Sets CcId
        /// </summary>
        [DataMember(Name="cc_id", EmitDefaultValue=false)]
        public int? CcId { get; set; }
    
        /// <summary>
        /// Gets or Sets SecurityCode
        /// </summary>
        [DataMember(Name="security_code", EmitDefaultValue=false)]
        public string SecurityCode { get; set; }
    
        /// <summary>
        /// Gets or Sets PoNumber
        /// </summary>
        [DataMember(Name="po_number", EmitDefaultValue=false)]
        public string PoNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<Attachment> Attachments { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Payment {\n");
            sb.Append("  CcId: ").Append(CcId).Append("\n");
            sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
            sb.Append("  PoNumber: ").Append(PoNumber).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            
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
            return this.Equals(obj as Payment);
        }

        /// <summary>
        /// Returns true if Payment instances are equal
        /// </summary>
        /// <param name="other">Instance of Payment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payment other)
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
                    this.SecurityCode == other.SecurityCode ||
                    this.SecurityCode != null &&
                    this.SecurityCode.Equals(other.SecurityCode)
                ) && 
                (
                    this.PoNumber == other.PoNumber ||
                    this.PoNumber != null &&
                    this.PoNumber.Equals(other.PoNumber)
                ) && 
                (
                    this.Attachments == other.Attachments ||
                    this.Attachments != null &&
                    this.Attachments.SequenceEqual(other.Attachments)
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
                
                if (this.SecurityCode != null)
                    hash = hash * 59 + this.SecurityCode.GetHashCode();
                
                if (this.PoNumber != null)
                    hash = hash * 59 + this.PoNumber.GetHashCode();
                
                if (this.Attachments != null)
                    hash = hash * 59 + this.Attachments.GetHashCode();
                
                return hash;
            }
        }

    }
}
