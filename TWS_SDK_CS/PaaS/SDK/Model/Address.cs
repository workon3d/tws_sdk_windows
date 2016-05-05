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
    public partial class Address :  IEquatable<Address>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// Initializes a new instance of the <see cref="Address" />class.
        /// </summary>
        /// <param name="AddressId">not required for creation.</param>
        /// <param name="IsDefault">IsDefault.</param>
        /// <param name="AddressType">Check Get /users/options to see details.</param>
        /// <param name="Attention">Attention.</param>
        /// <param name="City">City.</param>
        /// <param name="CompanyName">CompanyName.</param>
        /// <param name="Country">Country.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="State">State.</param>
        /// <param name="Street1">Street1.</param>
        /// <param name="Street2">Street2.</param>
        /// <param name="Street3">Street3.</param>
        /// <param name="Zip">Zip.</param>

        public Address(int? AddressId = null, bool? IsDefault = null, int? AddressType = null, string Attention = null, string City = null, string CompanyName = null, string Country = null, string Email = null, string Phone = null, string State = null, string Street1 = null, string Street2 = null, string Street3 = null, string Zip = null)
        {
            this.AddressId = AddressId;
            this.IsDefault = IsDefault;
            this.AddressType = AddressType;
            this.Attention = Attention;
            this.City = City;
            this.CompanyName = CompanyName;
            this.Country = Country;
            this.Email = Email;
            this.Phone = Phone;
            this.State = State;
            this.Street1 = Street1;
            this.Street2 = Street2;
            this.Street3 = Street3;
            this.Zip = Zip;
            
        }
        
    
        /// <summary>
        /// not required for creation
        /// </summary>
        /// <value>not required for creation</value>
        [DataMember(Name="address_id", EmitDefaultValue=false)]
        public int? AddressId { get; set; }
    
        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name="is_default", EmitDefaultValue=false)]
        public bool? IsDefault { get; set; }
    
        /// <summary>
        /// Check Get /users/options to see details
        /// </summary>
        /// <value>Check Get /users/options to see details</value>
        [DataMember(Name="address_type", EmitDefaultValue=false)]
        public int? AddressType { get; set; }
    
        /// <summary>
        /// Gets or Sets Attention
        /// </summary>
        [DataMember(Name="attention", EmitDefaultValue=false)]
        public string Attention { get; set; }
    
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
    
        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="company_name", EmitDefaultValue=false)]
        public string CompanyName { get; set; }
    
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
    
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
    
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
    
        /// <summary>
        /// Gets or Sets Street1
        /// </summary>
        [DataMember(Name="street1", EmitDefaultValue=false)]
        public string Street1 { get; set; }
    
        /// <summary>
        /// Gets or Sets Street2
        /// </summary>
        [DataMember(Name="street2", EmitDefaultValue=false)]
        public string Street2 { get; set; }
    
        /// <summary>
        /// Gets or Sets Street3
        /// </summary>
        [DataMember(Name="street3", EmitDefaultValue=false)]
        public string Street3 { get; set; }
    
        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  AddressId: ").Append(AddressId).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
            sb.Append("  Attention: ").Append(Attention).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Street1: ").Append(Street1).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  Street3: ").Append(Street3).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            
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
            return this.Equals(obj as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="other">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AddressId == other.AddressId ||
                    this.AddressId != null &&
                    this.AddressId.Equals(other.AddressId)
                ) && 
                (
                    this.IsDefault == other.IsDefault ||
                    this.IsDefault != null &&
                    this.IsDefault.Equals(other.IsDefault)
                ) && 
                (
                    this.AddressType == other.AddressType ||
                    this.AddressType != null &&
                    this.AddressType.Equals(other.AddressType)
                ) && 
                (
                    this.Attention == other.Attention ||
                    this.Attention != null &&
                    this.Attention.Equals(other.Attention)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.Equals(other.CompanyName)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Street1 == other.Street1 ||
                    this.Street1 != null &&
                    this.Street1.Equals(other.Street1)
                ) && 
                (
                    this.Street2 == other.Street2 ||
                    this.Street2 != null &&
                    this.Street2.Equals(other.Street2)
                ) && 
                (
                    this.Street3 == other.Street3 ||
                    this.Street3 != null &&
                    this.Street3.Equals(other.Street3)
                ) && 
                (
                    this.Zip == other.Zip ||
                    this.Zip != null &&
                    this.Zip.Equals(other.Zip)
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
                
                if (this.AddressId != null)
                    hash = hash * 59 + this.AddressId.GetHashCode();
                
                if (this.IsDefault != null)
                    hash = hash * 59 + this.IsDefault.GetHashCode();
                
                if (this.AddressType != null)
                    hash = hash * 59 + this.AddressType.GetHashCode();
                
                if (this.Attention != null)
                    hash = hash * 59 + this.Attention.GetHashCode();
                
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.Street1 != null)
                    hash = hash * 59 + this.Street1.GetHashCode();
                
                if (this.Street2 != null)
                    hash = hash * 59 + this.Street2.GetHashCode();
                
                if (this.Street3 != null)
                    hash = hash * 59 + this.Street3.GetHashCode();
                
                if (this.Zip != null)
                    hash = hash * 59 + this.Zip.GetHashCode();
                
                return hash;
            }
        }

    }
}
