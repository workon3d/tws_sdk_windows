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
    public partial class State :  IEquatable<State>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="State" /> class.
        /// Initializes a new instance of the <see cref="State" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="CountryId">CountryId.</param>
        /// <param name="Ordinal">Ordinal.</param>
        /// <param name="Abbreviation">Abbreviation.</param>

        public State(int? Id = null, string Name = null, int? CountryId = null, int? Ordinal = null, string Abbreviation = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.CountryId = CountryId;
            this.Ordinal = Ordinal;
            this.Abbreviation = Abbreviation;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name="country_id", EmitDefaultValue=false)]
        public int? CountryId { get; set; }
    
        /// <summary>
        /// Gets or Sets Ordinal
        /// </summary>
        [DataMember(Name="ordinal", EmitDefaultValue=false)]
        public int? Ordinal { get; set; }
    
        /// <summary>
        /// Gets or Sets Abbreviation
        /// </summary>
        [DataMember(Name="abbreviation", EmitDefaultValue=false)]
        public string Abbreviation { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class State {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  Ordinal: ").Append(Ordinal).Append("\n");
            sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
            
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
            return this.Equals(obj as State);
        }

        /// <summary>
        /// Returns true if State instances are equal
        /// </summary>
        /// <param name="other">Instance of State to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(State other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.CountryId == other.CountryId ||
                    this.CountryId != null &&
                    this.CountryId.Equals(other.CountryId)
                ) && 
                (
                    this.Ordinal == other.Ordinal ||
                    this.Ordinal != null &&
                    this.Ordinal.Equals(other.Ordinal)
                ) && 
                (
                    this.Abbreviation == other.Abbreviation ||
                    this.Abbreviation != null &&
                    this.Abbreviation.Equals(other.Abbreviation)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.CountryId != null)
                    hash = hash * 59 + this.CountryId.GetHashCode();
                
                if (this.Ordinal != null)
                    hash = hash * 59 + this.Ordinal.GetHashCode();
                
                if (this.Abbreviation != null)
                    hash = hash * 59 + this.Abbreviation.GetHashCode();
                
                return hash;
            }
        }

    }
}
