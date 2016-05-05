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
    public partial class AdditionalBuildSpec :  IEquatable<AdditionalBuildSpec>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalBuildSpec" /> class.
        /// Initializes a new instance of the <see cref="AdditionalBuildSpec" />class.
        /// </summary>
        /// <param name="NumThreadedInserts">NumThreadedInserts.</param>

        public AdditionalBuildSpec(int? NumThreadedInserts = null)
        {
            this.NumThreadedInserts = NumThreadedInserts;
            
        }
        
    
        /// <summary>
        /// Gets or Sets NumThreadedInserts
        /// </summary>
        [DataMember(Name="num_threaded_inserts", EmitDefaultValue=false)]
        public int? NumThreadedInserts { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalBuildSpec {\n");
            sb.Append("  NumThreadedInserts: ").Append(NumThreadedInserts).Append("\n");
            
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
            return this.Equals(obj as AdditionalBuildSpec);
        }

        /// <summary>
        /// Returns true if AdditionalBuildSpec instances are equal
        /// </summary>
        /// <param name="other">Instance of AdditionalBuildSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalBuildSpec other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NumThreadedInserts == other.NumThreadedInserts ||
                    this.NumThreadedInserts != null &&
                    this.NumThreadedInserts.Equals(other.NumThreadedInserts)
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
                
                if (this.NumThreadedInserts != null)
                    hash = hash * 59 + this.NumThreadedInserts.GetHashCode();
                
                return hash;
            }
        }

    }
}
