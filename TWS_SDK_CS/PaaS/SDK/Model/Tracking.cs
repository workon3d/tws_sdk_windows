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
    public partial class Tracking :  IEquatable<Tracking>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Tracking" /> class.
        /// Initializes a new instance of the <see cref="Tracking" />class.
        /// </summary>
        /// <param name="TrackingNumber">TrackingNumber.</param>
        /// <param name="ShippingDate">ShippingDate.</param>
        /// <param name="CourierId">CourierId.</param>
        /// <param name="CourierName">CourierName.</param>
        /// <param name="Parts">Parts.</param>

        public Tracking(int? TrackingNumber = null, string ShippingDate = null, int? CourierId = null, string CourierName = null, List<TrackingPart> Parts = null)
        {
            this.TrackingNumber = TrackingNumber;
            this.ShippingDate = ShippingDate;
            this.CourierId = CourierId;
            this.CourierName = CourierName;
            this.Parts = Parts;
            
        }
        
    
        /// <summary>
        /// Gets or Sets TrackingNumber
        /// </summary>
        [DataMember(Name="tracking_number", EmitDefaultValue=false)]
        public int? TrackingNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets ShippingDate
        /// </summary>
        [DataMember(Name="shipping_date", EmitDefaultValue=false)]
        public string ShippingDate { get; set; }
    
        /// <summary>
        /// Gets or Sets CourierId
        /// </summary>
        [DataMember(Name="courier_id", EmitDefaultValue=false)]
        public int? CourierId { get; set; }
    
        /// <summary>
        /// Gets or Sets CourierName
        /// </summary>
        [DataMember(Name="courier_name", EmitDefaultValue=false)]
        public string CourierName { get; set; }
    
        /// <summary>
        /// Gets or Sets Parts
        /// </summary>
        [DataMember(Name="parts", EmitDefaultValue=false)]
        public List<TrackingPart> Parts { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tracking {\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  ShippingDate: ").Append(ShippingDate).Append("\n");
            sb.Append("  CourierId: ").Append(CourierId).Append("\n");
            sb.Append("  CourierName: ").Append(CourierName).Append("\n");
            sb.Append("  Parts: ").Append(Parts).Append("\n");
            
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
            return this.Equals(obj as Tracking);
        }

        /// <summary>
        /// Returns true if Tracking instances are equal
        /// </summary>
        /// <param name="other">Instance of Tracking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tracking other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TrackingNumber == other.TrackingNumber ||
                    this.TrackingNumber != null &&
                    this.TrackingNumber.Equals(other.TrackingNumber)
                ) && 
                (
                    this.ShippingDate == other.ShippingDate ||
                    this.ShippingDate != null &&
                    this.ShippingDate.Equals(other.ShippingDate)
                ) && 
                (
                    this.CourierId == other.CourierId ||
                    this.CourierId != null &&
                    this.CourierId.Equals(other.CourierId)
                ) && 
                (
                    this.CourierName == other.CourierName ||
                    this.CourierName != null &&
                    this.CourierName.Equals(other.CourierName)
                ) && 
                (
                    this.Parts == other.Parts ||
                    this.Parts != null &&
                    this.Parts.SequenceEqual(other.Parts)
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
                
                if (this.TrackingNumber != null)
                    hash = hash * 59 + this.TrackingNumber.GetHashCode();
                
                if (this.ShippingDate != null)
                    hash = hash * 59 + this.ShippingDate.GetHashCode();
                
                if (this.CourierId != null)
                    hash = hash * 59 + this.CourierId.GetHashCode();
                
                if (this.CourierName != null)
                    hash = hash * 59 + this.CourierName.GetHashCode();
                
                if (this.Parts != null)
                    hash = hash * 59 + this.Parts.GetHashCode();
                
                return hash;
            }
        }

    }
}
