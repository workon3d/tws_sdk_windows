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
    public partial class UserAuthenticated :  IEquatable<UserAuthenticated>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAuthenticated" /> class.
        /// Initializes a new instance of the <see cref="UserAuthenticated" />class.
        /// </summary>
        /// <param name="UserId">UserId.</param>
        /// <param name="UserToken">user_token for API access.</param>
        /// <param name="IsActivated">IsActivated.</param>

        public UserAuthenticated(int? UserId = null, string UserToken = null, bool? IsActivated = null)
        {
            this.UserId = UserId;
            this.UserToken = UserToken;
            this.IsActivated = IsActivated;
            
        }
        
    
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }
    
        /// <summary>
        /// user_token for API access
        /// </summary>
        /// <value>user_token for API access</value>
        [DataMember(Name="user_token", EmitDefaultValue=false)]
        public string UserToken { get; set; }
    
        /// <summary>
        /// Gets or Sets IsActivated
        /// </summary>
        [DataMember(Name="is_activated", EmitDefaultValue=false)]
        public bool? IsActivated { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAuthenticated {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserToken: ").Append(UserToken).Append("\n");
            sb.Append("  IsActivated: ").Append(IsActivated).Append("\n");
            
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
            return this.Equals(obj as UserAuthenticated);
        }

        /// <summary>
        /// Returns true if UserAuthenticated instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAuthenticated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAuthenticated other)
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
                    this.UserToken == other.UserToken ||
                    this.UserToken != null &&
                    this.UserToken.Equals(other.UserToken)
                ) && 
                (
                    this.IsActivated == other.IsActivated ||
                    this.IsActivated != null &&
                    this.IsActivated.Equals(other.IsActivated)
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
                
                if (this.UserToken != null)
                    hash = hash * 59 + this.UserToken.GetHashCode();
                
                if (this.IsActivated != null)
                    hash = hash * 59 + this.IsActivated.GetHashCode();
                
                return hash;
            }
        }

    }
}
