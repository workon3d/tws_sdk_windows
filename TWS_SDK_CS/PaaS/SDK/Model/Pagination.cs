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
    public partial class Pagination :  IEquatable<Pagination>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Pagination" /> class.
        /// Initializes a new instance of the <see cref="Pagination" />class.
        /// </summary>
        /// <param name="Total">Total.</param>
        /// <param name="PerPage">PerPage.</param>
        /// <param name="NumPages">NumPages.</param>
        /// <param name="CurrentPage">CurrentPage.</param>

        public Pagination(int? Total = null, int? PerPage = null, int? NumPages = null, int? CurrentPage = null)
        {
            this.Total = Total;
            this.PerPage = PerPage;
            this.NumPages = NumPages;
            this.CurrentPage = CurrentPage;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }
    
        /// <summary>
        /// Gets or Sets PerPage
        /// </summary>
        [DataMember(Name="per_page", EmitDefaultValue=false)]
        public int? PerPage { get; set; }
    
        /// <summary>
        /// Gets or Sets NumPages
        /// </summary>
        [DataMember(Name="num_pages", EmitDefaultValue=false)]
        public int? NumPages { get; set; }
    
        /// <summary>
        /// Gets or Sets CurrentPage
        /// </summary>
        [DataMember(Name="current_page", EmitDefaultValue=false)]
        public int? CurrentPage { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pagination {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  NumPages: ").Append(NumPages).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            
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
            return this.Equals(obj as Pagination);
        }

        /// <summary>
        /// Returns true if Pagination instances are equal
        /// </summary>
        /// <param name="other">Instance of Pagination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pagination other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.PerPage == other.PerPage ||
                    this.PerPage != null &&
                    this.PerPage.Equals(other.PerPage)
                ) && 
                (
                    this.NumPages == other.NumPages ||
                    this.NumPages != null &&
                    this.NumPages.Equals(other.NumPages)
                ) && 
                (
                    this.CurrentPage == other.CurrentPage ||
                    this.CurrentPage != null &&
                    this.CurrentPage.Equals(other.CurrentPage)
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
                
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                
                if (this.PerPage != null)
                    hash = hash * 59 + this.PerPage.GetHashCode();
                
                if (this.NumPages != null)
                    hash = hash * 59 + this.NumPages.GetHashCode();
                
                if (this.CurrentPage != null)
                    hash = hash * 59 + this.CurrentPage.GetHashCode();
                
                return hash;
            }
        }

    }
}
