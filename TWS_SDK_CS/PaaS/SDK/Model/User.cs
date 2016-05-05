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
    public partial class User :  IEquatable<User>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// Initializes a new instance of the <see cref="User" />class.
        /// </summary>
        /// <param name="UserId">UserId.</param>
        /// <param name="Buid">Buid.</param>
        /// <param name="IsActivated">IsActivated.</param>
        /// <param name="Email">Email.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="MiddleName">MiddleName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="PhoneExt">PhoneExt.</param>
        /// <param name="Mobile">Mobile.</param>
        /// <param name="Fax">Fax.</param>
        /// <param name="CompanyName">CompanyName.</param>
        /// <param name="Addresses">Addresses.</param>
        /// <param name="Shipping">Shipping.</param>
        /// <param name="EmailPreferences">EmailPreferences.</param>

        public User(int? UserId = null, int? Buid = null, bool? IsActivated = null, string Email = null, string FirstName = null, string MiddleName = null, string LastName = null, string Phone = null, string PhoneExt = null, string Mobile = null, string Fax = null, string CompanyName = null, List<Address> Addresses = null, Shipping Shipping = null, EmailPreference EmailPreferences = null)
        {
            this.UserId = UserId;
            this.Buid = Buid;
            this.IsActivated = IsActivated;
            this.Email = Email;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.PhoneExt = PhoneExt;
            this.Mobile = Mobile;
            this.Fax = Fax;
            this.CompanyName = CompanyName;
            this.Addresses = Addresses;
            this.Shipping = Shipping;
            this.EmailPreferences = EmailPreferences;
            
        }
        
    
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }
    
        /// <summary>
        /// Gets or Sets Buid
        /// </summary>
        [DataMember(Name="buid", EmitDefaultValue=false)]
        public int? Buid { get; set; }
    
        /// <summary>
        /// Gets or Sets IsActivated
        /// </summary>
        [DataMember(Name="is_activated", EmitDefaultValue=false)]
        public bool? IsActivated { get; set; }
    
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }
    
        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name="middle_name", EmitDefaultValue=false)]
        public string MiddleName { get; set; }
    
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }
    
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
    
        /// <summary>
        /// Gets or Sets PhoneExt
        /// </summary>
        [DataMember(Name="phone_ext", EmitDefaultValue=false)]
        public string PhoneExt { get; set; }
    
        /// <summary>
        /// Gets or Sets Mobile
        /// </summary>
        [DataMember(Name="mobile", EmitDefaultValue=false)]
        public string Mobile { get; set; }
    
        /// <summary>
        /// Gets or Sets Fax
        /// </summary>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }
    
        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="company_name", EmitDefaultValue=false)]
        public string CompanyName { get; set; }
    
        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<Address> Addresses { get; set; }
    
        /// <summary>
        /// Gets or Sets Shipping
        /// </summary>
        [DataMember(Name="shipping", EmitDefaultValue=false)]
        public Shipping Shipping { get; set; }
    
        /// <summary>
        /// Gets or Sets EmailPreferences
        /// </summary>
        [DataMember(Name="email_preferences", EmitDefaultValue=false)]
        public EmailPreference EmailPreferences { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Buid: ").Append(Buid).Append("\n");
            sb.Append("  IsActivated: ").Append(IsActivated).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PhoneExt: ").Append(PhoneExt).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  EmailPreferences: ").Append(EmailPreferences).Append("\n");
            
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
            return this.Equals(obj as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="other">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Buid == other.Buid ||
                    this.Buid != null &&
                    this.Buid.Equals(other.Buid)
                ) && 
                (
                    this.IsActivated == other.IsActivated ||
                    this.IsActivated != null &&
                    this.IsActivated.Equals(other.IsActivated)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.MiddleName == other.MiddleName ||
                    this.MiddleName != null &&
                    this.MiddleName.Equals(other.MiddleName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.PhoneExt == other.PhoneExt ||
                    this.PhoneExt != null &&
                    this.PhoneExt.Equals(other.PhoneExt)
                ) && 
                (
                    this.Mobile == other.Mobile ||
                    this.Mobile != null &&
                    this.Mobile.Equals(other.Mobile)
                ) && 
                (
                    this.Fax == other.Fax ||
                    this.Fax != null &&
                    this.Fax.Equals(other.Fax)
                ) && 
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.Equals(other.CompanyName)
                ) && 
                (
                    this.Addresses == other.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(other.Addresses)
                ) && 
                (
                    this.Shipping == other.Shipping ||
                    this.Shipping != null &&
                    this.Shipping.Equals(other.Shipping)
                ) && 
                (
                    this.EmailPreferences == other.EmailPreferences ||
                    this.EmailPreferences != null &&
                    this.EmailPreferences.Equals(other.EmailPreferences)
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
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.Buid != null)
                    hash = hash * 59 + this.Buid.GetHashCode();
                
                if (this.IsActivated != null)
                    hash = hash * 59 + this.IsActivated.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                
                if (this.MiddleName != null)
                    hash = hash * 59 + this.MiddleName.GetHashCode();
                
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                
                if (this.PhoneExt != null)
                    hash = hash * 59 + this.PhoneExt.GetHashCode();
                
                if (this.Mobile != null)
                    hash = hash * 59 + this.Mobile.GetHashCode();
                
                if (this.Fax != null)
                    hash = hash * 59 + this.Fax.GetHashCode();
                
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                
                if (this.Addresses != null)
                    hash = hash * 59 + this.Addresses.GetHashCode();
                
                if (this.Shipping != null)
                    hash = hash * 59 + this.Shipping.GetHashCode();
                
                if (this.EmailPreferences != null)
                    hash = hash * 59 + this.EmailPreferences.GetHashCode();
                
                return hash;
            }
        }

    }
}
