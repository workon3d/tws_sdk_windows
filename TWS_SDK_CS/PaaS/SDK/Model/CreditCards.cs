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
    public partial class CreditCards :  IEquatable<CreditCards>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCards" /> class.
        /// Initializes a new instance of the <see cref="CreditCards" />class.
        /// </summary>
        /// <param name="Contents">Contents.</param>
        /// <param name="Pagination">Pagination.</param>

        public CreditCards(List<CreditCard> Contents = null, Pagination Pagination = null)
        {
            this.Contents = Contents;
            this.Pagination = Pagination;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Contents
        /// </summary>
        [DataMember(Name="contents", EmitDefaultValue=false)]
        public List<CreditCard> Contents { get; set; }
    
        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name="pagination", EmitDefaultValue=false)]
        public Pagination Pagination { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditCards {\n");
            sb.Append("  Contents: ").Append(Contents).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
            
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
            return this.Equals(obj as CreditCards);
        }

        /// <summary>
        /// Returns true if CreditCards instances are equal
        /// </summary>
        /// <param name="other">Instance of CreditCards to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditCards other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Contents == other.Contents ||
                    this.Contents != null &&
                    this.Contents.SequenceEqual(other.Contents)
                ) && 
                (
                    this.Pagination == other.Pagination ||
                    this.Pagination != null &&
                    this.Pagination.Equals(other.Pagination)
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
                
                if (this.Contents != null)
                    hash = hash * 59 + this.Contents.GetHashCode();
                
                if (this.Pagination != null)
                    hash = hash * 59 + this.Pagination.GetHashCode();
                
                return hash;
            }
        }

    }
}
