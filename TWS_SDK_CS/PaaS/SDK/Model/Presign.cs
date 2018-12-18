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
using System.Dynamic;

namespace PaaS.SDK.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Presign :  IEquatable<Presign>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Presign" /> class.
        /// Initializes a new instance of the <see cref="Presign" />class.
        /// </summary>
        /// <param name="UploadId">UploadId.</param>
        /// <param name="Bucket">Bucket.</param>
        /// <param name="FormAction">FormAction.</param>
        /// <param name="FormMethod">FormMethod.</param>
        /// <param name="FormEnctype">FormEnctype.</param>
        /// <param name="FormFields">FormFields.</param>
        /// <param name="CurlExample">Upload example using curl.</param>

        public Presign(string UploadId = null, string Bucket = null, string FormAction = null, string FormMethod = null, string FormEnctype = null, ExpandoObject FormFields = null, string CurlExample = null)
        {
            this.UploadId = UploadId;
            this.Bucket = Bucket;
            this.FormAction = FormAction;
            this.FormMethod = FormMethod;
            this.FormEnctype = FormEnctype;
            this.FormFields = FormFields;
            this.CurlExample = CurlExample;
            
        }
        
    
        /// <summary>
        /// Gets or Sets UploadId
        /// </summary>
        [DataMember(Name="upload_id", EmitDefaultValue=false)]
        public string UploadId { get; set; }
    
        /// <summary>
        /// Gets or Sets Bucket
        /// </summary>
        [DataMember(Name="bucket", EmitDefaultValue=false)]
        public string Bucket { get; set; }
    
        /// <summary>
        /// Gets or Sets FormAction
        /// </summary>
        [DataMember(Name="form_action", EmitDefaultValue=false)]
        public string FormAction { get; set; }
    
        /// <summary>
        /// Gets or Sets FormMethod
        /// </summary>
        [DataMember(Name="form_method", EmitDefaultValue=false)]
        public string FormMethod { get; set; }
    
        /// <summary>
        /// Gets or Sets FormEnctype
        /// </summary>
        [DataMember(Name="form_enctype", EmitDefaultValue=false)]
        public string FormEnctype { get; set; }
    
        /// <summary>
        /// Gets or Sets FormFields
        /// </summary>
        [DataMember(Name="form_fields", EmitDefaultValue=false)]
        public ExpandoObject FormFields { get; set; }
    
        /// <summary>
        /// Upload example using curl
        /// </summary>
        /// <value>Upload example using curl</value>
        [DataMember(Name="curl_example", EmitDefaultValue=false)]
        public string CurlExample { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Presign {\n");
            sb.Append("  UploadId: ").Append(UploadId).Append("\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
            sb.Append("  FormAction: ").Append(FormAction).Append("\n");
            sb.Append("  FormMethod: ").Append(FormMethod).Append("\n");
            sb.Append("  FormEnctype: ").Append(FormEnctype).Append("\n");
            sb.Append("  FormFields: ").Append(FormFields).Append("\n");
            sb.Append("  CurlExample: ").Append(CurlExample).Append("\n");
            
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
            return this.Equals(obj as Presign);
        }

        /// <summary>
        /// Returns true if Presign instances are equal
        /// </summary>
        /// <param name="other">Instance of Presign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Presign other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UploadId == other.UploadId ||
                    this.UploadId != null &&
                    this.UploadId.Equals(other.UploadId)
                ) && 
                (
                    this.Bucket == other.Bucket ||
                    this.Bucket != null &&
                    this.Bucket.Equals(other.Bucket)
                ) && 
                (
                    this.FormAction == other.FormAction ||
                    this.FormAction != null &&
                    this.FormAction.Equals(other.FormAction)
                ) && 
                (
                    this.FormMethod == other.FormMethod ||
                    this.FormMethod != null &&
                    this.FormMethod.Equals(other.FormMethod)
                ) && 
                (
                    this.FormEnctype == other.FormEnctype ||
                    this.FormEnctype != null &&
                    this.FormEnctype.Equals(other.FormEnctype)
                ) && 
                (
                    this.FormFields == other.FormFields ||
                    this.FormFields != null &&
                    this.FormFields.Equals(other.FormFields)
                ) && 
                (
                    this.CurlExample == other.CurlExample ||
                    this.CurlExample != null &&
                    this.CurlExample.Equals(other.CurlExample)
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
                
                if (this.UploadId != null)
                    hash = hash * 59 + this.UploadId.GetHashCode();
                
                if (this.Bucket != null)
                    hash = hash * 59 + this.Bucket.GetHashCode();
                
                if (this.FormAction != null)
                    hash = hash * 59 + this.FormAction.GetHashCode();
                
                if (this.FormMethod != null)
                    hash = hash * 59 + this.FormMethod.GetHashCode();
                
                if (this.FormEnctype != null)
                    hash = hash * 59 + this.FormEnctype.GetHashCode();
                
                if (this.FormFields != null)
                    hash = hash * 59 + this.FormFields.GetHashCode();
                
                if (this.CurlExample != null)
                    hash = hash * 59 + this.CurlExample.GetHashCode();
                
                return hash;
            }
        }

    }
}
