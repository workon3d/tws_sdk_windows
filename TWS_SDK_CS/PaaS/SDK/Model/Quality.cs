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
    public partial class Quality :  IEquatable<Quality>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Quality" /> class.
        /// Initializes a new instance of the <see cref="Quality" />class.
        /// </summary>
        /// <param name="QualityId">QualityId.</param>
        /// <param name="Name">Name.</param>

        public Quality(int? QualityId = null, string Name = null)
        {
            this.QualityId = QualityId;
            this.Name = Name;
            
        }
        
    
        /// <summary>
        /// Gets or Sets QualityId
        /// </summary>
        [DataMember(Name="quality_id", EmitDefaultValue=false)]
        public int? QualityId { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quality {\n");
            sb.Append("  QualityId: ").Append(QualityId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            
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
            return this.Equals(obj as Quality);
        }

        /// <summary>
        /// Returns true if Quality instances are equal
        /// </summary>
        /// <param name="other">Instance of Quality to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Quality other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.QualityId == other.QualityId ||
                    this.QualityId != null &&
                    this.QualityId.Equals(other.QualityId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                
                if (this.QualityId != null)
                    hash = hash * 59 + this.QualityId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                return hash;
            }
        }

    }
}
