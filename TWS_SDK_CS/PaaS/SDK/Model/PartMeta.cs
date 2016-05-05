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
    public partial class PartMeta :  IEquatable<PartMeta>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PartMeta" /> class.
        /// Initializes a new instance of the <see cref="PartMeta" />class.
        /// </summary>
        /// <param name="Geom">Geom.</param>
        /// <param name="Vprint">Vprint.</param>

        public PartMeta(PartMetaGeom Geom = null, PartMetaVPrint Vprint = null)
        {
            this.Geom = Geom;
            this.Vprint = Vprint;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Geom
        /// </summary>
        [DataMember(Name="geom", EmitDefaultValue=false)]
        public PartMetaGeom Geom { get; set; }
    
        /// <summary>
        /// Gets or Sets Vprint
        /// </summary>
        [DataMember(Name="vprint", EmitDefaultValue=false)]
        public PartMetaVPrint Vprint { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartMeta {\n");
            sb.Append("  Geom: ").Append(Geom).Append("\n");
            sb.Append("  Vprint: ").Append(Vprint).Append("\n");
            
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
            return this.Equals(obj as PartMeta);
        }

        /// <summary>
        /// Returns true if PartMeta instances are equal
        /// </summary>
        /// <param name="other">Instance of PartMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartMeta other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Geom == other.Geom ||
                    this.Geom != null &&
                    this.Geom.Equals(other.Geom)
                ) && 
                (
                    this.Vprint == other.Vprint ||
                    this.Vprint != null &&
                    this.Vprint.Equals(other.Vprint)
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
                
                if (this.Geom != null)
                    hash = hash * 59 + this.Geom.GetHashCode();
                
                if (this.Vprint != null)
                    hash = hash * 59 + this.Vprint.GetHashCode();
                
                return hash;
            }
        }

    }
}
