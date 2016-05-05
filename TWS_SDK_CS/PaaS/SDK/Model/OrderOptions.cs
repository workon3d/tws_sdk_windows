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
    public partial class OrderOptions :  IEquatable<OrderOptions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderOptions" /> class.
        /// Initializes a new instance of the <see cref="OrderOptions" />class.
        /// </summary>
        /// <param name="Couriers">Couriers.</param>

        public OrderOptions(List<CourierOptions> Couriers = null)
        {
            this.Couriers = Couriers;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Couriers
        /// </summary>
        [DataMember(Name="couriers", EmitDefaultValue=false)]
        public List<CourierOptions> Couriers { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderOptions {\n");
            sb.Append("  Couriers: ").Append(Couriers).Append("\n");
            
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
            return this.Equals(obj as OrderOptions);
        }

        /// <summary>
        /// Returns true if OrderOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Couriers == other.Couriers ||
                    this.Couriers != null &&
                    this.Couriers.SequenceEqual(other.Couriers)
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
                
                if (this.Couriers != null)
                    hash = hash * 59 + this.Couriers.GetHashCode();
                
                return hash;
            }
        }

    }
}
