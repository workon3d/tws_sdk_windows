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
    public partial class Finish :  IEquatable<Finish>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Finish" /> class.
        /// Initializes a new instance of the <see cref="Finish" />class.
        /// </summary>
        /// <param name="FinishId">FinishId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Colors">Colors.</param>

        public Finish(int? FinishId = null, string Name = null, List<Color> Colors = null)
        {
            this.FinishId = FinishId;
            this.Name = Name;
            this.Colors = Colors;
            
        }
        
    
        /// <summary>
        /// Gets or Sets FinishId
        /// </summary>
        [DataMember(Name="finish_id", EmitDefaultValue=false)]
        public int? FinishId { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Colors
        /// </summary>
        [DataMember(Name="colors", EmitDefaultValue=false)]
        public List<Color> Colors { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Finish {\n");
            sb.Append("  FinishId: ").Append(FinishId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Colors: ").Append(Colors).Append("\n");
            
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
            return this.Equals(obj as Finish);
        }

        /// <summary>
        /// Returns true if Finish instances are equal
        /// </summary>
        /// <param name="other">Instance of Finish to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Finish other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FinishId == other.FinishId ||
                    this.FinishId != null &&
                    this.FinishId.Equals(other.FinishId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Colors == other.Colors ||
                    this.Colors != null &&
                    this.Colors.SequenceEqual(other.Colors)
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
                
                if (this.FinishId != null)
                    hash = hash * 59 + this.FinishId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Colors != null)
                    hash = hash * 59 + this.Colors.GetHashCode();
                
                return hash;
            }
        }

    }
}
