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
    public partial class EmailPreference :  IEquatable<EmailPreference>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailPreference" /> class.
        /// Initializes a new instance of the <see cref="EmailPreference" />class.
        /// </summary>
        /// <param name="EmailPromotion">EmailPromotion.</param>
        /// <param name="NewsLetter">NewsLetter.</param>
        /// <param name="InterestProducts">InterestProducts.</param>

        public EmailPreference(bool? EmailPromotion = null, bool? NewsLetter = null, List<string> InterestProducts = null)
        {
            this.EmailPromotion = EmailPromotion;
            this.NewsLetter = NewsLetter;
            this.InterestProducts = InterestProducts;
            
        }
        
    
        /// <summary>
        /// Gets or Sets EmailPromotion
        /// </summary>
        [DataMember(Name="email_promotion", EmitDefaultValue=false)]
        public bool? EmailPromotion { get; set; }
    
        /// <summary>
        /// Gets or Sets NewsLetter
        /// </summary>
        [DataMember(Name="news_letter", EmitDefaultValue=false)]
        public bool? NewsLetter { get; set; }
    
        /// <summary>
        /// Gets or Sets InterestProducts
        /// </summary>
        [DataMember(Name="interest_products", EmitDefaultValue=false)]
        public List<string> InterestProducts { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailPreference {\n");
            sb.Append("  EmailPromotion: ").Append(EmailPromotion).Append("\n");
            sb.Append("  NewsLetter: ").Append(NewsLetter).Append("\n");
            sb.Append("  InterestProducts: ").Append(InterestProducts).Append("\n");
            
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
            return this.Equals(obj as EmailPreference);
        }

        /// <summary>
        /// Returns true if EmailPreference instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailPreference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailPreference other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EmailPromotion == other.EmailPromotion ||
                    this.EmailPromotion != null &&
                    this.EmailPromotion.Equals(other.EmailPromotion)
                ) && 
                (
                    this.NewsLetter == other.NewsLetter ||
                    this.NewsLetter != null &&
                    this.NewsLetter.Equals(other.NewsLetter)
                ) && 
                (
                    this.InterestProducts == other.InterestProducts ||
                    this.InterestProducts != null &&
                    this.InterestProducts.SequenceEqual(other.InterestProducts)
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
                
                if (this.EmailPromotion != null)
                    hash = hash * 59 + this.EmailPromotion.GetHashCode();
                
                if (this.NewsLetter != null)
                    hash = hash * 59 + this.NewsLetter.GetHashCode();
                
                if (this.InterestProducts != null)
                    hash = hash * 59 + this.InterestProducts.GetHashCode();
                
                return hash;
            }
        }

    }
}
