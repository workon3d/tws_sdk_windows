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
    public partial class CustomColor :  IEquatable<CustomColor>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomColor" /> class.
        /// Initializes a new instance of the <see cref="CustomColor" />class.
        /// </summary>
        /// <param name="ColorId">ColorId.</param>
        /// <param name="FinishId">FinishId.</param>
        /// <param name="CustomColorType">CustomColorType.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Options">Options.</param>

        public CustomColor(int? ColorId = null, int? FinishId = null, int? CustomColorType = null, string Name = null, string Options = null)
        {
            this.ColorId = ColorId;
            this.FinishId = FinishId;
            this.CustomColorType = CustomColorType;
            this.Name = Name;
            this.Options = Options;
            
        }
        
    
        /// <summary>
        /// Gets or Sets ColorId
        /// </summary>
        [DataMember(Name="color_id", EmitDefaultValue=false)]
        public int? ColorId { get; set; }
    
        /// <summary>
        /// Gets or Sets FinishId
        /// </summary>
        [DataMember(Name="finish_id", EmitDefaultValue=false)]
        public int? FinishId { get; set; }
    
        /// <summary>
        /// Gets or Sets CustomColorType
        /// </summary>
        [DataMember(Name="custom_color_type", EmitDefaultValue=false)]
        public int? CustomColorType { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public string Options { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomColor {\n");
            sb.Append("  ColorId: ").Append(ColorId).Append("\n");
            sb.Append("  FinishId: ").Append(FinishId).Append("\n");
            sb.Append("  CustomColorType: ").Append(CustomColorType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            
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
            return this.Equals(obj as CustomColor);
        }

        /// <summary>
        /// Returns true if CustomColor instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomColor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomColor other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ColorId == other.ColorId ||
                    this.ColorId != null &&
                    this.ColorId.Equals(other.ColorId)
                ) && 
                (
                    this.FinishId == other.FinishId ||
                    this.FinishId != null &&
                    this.FinishId.Equals(other.FinishId)
                ) && 
                (
                    this.CustomColorType == other.CustomColorType ||
                    this.CustomColorType != null &&
                    this.CustomColorType.Equals(other.CustomColorType)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.Equals(other.Options)
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
                
                if (this.ColorId != null)
                    hash = hash * 59 + this.ColorId.GetHashCode();
                
                if (this.FinishId != null)
                    hash = hash * 59 + this.FinishId.GetHashCode();
                
                if (this.CustomColorType != null)
                    hash = hash * 59 + this.CustomColorType.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                
                return hash;
            }
        }

    }
}
