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
    public partial class LeadTimePrice :  IEquatable<LeadTimePrice>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LeadTimePrice" /> class.
        /// Initializes a new instance of the <see cref="LeadTimePrice" />class.
        /// </summary>
        /// <param name="LeadTimeId">LeadTimeId.</param>
        /// <param name="Price">Price.</param>
        /// <param name="Detail">Detail.</param>

        public LeadTimePrice(int? LeadTimeId = null, double? Price = null, string Detail = null)
        {
            this.LeadTimeId = LeadTimeId;
            this.Price = Price;
            this.Detail = Detail;
            
        }
        
    
        /// <summary>
        /// Gets or Sets LeadTimeId
        /// </summary>
        [DataMember(Name="lead_time_id", EmitDefaultValue=false)]
        public int? LeadTimeId { get; set; }
    
        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double? Price { get; set; }
    
        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public string Detail { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeadTimePrice {\n");
            sb.Append("  LeadTimeId: ").Append(LeadTimeId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            
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
            return this.Equals(obj as LeadTimePrice);
        }

        /// <summary>
        /// Returns true if LeadTimePrice instances are equal
        /// </summary>
        /// <param name="other">Instance of LeadTimePrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeadTimePrice other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LeadTimeId == other.LeadTimeId ||
                    this.LeadTimeId != null &&
                    this.LeadTimeId.Equals(other.LeadTimeId)
                ) && 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.Detail == other.Detail ||
                    this.Detail != null &&
                    this.Detail.Equals(other.Detail)
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
                
                if (this.LeadTimeId != null)
                    hash = hash * 59 + this.LeadTimeId.GetHashCode();
                
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                
                if (this.Detail != null)
                    hash = hash * 59 + this.Detail.GetHashCode();
                
                return hash;
            }
        }

    }
}
