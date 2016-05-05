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
    public partial class ActivateUserOptions :  IEquatable<ActivateUserOptions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivateUserOptions" /> class.
        /// Initializes a new instance of the <see cref="ActivateUserOptions" />class.
        /// </summary>
        /// <param name="Email">login email.</param>
        /// <param name="ActivationToken">activation token.</param>

        public ActivateUserOptions(string Email = null, string ActivationToken = null)
        {
            this.Email = Email;
            this.ActivationToken = ActivationToken;
            
        }
        
    
        /// <summary>
        /// login email
        /// </summary>
        /// <value>login email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// activation token
        /// </summary>
        /// <value>activation token</value>
        [DataMember(Name="activation_token", EmitDefaultValue=false)]
        public string ActivationToken { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivateUserOptions {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ActivationToken: ").Append(ActivationToken).Append("\n");
            
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
            return this.Equals(obj as ActivateUserOptions);
        }

        /// <summary>
        /// Returns true if ActivateUserOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivateUserOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivateUserOptions other)
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
                    this.ActivationToken == other.ActivationToken ||
                    this.ActivationToken != null &&
                    this.ActivationToken.Equals(other.ActivationToken)
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
                
                if (this.ActivationToken != null)
                    hash = hash * 59 + this.ActivationToken.GetHashCode();
                
                return hash;
            }
        }

    }
}
