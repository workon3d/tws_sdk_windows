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
    public partial class UpdateLineItemOptionsForMultiple :  IEquatable<UpdateLineItemOptionsForMultiple>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLineItemOptionsForMultiple" /> class.
        /// Initializes a new instance of the <see cref="UpdateLineItemOptionsForMultiple" />class.
        /// </summary>
        /// <param name="LineItemId">LineItemId.</param>
        /// <param name="Quantity">Quantity.</param>
        /// <param name="Description">Description.</param>
        /// <param name="BuildSpec">BuildSpec.</param>
        /// <param name="LeadTimeId">LeadTimeId.</param>
        /// <param name="IsActivated">IsActivated.</param>
        /// <param name="PartId">PartId.</param>
        /// <param name="Part">Part.</param>

        public UpdateLineItemOptionsForMultiple(int? LineItemId = null, int? Quantity = null, string Description = null, BuildSpec BuildSpec = null, int? LeadTimeId = null, bool? IsActivated = null, int? PartId = null, UpdatePartOptions Part = null)
        {
            this.LineItemId = LineItemId;
            this.Quantity = Quantity;
            this.Description = Description;
            this.BuildSpec = BuildSpec;
            this.LeadTimeId = LeadTimeId;
            this.IsActivated = IsActivated;
            this.PartId = PartId;
            this.Part = Part;
            
        }
        
    
        /// <summary>
        /// Gets or Sets LineItemId
        /// </summary>
        [DataMember(Name="line_item_id", EmitDefaultValue=false)]
        public int? LineItemId { get; set; }
    
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }
    
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets BuildSpec
        /// </summary>
        [DataMember(Name="build_spec", EmitDefaultValue=false)]
        public BuildSpec BuildSpec { get; set; }
    
        /// <summary>
        /// Gets or Sets LeadTimeId
        /// </summary>
        [DataMember(Name="lead_time_id", EmitDefaultValue=false)]
        public int? LeadTimeId { get; set; }
    
        /// <summary>
        /// Gets or Sets IsActivated
        /// </summary>
        [DataMember(Name="is_activated", EmitDefaultValue=false)]
        public bool? IsActivated { get; set; }
    
        /// <summary>
        /// Gets or Sets PartId
        /// </summary>
        [DataMember(Name="part_id", EmitDefaultValue=false)]
        public int? PartId { get; set; }
    
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
            sb.Append("class UpdateLineItemOptionsForMultiple {\n");
            sb.Append("  LineItemId: ").Append(LineItemId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  BuildSpec: ").Append(BuildSpec).Append("\n");
            sb.Append("  LeadTimeId: ").Append(LeadTimeId).Append("\n");
            sb.Append("  IsActivated: ").Append(IsActivated).Append("\n");
            sb.Append("  PartId: ").Append(PartId).Append("\n");
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
            return this.Equals(obj as UpdateLineItemOptionsForMultiple);
        }

        /// <summary>
        /// Returns true if UpdateLineItemOptionsForMultiple instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateLineItemOptionsForMultiple to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateLineItemOptionsForMultiple other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LineItemId == other.LineItemId ||
                    this.LineItemId != null &&
                    this.LineItemId.Equals(other.LineItemId)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.BuildSpec == other.BuildSpec ||
                    this.BuildSpec != null &&
                    this.BuildSpec.Equals(other.BuildSpec)
                ) && 
                (
                    this.LeadTimeId == other.LeadTimeId ||
                    this.LeadTimeId != null &&
                    this.LeadTimeId.Equals(other.LeadTimeId)
                ) && 
                (
                    this.IsActivated == other.IsActivated ||
                    this.IsActivated != null &&
                    this.IsActivated.Equals(other.IsActivated)
                ) && 
                (
                    this.PartId == other.PartId ||
                    this.PartId != null &&
                    this.PartId.Equals(other.PartId)
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
                
                if (this.LineItemId != null)
                    hash = hash * 59 + this.LineItemId.GetHashCode();
                
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.BuildSpec != null)
                    hash = hash * 59 + this.BuildSpec.GetHashCode();
                
                if (this.LeadTimeId != null)
                    hash = hash * 59 + this.LeadTimeId.GetHashCode();
                
                if (this.IsActivated != null)
                    hash = hash * 59 + this.IsActivated.GetHashCode();
                
                if (this.PartId != null)
                    hash = hash * 59 + this.PartId.GetHashCode();
                
                if (this.Part != null)
                    hash = hash * 59 + this.Part.GetHashCode();
                
                return hash;
            }
        }

    }
}
