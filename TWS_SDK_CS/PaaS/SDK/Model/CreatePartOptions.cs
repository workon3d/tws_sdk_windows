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
    public partial class CreatePartOptions :  IEquatable<CreatePartOptions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePartOptions" /> class.
        /// Initializes a new instance of the <see cref="CreatePartOptions" />class.
        /// </summary>
        /// <param name="StorId">stor_id is same as the upload_id which has been given by uploads/presign method (required).</param>
        /// <param name="Name">file name (required).</param>
        /// <param name="Size">file size in bytes (required).</param>

        public CreatePartOptions(string StorId = null, string Name = null, int? Size = null)
        {
            // to ensure "StorId" is required (not null)
            if (StorId == null)
            {
                throw new InvalidDataException("StorId is a required property for CreatePartOptions and cannot be null");
            }
            else
            {
                this.StorId = StorId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CreatePartOptions and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Size" is required (not null)
            if (Size == null)
            {
                throw new InvalidDataException("Size is a required property for CreatePartOptions and cannot be null");
            }
            else
            {
                this.Size = Size;
            }
            
        }
        
    
        /// <summary>
        /// stor_id is same as the upload_id which has been given by uploads/presign method
        /// </summary>
        /// <value>stor_id is same as the upload_id which has been given by uploads/presign method</value>
        [DataMember(Name="stor_id", EmitDefaultValue=false)]
        public string StorId { get; set; }
    
        /// <summary>
        /// file name
        /// </summary>
        /// <value>file name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// file size in bytes
        /// </summary>
        /// <value>file size in bytes</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePartOptions {\n");
            sb.Append("  StorId: ").Append(StorId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            
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
            return this.Equals(obj as CreatePartOptions);
        }

        /// <summary>
        /// Returns true if CreatePartOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of CreatePartOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePartOptions other)
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
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
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
                
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                
                return hash;
            }
        }

    }
}
