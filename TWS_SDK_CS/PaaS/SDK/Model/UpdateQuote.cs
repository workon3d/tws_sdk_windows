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
    public partial class UpdateQuote :  IEquatable<UpdateQuote>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateQuote" /> class.
        /// Initializes a new instance of the <see cref="UpdateQuote" />class.
        /// </summary>
        /// <param name="CustomerNote">CustomerNote.</param>
        /// <param name="AdditionalNote">AdditionalNote.</param>

        public UpdateQuote(string CustomerNote = null, string AdditionalNote = null)
        {
            this.CustomerNote = CustomerNote;
            this.AdditionalNote = AdditionalNote;
            
        }
        
    
        /// <summary>
        /// Gets or Sets CustomerNote
        /// </summary>
        [DataMember(Name="customer_note", EmitDefaultValue=false)]
        public string CustomerNote { get; set; }
    
        /// <summary>
        /// Gets or Sets AdditionalNote
        /// </summary>
        [DataMember(Name="additional_note", EmitDefaultValue=false)]
        public string AdditionalNote { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateQuote {\n");
            sb.Append("  CustomerNote: ").Append(CustomerNote).Append("\n");
            sb.Append("  AdditionalNote: ").Append(AdditionalNote).Append("\n");
            
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
            return this.Equals(obj as UpdateQuote);
        }

        /// <summary>
        /// Returns true if UpdateQuote instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateQuote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateQuote other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CustomerNote == other.CustomerNote ||
                    this.CustomerNote != null &&
                    this.CustomerNote.Equals(other.CustomerNote)
                ) && 
                (
                    this.AdditionalNote == other.AdditionalNote ||
                    this.AdditionalNote != null &&
                    this.AdditionalNote.Equals(other.AdditionalNote)
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
                
                if (this.CustomerNote != null)
                    hash = hash * 59 + this.CustomerNote.GetHashCode();
                
                if (this.AdditionalNote != null)
                    hash = hash * 59 + this.AdditionalNote.GetHashCode();
                
                return hash;
            }
        }

    }
}
