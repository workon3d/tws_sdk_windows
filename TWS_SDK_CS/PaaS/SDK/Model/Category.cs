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
    public partial class Category :  IEquatable<Category>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Category" /> class.
        /// Initializes a new instance of the <see cref="Category" />class.
        /// </summary>
        /// <param name="CategoryId">CategoryId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Resolutions">Resolutions.</param>

        public Category(int? CategoryId = null, string Name = null, List<Resolution> Resolutions = null)
        {
            this.CategoryId = CategoryId;
            this.Name = Name;
            this.Resolutions = Resolutions;
            
        }
        
    
        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name="category_id", EmitDefaultValue=false)]
        public int? CategoryId { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Resolutions
        /// </summary>
        [DataMember(Name="resolutions", EmitDefaultValue=false)]
        public List<Resolution> Resolutions { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Category {\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Resolutions: ").Append(Resolutions).Append("\n");
            
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
            return this.Equals(obj as Category);
        }

        /// <summary>
        /// Returns true if Category instances are equal
        /// </summary>
        /// <param name="other">Instance of Category to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Category other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CategoryId == other.CategoryId ||
                    this.CategoryId != null &&
                    this.CategoryId.Equals(other.CategoryId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Resolutions == other.Resolutions ||
                    this.Resolutions != null &&
                    this.Resolutions.SequenceEqual(other.Resolutions)
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
                
                if (this.CategoryId != null)
                    hash = hash * 59 + this.CategoryId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Resolutions != null)
                    hash = hash * 59 + this.Resolutions.GetHashCode();
                
                return hash;
            }
        }

    }
}
