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
    public partial class QuoteOrderInfo :  IEquatable<QuoteOrderInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteOrderInfo" /> class.
        /// Initializes a new instance of the <see cref="QuoteOrderInfo" />class.
        /// </summary>
        /// <param name="OrderedAt">OrderedAt.</param>
        /// <param name="ProjectManager">ProjectManager.</param>
        /// <param name="TrackingInfo">is null when the information is not available.</param>
        /// <param name="Invoice">Invoice.</param>

        public QuoteOrderInfo(string OrderedAt = null, PM ProjectManager = null, Tracking TrackingInfo = null, string Invoice = null)
        {
            this.OrderedAt = OrderedAt;
            this.ProjectManager = ProjectManager;
            this.TrackingInfo = TrackingInfo;
            this.Invoice = Invoice;
            
        }
        
    
        /// <summary>
        /// Gets or Sets OrderedAt
        /// </summary>
        [DataMember(Name="ordered_at", EmitDefaultValue=false)]
        public string OrderedAt { get; set; }
    
        /// <summary>
        /// Gets or Sets ProjectManager
        /// </summary>
        [DataMember(Name="project_manager", EmitDefaultValue=false)]
        public PM ProjectManager { get; set; }
    
        /// <summary>
        /// is null when the information is not available
        /// </summary>
        /// <value>is null when the information is not available</value>
        [DataMember(Name="tracking_info", EmitDefaultValue=false)]
        public Tracking TrackingInfo { get; set; }
    
        /// <summary>
        /// Gets or Sets Invoice
        /// </summary>
        [DataMember(Name="invoice", EmitDefaultValue=false)]
        public string Invoice { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuoteOrderInfo {\n");
            sb.Append("  OrderedAt: ").Append(OrderedAt).Append("\n");
            sb.Append("  ProjectManager: ").Append(ProjectManager).Append("\n");
            sb.Append("  TrackingInfo: ").Append(TrackingInfo).Append("\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            
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
            return this.Equals(obj as QuoteOrderInfo);
        }

        /// <summary>
        /// Returns true if QuoteOrderInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of QuoteOrderInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteOrderInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrderedAt == other.OrderedAt ||
                    this.OrderedAt != null &&
                    this.OrderedAt.Equals(other.OrderedAt)
                ) && 
                (
                    this.ProjectManager == other.ProjectManager ||
                    this.ProjectManager != null &&
                    this.ProjectManager.Equals(other.ProjectManager)
                ) && 
                (
                    this.TrackingInfo == other.TrackingInfo ||
                    this.TrackingInfo != null &&
                    this.TrackingInfo.Equals(other.TrackingInfo)
                ) && 
                (
                    this.Invoice == other.Invoice ||
                    this.Invoice != null &&
                    this.Invoice.Equals(other.Invoice)
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
                
                if (this.OrderedAt != null)
                    hash = hash * 59 + this.OrderedAt.GetHashCode();
                
                if (this.ProjectManager != null)
                    hash = hash * 59 + this.ProjectManager.GetHashCode();
                
                if (this.TrackingInfo != null)
                    hash = hash * 59 + this.TrackingInfo.GetHashCode();
                
                if (this.Invoice != null)
                    hash = hash * 59 + this.Invoice.GetHashCode();
                
                return hash;
            }
        }

    }
}
