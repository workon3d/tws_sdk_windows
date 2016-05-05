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
    public partial class UpdateLineItemsOptions :  IEquatable<UpdateLineItemsOptions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLineItemsOptions" /> class.
        /// Initializes a new instance of the <see cref="UpdateLineItemsOptions" />class.
        /// </summary>
        /// <param name="LineItems">LineItems (required).</param>

        public UpdateLineItemsOptions(List<UpdateLineItemOptionsForMultiple> LineItems = null)
        {
            // to ensure "LineItems" is required (not null)
            if (LineItems == null)
            {
                throw new InvalidDataException("LineItems is a required property for UpdateLineItemsOptions and cannot be null");
            }
            else
            {
                this.LineItems = LineItems;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name="line_items", EmitDefaultValue=false)]
        public List<UpdateLineItemOptionsForMultiple> LineItems { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLineItemsOptions {\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            
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
            return this.Equals(obj as UpdateLineItemsOptions);
        }

        /// <summary>
        /// Returns true if UpdateLineItemsOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateLineItemsOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateLineItemsOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
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
                
                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();
                
                return hash;
            }
        }

    }
}
