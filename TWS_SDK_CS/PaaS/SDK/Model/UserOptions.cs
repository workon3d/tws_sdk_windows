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
    public partial class UserOptions :  IEquatable<UserOptions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserOptions" /> class.
        /// Initializes a new instance of the <see cref="UserOptions" />class.
        /// </summary>
        /// <param name="Countries">Countries.</param>
        /// <param name="States">States.</param>
        /// <param name="AddressTypes">AddressTypes.</param>
        /// <param name="ReferralTypes">ReferralTypes.</param>
        /// <param name="IndustryTypes">IndustryTypes.</param>
        /// <param name="InterestTypes">InterestTypes.</param>
        /// <param name="CreditcardTypes">CreditcardTypes.</param>

        public UserOptions(List<Country> Countries = null, List<State> States = null, List<AddressType> AddressTypes = null, List<IdNamePair> ReferralTypes = null, List<IdNamePair> IndustryTypes = null, List<IdNamePair> InterestTypes = null, List<IdNamePair> CreditcardTypes = null)
        {
            this.Countries = Countries;
            this.States = States;
            this.AddressTypes = AddressTypes;
            this.ReferralTypes = ReferralTypes;
            this.IndustryTypes = IndustryTypes;
            this.InterestTypes = InterestTypes;
            this.CreditcardTypes = CreditcardTypes;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Countries
        /// </summary>
        [DataMember(Name="countries", EmitDefaultValue=false)]
        public List<Country> Countries { get; set; }
    
        /// <summary>
        /// Gets or Sets States
        /// </summary>
        [DataMember(Name="states", EmitDefaultValue=false)]
        public List<State> States { get; set; }
    
        /// <summary>
        /// Gets or Sets AddressTypes
        /// </summary>
        [DataMember(Name="address_types", EmitDefaultValue=false)]
        public List<AddressType> AddressTypes { get; set; }
    
        /// <summary>
        /// Gets or Sets ReferralTypes
        /// </summary>
        [DataMember(Name="referral_types", EmitDefaultValue=false)]
        public List<IdNamePair> ReferralTypes { get; set; }
    
        /// <summary>
        /// Gets or Sets IndustryTypes
        /// </summary>
        [DataMember(Name="industry_types", EmitDefaultValue=false)]
        public List<IdNamePair> IndustryTypes { get; set; }
    
        /// <summary>
        /// Gets or Sets InterestTypes
        /// </summary>
        [DataMember(Name="interest_types", EmitDefaultValue=false)]
        public List<IdNamePair> InterestTypes { get; set; }
    
        /// <summary>
        /// Gets or Sets CreditcardTypes
        /// </summary>
        [DataMember(Name="creditcard_types", EmitDefaultValue=false)]
        public List<IdNamePair> CreditcardTypes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserOptions {\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            sb.Append("  AddressTypes: ").Append(AddressTypes).Append("\n");
            sb.Append("  ReferralTypes: ").Append(ReferralTypes).Append("\n");
            sb.Append("  IndustryTypes: ").Append(IndustryTypes).Append("\n");
            sb.Append("  InterestTypes: ").Append(InterestTypes).Append("\n");
            sb.Append("  CreditcardTypes: ").Append(CreditcardTypes).Append("\n");
            
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
            return this.Equals(obj as UserOptions);
        }

        /// <summary>
        /// Returns true if UserOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of UserOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Countries == other.Countries ||
                    this.Countries != null &&
                    this.Countries.SequenceEqual(other.Countries)
                ) && 
                (
                    this.States == other.States ||
                    this.States != null &&
                    this.States.SequenceEqual(other.States)
                ) && 
                (
                    this.AddressTypes == other.AddressTypes ||
                    this.AddressTypes != null &&
                    this.AddressTypes.SequenceEqual(other.AddressTypes)
                ) && 
                (
                    this.ReferralTypes == other.ReferralTypes ||
                    this.ReferralTypes != null &&
                    this.ReferralTypes.SequenceEqual(other.ReferralTypes)
                ) && 
                (
                    this.IndustryTypes == other.IndustryTypes ||
                    this.IndustryTypes != null &&
                    this.IndustryTypes.SequenceEqual(other.IndustryTypes)
                ) && 
                (
                    this.InterestTypes == other.InterestTypes ||
                    this.InterestTypes != null &&
                    this.InterestTypes.SequenceEqual(other.InterestTypes)
                ) && 
                (
                    this.CreditcardTypes == other.CreditcardTypes ||
                    this.CreditcardTypes != null &&
                    this.CreditcardTypes.SequenceEqual(other.CreditcardTypes)
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
                
                if (this.Countries != null)
                    hash = hash * 59 + this.Countries.GetHashCode();
                
                if (this.States != null)
                    hash = hash * 59 + this.States.GetHashCode();
                
                if (this.AddressTypes != null)
                    hash = hash * 59 + this.AddressTypes.GetHashCode();
                
                if (this.ReferralTypes != null)
                    hash = hash * 59 + this.ReferralTypes.GetHashCode();
                
                if (this.IndustryTypes != null)
                    hash = hash * 59 + this.IndustryTypes.GetHashCode();
                
                if (this.InterestTypes != null)
                    hash = hash * 59 + this.InterestTypes.GetHashCode();
                
                if (this.CreditcardTypes != null)
                    hash = hash * 59 + this.CreditcardTypes.GetHashCode();
                
                return hash;
            }
        }

    }
}
