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
    public partial class PasswordToken :  IEquatable<PasswordToken>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordToken" /> class.
        /// Initializes a new instance of the <see cref="PasswordToken" />class.
        /// </summary>
        /// <param name="Email">Email.</param>
        /// <param name="_PasswordToken">_PasswordToken.</param>

        public PasswordToken(string Email = null, string _PasswordToken = null)
        {
            this.Email = Email;
            this._PasswordToken = _PasswordToken;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or Sets _PasswordToken
        /// </summary>
        [DataMember(Name="password_token", EmitDefaultValue=false)]
        public string _PasswordToken { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordToken {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  _PasswordToken: ").Append(_PasswordToken).Append("\n");
            
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
            return this.Equals(obj as PasswordToken);
        }

        /// <summary>
        /// Returns true if PasswordToken instances are equal
        /// </summary>
        /// <param name="other">Instance of PasswordToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordToken other)
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
                    this._PasswordToken == other._PasswordToken ||
                    this._PasswordToken != null &&
                    this._PasswordToken.Equals(other._PasswordToken)
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
                
                if (this._PasswordToken != null)
                    hash = hash * 59 + this._PasswordToken.GetHashCode();
                
                return hash;
            }
        }

    }
}
