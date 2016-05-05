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
    public partial class Sheen :  IEquatable<Sheen>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Sheen" /> class.
        /// Initializes a new instance of the <see cref="Sheen" />class.
        /// </summary>
        /// <param name="SheenId">SheenId.</param>
        /// <param name="Name">Name.</param>

        public Sheen(int? SheenId = null, string Name = null)
        {
            this.SheenId = SheenId;
            this.Name = Name;
            
        }
        
    
        /// <summary>
        /// Gets or Sets SheenId
        /// </summary>
        [DataMember(Name="sheen_id", EmitDefaultValue=false)]
        public int? SheenId { get; set; }
    
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
            sb.Append("class Sheen {\n");
            sb.Append("  SheenId: ").Append(SheenId).Append("\n");
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
            return this.Equals(obj as Sheen);
        }

        /// <summary>
        /// Returns true if Sheen instances are equal
        /// </summary>
        /// <param name="other">Instance of Sheen to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sheen other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SheenId == other.SheenId ||
                    this.SheenId != null &&
                    this.SheenId.Equals(other.SheenId)
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
                
                if (this.SheenId != null)
                    hash = hash * 59 + this.SheenId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                return hash;
            }
        }

    }
}
