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
    public partial class CCBillingAddress :  IEquatable<CCBillingAddress>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CCBillingAddress" /> class.
        /// Initializes a new instance of the <see cref="CCBillingAddress" />class.
        /// </summary>
        /// <param name="Address">Address.</param>
        /// <param name="City">City.</param>
        /// <param name="State">State.</param>
        /// <param name="Zip">Zip.</param>
        /// <param name="Country">Country.</param>

        public CCBillingAddress(string Address = null, string City = null, string State = null, string Zip = null, string Country = null)
        {
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.Country = Country;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
    
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
    
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
    
        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }
    
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CCBillingAddress {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            
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
            return this.Equals(obj as CCBillingAddress);
        }

        /// <summary>
        /// Returns true if CCBillingAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of CCBillingAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CCBillingAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Zip == other.Zip ||
                    this.Zip != null &&
                    this.Zip.Equals(other.Zip)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
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
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.Zip != null)
                    hash = hash * 59 + this.Zip.GetHashCode();
                
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                
                return hash;
            }
        }

    }
}
