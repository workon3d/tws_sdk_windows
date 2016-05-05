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
    public partial class Resolution :  IEquatable<Resolution>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Resolution" /> class.
        /// Initializes a new instance of the <see cref="Resolution" />class.
        /// </summary>
        /// <param name="MaterialId">MaterialId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="ResolutionId">ResolutionId.</param>

        public Resolution(int? MaterialId = null, string Name = null, int? ResolutionId = null)
        {
            this.MaterialId = MaterialId;
            this.Name = Name;
            this.ResolutionId = ResolutionId;
            
        }
        
    
        /// <summary>
        /// Gets or Sets MaterialId
        /// </summary>
        [DataMember(Name="material_id", EmitDefaultValue=false)]
        public int? MaterialId { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets ResolutionId
        /// </summary>
        [DataMember(Name="resolution_id", EmitDefaultValue=false)]
        public int? ResolutionId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Resolution {\n");
            sb.Append("  MaterialId: ").Append(MaterialId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ResolutionId: ").Append(ResolutionId).Append("\n");
            
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
            return this.Equals(obj as Resolution);
        }

        /// <summary>
        /// Returns true if Resolution instances are equal
        /// </summary>
        /// <param name="other">Instance of Resolution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Resolution other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MaterialId == other.MaterialId ||
                    this.MaterialId != null &&
                    this.MaterialId.Equals(other.MaterialId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ResolutionId == other.ResolutionId ||
                    this.ResolutionId != null &&
                    this.ResolutionId.Equals(other.ResolutionId)
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
                
                if (this.MaterialId != null)
                    hash = hash * 59 + this.MaterialId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.ResolutionId != null)
                    hash = hash * 59 + this.ResolutionId.GetHashCode();
                
                return hash;
            }
        }

    }
}
