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
    public partial class CourierOptions :  IEquatable<CourierOptions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CourierOptions" /> class.
        /// Initializes a new instance of the <see cref="CourierOptions" />class.
        /// </summary>
        /// <param name="CourierId">CourierId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="ShippingMethods">ShippingMethods.</param>
        /// <param name="Error">Error.</param>

        public CourierOptions(int? CourierId = null, string Name = null, List<ShippingMethodOptions> ShippingMethods = null, string Error = null)
        {
            this.CourierId = CourierId;
            this.Name = Name;
            this.ShippingMethods = ShippingMethods;
            this.Error = Error;
            
        }
        
    
        /// <summary>
        /// Gets or Sets CourierId
        /// </summary>
        [DataMember(Name="courier_id", EmitDefaultValue=false)]
        public int? CourierId { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets ShippingMethods
        /// </summary>
        [DataMember(Name="shipping_methods", EmitDefaultValue=false)]
        public List<ShippingMethodOptions> ShippingMethods { get; set; }
    
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CourierOptions {\n");
            sb.Append("  CourierId: ").Append(CourierId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShippingMethods: ").Append(ShippingMethods).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            
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
            return this.Equals(obj as CourierOptions);
        }

        /// <summary>
        /// Returns true if CourierOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of CourierOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CourierOptions other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ShippingMethods == other.ShippingMethods ||
                    this.ShippingMethods != null &&
                    this.ShippingMethods.SequenceEqual(other.ShippingMethods)
                ) && 
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.ShippingMethods != null)
                    hash = hash * 59 + this.ShippingMethods.GetHashCode();
                
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                
                return hash;
            }
        }

    }
}
