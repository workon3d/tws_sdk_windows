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
    public partial class PresignFormFields :  IEquatable<PresignFormFields>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PresignFormFields" /> class.
        /// Initializes a new instance of the <see cref="PresignFormFields" />class.
        /// </summary>
        /// <param name="Signature">Signature.</param>
        /// <param name="Secure">Secure.</param>
        /// <param name="AWSAccessKeyId">AWSAccessKeyId.</param>
        /// <param name="Key">Key.</param>
        /// <param name="Policy">Policy.</param>

        public PresignFormFields(string Signature = null, bool? Secure = null, string AWSAccessKeyId = null, string Key = null, string Policy = null)
        {
            this.Signature = Signature;
            this.Secure = Secure;
            this.AWSAccessKeyId = AWSAccessKeyId;
            this.Key = Key;
            this.Policy = Policy;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name="signature", EmitDefaultValue=false)]
        public string Signature { get; set; }
    
        /// <summary>
        /// Gets or Sets Secure
        /// </summary>
        [DataMember(Name="Secure", EmitDefaultValue=false)]
        public bool? Secure { get; set; }
    
        /// <summary>
        /// Gets or Sets AWSAccessKeyId
        /// </summary>
        [DataMember(Name="AWSAccessKeyId", EmitDefaultValue=false)]
        public string AWSAccessKeyId { get; set; }
    
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }
    
        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name="policy", EmitDefaultValue=false)]
        public string Policy { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PresignFormFields {\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Secure: ").Append(Secure).Append("\n");
            sb.Append("  AWSAccessKeyId: ").Append(AWSAccessKeyId).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            
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
            return this.Equals(obj as PresignFormFields);
        }

        /// <summary>
        /// Returns true if PresignFormFields instances are equal
        /// </summary>
        /// <param name="other">Instance of PresignFormFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PresignFormFields other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Signature == other.Signature ||
                    this.Signature != null &&
                    this.Signature.Equals(other.Signature)
                ) && 
                (
                    this.Secure == other.Secure ||
                    this.Secure != null &&
                    this.Secure.Equals(other.Secure)
                ) && 
                (
                    this.AWSAccessKeyId == other.AWSAccessKeyId ||
                    this.AWSAccessKeyId != null &&
                    this.AWSAccessKeyId.Equals(other.AWSAccessKeyId)
                ) && 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.Policy == other.Policy ||
                    this.Policy != null &&
                    this.Policy.Equals(other.Policy)
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
                
                if (this.Signature != null)
                    hash = hash * 59 + this.Signature.GetHashCode();
                
                if (this.Secure != null)
                    hash = hash * 59 + this.Secure.GetHashCode();
                
                if (this.AWSAccessKeyId != null)
                    hash = hash * 59 + this.AWSAccessKeyId.GetHashCode();
                
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                
                if (this.Policy != null)
                    hash = hash * 59 + this.Policy.GetHashCode();
                
                return hash;
            }
        }

    }
}
