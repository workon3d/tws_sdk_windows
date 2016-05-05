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
    public partial class AuthenticateUserOptions :  IEquatable<AuthenticateUserOptions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticateUserOptions" /> class.
        /// Initializes a new instance of the <see cref="AuthenticateUserOptions" />class.
        /// </summary>
        /// <param name="Email">login email.</param>
        /// <param name="Password">Password.</param>
        /// <param name="Buid">business unit id (optional).</param>

        public AuthenticateUserOptions(string Email = null, string Password = null, int? Buid = null)
        {
            this.Email = Email;
            this.Password = Password;
            this.Buid = Buid;
            
        }
        
    
        /// <summary>
        /// login email
        /// </summary>
        /// <value>login email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
    
        /// <summary>
        /// business unit id (optional)
        /// </summary>
        /// <value>business unit id (optional)</value>
        [DataMember(Name="buid", EmitDefaultValue=false)]
        public int? Buid { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticateUserOptions {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Buid: ").Append(Buid).Append("\n");
            
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
            return this.Equals(obj as AuthenticateUserOptions);
        }

        /// <summary>
        /// Returns true if AuthenticateUserOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthenticateUserOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticateUserOptions other)
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
                    this.Buid == other.Buid ||
                    this.Buid != null &&
                    this.Buid.Equals(other.Buid)
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
                
                if (this.Buid != null)
                    hash = hash * 59 + this.Buid.GetHashCode();
                
                return hash;
            }
        }

    }
}
