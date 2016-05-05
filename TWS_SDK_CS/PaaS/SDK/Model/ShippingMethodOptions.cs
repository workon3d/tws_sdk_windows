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
    public partial class ShippingMethodOptions :  IEquatable<ShippingMethodOptions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingMethodOptions" /> class.
        /// Initializes a new instance of the <see cref="ShippingMethodOptions" />class.
        /// </summary>
        /// <param name="MethodId">MethodId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Rate">Rate.</param>

        public ShippingMethodOptions(int? MethodId = null, string Name = null, double? Rate = null)
        {
            this.MethodId = MethodId;
            this.Name = Name;
            this.Rate = Rate;
            
        }
        
    
        /// <summary>
        /// Gets or Sets MethodId
        /// </summary>
        [DataMember(Name="method_id", EmitDefaultValue=false)]
        public int? MethodId { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Rate
        /// </summary>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public double? Rate { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShippingMethodOptions {\n");
            sb.Append("  MethodId: ").Append(MethodId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            
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
            return this.Equals(obj as ShippingMethodOptions);
        }

        /// <summary>
        /// Returns true if ShippingMethodOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of ShippingMethodOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingMethodOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MethodId == other.MethodId ||
                    this.MethodId != null &&
                    this.MethodId.Equals(other.MethodId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Rate == other.Rate ||
                    this.Rate != null &&
                    this.Rate.Equals(other.Rate)
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
                
                if (this.MethodId != null)
                    hash = hash * 59 + this.MethodId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Rate != null)
                    hash = hash * 59 + this.Rate.GetHashCode();
                
                return hash;
            }
        }

    }
}
