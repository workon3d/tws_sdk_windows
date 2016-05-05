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
    public partial class GetPriceOptions :  IEquatable<GetPriceOptions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPriceOptions" /> class.
        /// Initializes a new instance of the <see cref="GetPriceOptions" />class.
        /// </summary>
        /// <param name="Quantity">Quantity.</param>
        /// <param name="LeadTimeId">LeadTimeId.</param>
        /// <param name="BuildSpec">BuildSpec.</param>
        /// <param name="Part">Part.</param>

        public GetPriceOptions(int? Quantity = null, int? LeadTimeId = null, BuildSpec BuildSpec = null, UpdatePartOptions Part = null)
        {
            this.Quantity = Quantity;
            this.LeadTimeId = LeadTimeId;
            this.BuildSpec = BuildSpec;
            this.Part = Part;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }
    
        /// <summary>
        /// Gets or Sets LeadTimeId
        /// </summary>
        [DataMember(Name="lead_time_id", EmitDefaultValue=false)]
        public int? LeadTimeId { get; set; }
    
        /// <summary>
        /// Gets or Sets BuildSpec
        /// </summary>
        [DataMember(Name="build_spec", EmitDefaultValue=false)]
        public BuildSpec BuildSpec { get; set; }
    
        /// <summary>
        /// Gets or Sets Part
        /// </summary>
        [DataMember(Name="part", EmitDefaultValue=false)]
        public UpdatePartOptions Part { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetPriceOptions {\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  LeadTimeId: ").Append(LeadTimeId).Append("\n");
            sb.Append("  BuildSpec: ").Append(BuildSpec).Append("\n");
            sb.Append("  Part: ").Append(Part).Append("\n");
            
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
            return this.Equals(obj as GetPriceOptions);
        }

        /// <summary>
        /// Returns true if GetPriceOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of GetPriceOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPriceOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.LeadTimeId == other.LeadTimeId ||
                    this.LeadTimeId != null &&
                    this.LeadTimeId.Equals(other.LeadTimeId)
                ) && 
                (
                    this.BuildSpec == other.BuildSpec ||
                    this.BuildSpec != null &&
                    this.BuildSpec.Equals(other.BuildSpec)
                ) && 
                (
                    this.Part == other.Part ||
                    this.Part != null &&
                    this.Part.Equals(other.Part)
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
                
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                
                if (this.LeadTimeId != null)
                    hash = hash * 59 + this.LeadTimeId.GetHashCode();
                
                if (this.BuildSpec != null)
                    hash = hash * 59 + this.BuildSpec.GetHashCode();
                
                if (this.Part != null)
                    hash = hash * 59 + this.Part.GetHashCode();
                
                return hash;
            }
        }

    }
}
