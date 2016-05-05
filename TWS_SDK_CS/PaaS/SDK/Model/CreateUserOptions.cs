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
    public partial class CreateUserOptions :  IEquatable<CreateUserOptions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserOptions" /> class.
        /// Initializes a new instance of the <see cref="CreateUserOptions" />class.
        /// </summary>
        /// <param name="Email">email as login id (required).</param>
        /// <param name="Password">Password (required).</param>
        /// <param name="FirstName">FirstName (required).</param>
        /// <param name="MiddleName">MiddleName.</param>
        /// <param name="LastName">LastName (required).</param>
        /// <param name="Phone">Phone (required).</param>
        /// <param name="PhoneExt">PhoneExt.</param>
        /// <param name="Mobile">Mobile.</param>
        /// <param name="Fax">Fax.</param>
        /// <param name="CompanyName">CompanyName (required).</param>
        /// <param name="Addresses">Addresses.</param>
        /// <param name="Shipping">default shipping preference.</param>
        /// <param name="ReferralTypeId">ReferralTypeId.</param>
        /// <param name="IndustryId">IndustryId.</param>
        /// <param name="InterestId">InterestId.</param>
        /// <param name="ReferralNote">ReferralNote.</param>
        /// <param name="EmailPreferences">EmailPreferences.</param>

        public CreateUserOptions(string Email = null, string Password = null, string FirstName = null, string MiddleName = null, string LastName = null, string Phone = null, string PhoneExt = null, string Mobile = null, string Fax = null, string CompanyName = null, List<Address> Addresses = null, Shipping Shipping = null, int? ReferralTypeId = null, int? IndustryId = null, int? InterestId = null, string ReferralNote = null, EmailPreference EmailPreferences = null)
        {
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for CreateUserOptions and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for CreateUserOptions and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for CreateUserOptions and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for CreateUserOptions and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            // to ensure "Phone" is required (not null)
            if (Phone == null)
            {
                throw new InvalidDataException("Phone is a required property for CreateUserOptions and cannot be null");
            }
            else
            {
                this.Phone = Phone;
            }
            // to ensure "CompanyName" is required (not null)
            if (CompanyName == null)
            {
                throw new InvalidDataException("CompanyName is a required property for CreateUserOptions and cannot be null");
            }
            else
            {
                this.CompanyName = CompanyName;
            }
            this.MiddleName = MiddleName;
            this.PhoneExt = PhoneExt;
            this.Mobile = Mobile;
            this.Fax = Fax;
            this.Addresses = Addresses;
            this.Shipping = Shipping;
            this.ReferralTypeId = ReferralTypeId;
            this.IndustryId = IndustryId;
            this.InterestId = InterestId;
            this.ReferralNote = ReferralNote;
            this.EmailPreferences = EmailPreferences;
            
        }
        
    
        /// <summary>
        /// email as login id
        /// </summary>
        /// <value>email as login id</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
    
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
        /// default shipping preference
        /// </summary>
        /// <value>default shipping preference</value>
        [DataMember(Name="shipping", EmitDefaultValue=false)]
        public Shipping Shipping { get; set; }
    
        /// <summary>
        /// Gets or Sets ReferralTypeId
        /// </summary>
        [DataMember(Name="referral_type_id", EmitDefaultValue=false)]
        public int? ReferralTypeId { get; set; }
    
        /// <summary>
        /// Gets or Sets IndustryId
        /// </summary>
        [DataMember(Name="industry_id", EmitDefaultValue=false)]
        public int? IndustryId { get; set; }
    
        /// <summary>
        /// Gets or Sets InterestId
        /// </summary>
        [DataMember(Name="interest_id", EmitDefaultValue=false)]
        public int? InterestId { get; set; }
    
        /// <summary>
        /// Gets or Sets ReferralNote
        /// </summary>
        [DataMember(Name="referral_note", EmitDefaultValue=false)]
        public string ReferralNote { get; set; }
    
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
            sb.Append("class CreateUserOptions {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            sb.Append("  ReferralTypeId: ").Append(ReferralTypeId).Append("\n");
            sb.Append("  IndustryId: ").Append(IndustryId).Append("\n");
            sb.Append("  InterestId: ").Append(InterestId).Append("\n");
            sb.Append("  ReferralNote: ").Append(ReferralNote).Append("\n");
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
            return this.Equals(obj as CreateUserOptions);
        }

        /// <summary>
        /// Returns true if CreateUserOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateUserOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUserOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
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
                    this.ReferralTypeId == other.ReferralTypeId ||
                    this.ReferralTypeId != null &&
                    this.ReferralTypeId.Equals(other.ReferralTypeId)
                ) && 
                (
                    this.IndustryId == other.IndustryId ||
                    this.IndustryId != null &&
                    this.IndustryId.Equals(other.IndustryId)
                ) && 
                (
                    this.InterestId == other.InterestId ||
                    this.InterestId != null &&
                    this.InterestId.Equals(other.InterestId)
                ) && 
                (
                    this.ReferralNote == other.ReferralNote ||
                    this.ReferralNote != null &&
                    this.ReferralNote.Equals(other.ReferralNote)
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
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                
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
                
                if (this.ReferralTypeId != null)
                    hash = hash * 59 + this.ReferralTypeId.GetHashCode();
                
                if (this.IndustryId != null)
                    hash = hash * 59 + this.IndustryId.GetHashCode();
                
                if (this.InterestId != null)
                    hash = hash * 59 + this.InterestId.GetHashCode();
                
                if (this.ReferralNote != null)
                    hash = hash * 59 + this.ReferralNote.GetHashCode();
                
                if (this.EmailPreferences != null)
                    hash = hash * 59 + this.EmailPreferences.GetHashCode();
                
                return hash;
            }
        }

    }
}
