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
    public partial class Attachment :  IEquatable<Attachment>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment" /> class.
        /// Initializes a new instance of the <see cref="Attachment" />class.
        /// </summary>
        /// <param name="StorId">StorId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>

        public Attachment(string StorId = null, string Name = null, string Description = null)
        {
            this.StorId = StorId;
            this.Name = Name;
            this.Description = Description;
            
        }
        
    
        /// <summary>
        /// Gets or Sets StorId
        /// </summary>
        [DataMember(Name="stor_id", EmitDefaultValue=false)]
        public string StorId { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attachment {\n");
            sb.Append("  StorId: ").Append(StorId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            
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
            return this.Equals(obj as Attachment);
        }

        /// <summary>
        /// Returns true if Attachment instances are equal
        /// </summary>
        /// <param name="other">Instance of Attachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Attachment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StorId == other.StorId ||
                    this.StorId != null &&
                    this.StorId.Equals(other.StorId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                
                if (this.StorId != null)
                    hash = hash * 59 + this.StorId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                return hash;
            }
        }

    }
}
