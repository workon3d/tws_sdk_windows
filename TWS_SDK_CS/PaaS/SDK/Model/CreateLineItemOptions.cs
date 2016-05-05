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
    public partial class CreateLineItemOptions :  IEquatable<CreateLineItemOptions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLineItemOptions" /> class.
        /// Initializes a new instance of the <see cref="CreateLineItemOptions" />class.
        /// </summary>
        /// <param name="PartId">PartId (required).</param>
        /// <param name="Quantity">Quantity (required).</param>
        /// <param name="Description">Description.</param>
        /// <param name="BuildSpec">BuildSpec (required).</param>
        /// <param name="LeadTimeId">LeadTimeId.</param>

        public CreateLineItemOptions(int? PartId = null, int? Quantity = null, string Description = null, BuildSpec BuildSpec = null, int? LeadTimeId = null)
        {
            // to ensure "PartId" is required (not null)
            if (PartId == null)
            {
                throw new InvalidDataException("PartId is a required property for CreateLineItemOptions and cannot be null");
            }
            else
            {
                this.PartId = PartId;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for CreateLineItemOptions and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            // to ensure "BuildSpec" is required (not null)
            if (BuildSpec == null)
            {
                throw new InvalidDataException("BuildSpec is a required property for CreateLineItemOptions and cannot be null");
            }
            else
            {
                this.BuildSpec = BuildSpec;
            }
            this.Description = Description;
            this.LeadTimeId = LeadTimeId;
            
        }
        
    
        /// <summary>
        /// Gets or Sets PartId
        /// </summary>
        [DataMember(Name="part_id", EmitDefaultValue=false)]
        public int? PartId { get; set; }
    
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLineItemOptions {\n");
            sb.Append("  PartId: ").Append(PartId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  BuildSpec: ").Append(BuildSpec).Append("\n");
            sb.Append("  LeadTimeId: ").Append(LeadTimeId).Append("\n");
            
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
            return this.Equals(obj as CreateLineItemOptions);
        }

        /// <summary>
        /// Returns true if CreateLineItemOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateLineItemOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateLineItemOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PartId == other.PartId ||
                    this.PartId != null &&
                    this.PartId.Equals(other.PartId)
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
                
                if (this.PartId != null)
                    hash = hash * 59 + this.PartId.GetHashCode();
                
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.BuildSpec != null)
                    hash = hash * 59 + this.BuildSpec.GetHashCode();
                
                if (this.LeadTimeId != null)
                    hash = hash * 59 + this.LeadTimeId.GetHashCode();
                
                return hash;
            }
        }

    }
}
