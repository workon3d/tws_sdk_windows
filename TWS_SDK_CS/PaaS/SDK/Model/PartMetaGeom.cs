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
    public partial class PartMetaGeom :  IEquatable<PartMetaGeom>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PartMetaGeom" /> class.
        /// Initializes a new instance of the <see cref="PartMetaGeom" />class.
        /// </summary>
        /// <param name="State">processing, complete or error.</param>

        public PartMetaGeom(string State = null)
        {
            this.State = State;
            
        }
        
    
        /// <summary>
        /// processing, complete or error
        /// </summary>
        /// <value>processing, complete or error</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartMetaGeom {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            
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
            return this.Equals(obj as PartMetaGeom);
        }

        /// <summary>
        /// Returns true if PartMetaGeom instances are equal
        /// </summary>
        /// <param name="other">Instance of PartMetaGeom to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartMetaGeom other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                return hash;
            }
        }

    }
}
