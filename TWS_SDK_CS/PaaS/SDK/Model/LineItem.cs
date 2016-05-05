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
    public partial class LineItem :  IEquatable<LineItem>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItem" /> class.
        /// Initializes a new instance of the <see cref="LineItem" />class.
        /// </summary>
        /// <param name="LineItemId">LineItemId.</param>
        /// <param name="QuoteId">QuoteId.</param>
        /// <param name="PartId">PartId.</param>
        /// <param name="PartName">PartName.</param>
        /// <param name="Quantity">Quantity.</param>
        /// <param name="Description">Description.</param>
        /// <param name="BuildSpec">BuildSpec.</param>
        /// <param name="LeadTimeId">LeadTimeId.</param>
        /// <param name="UnitPrice">UnitPrice.</param>
        /// <param name="LiPrice">LiPrice.</param>
        /// <param name="LeadTimePrices">LeadTimePrices.</param>
        /// <param name="Error">Error.</param>
        /// <param name="IsActivated">IsActivated.</param>
        /// <param name="Attachments">Attachments.</param>

        public LineItem(int? LineItemId = null, int? QuoteId = null, int? PartId = null, string PartName = null, int? Quantity = null, string Description = null, BuildSpec BuildSpec = null, int? LeadTimeId = null, double? UnitPrice = null, double? LiPrice = null, List<LeadTimePrice> LeadTimePrices = null, string Error = null, bool? IsActivated = null, List<Attachment> Attachments = null)
        {
            this.LineItemId = LineItemId;
            this.QuoteId = QuoteId;
            this.PartId = PartId;
            this.PartName = PartName;
            this.Quantity = Quantity;
            this.Description = Description;
            this.BuildSpec = BuildSpec;
            this.LeadTimeId = LeadTimeId;
            this.UnitPrice = UnitPrice;
            this.LiPrice = LiPrice;
            this.LeadTimePrices = LeadTimePrices;
            this.Error = Error;
            this.IsActivated = IsActivated;
            this.Attachments = Attachments;
            
        }
        
    
        /// <summary>
        /// Gets or Sets LineItemId
        /// </summary>
        [DataMember(Name="line_item_id", EmitDefaultValue=false)]
        public int? LineItemId { get; set; }
    
        /// <summary>
        /// Gets or Sets QuoteId
        /// </summary>
        [DataMember(Name="quote_id", EmitDefaultValue=false)]
        public int? QuoteId { get; set; }
    
        /// <summary>
        /// Gets or Sets PartId
        /// </summary>
        [DataMember(Name="part_id", EmitDefaultValue=false)]
        public int? PartId { get; set; }
    
        /// <summary>
        /// Gets or Sets PartName
        /// </summary>
        [DataMember(Name="part_name", EmitDefaultValue=false)]
        public string PartName { get; set; }
    
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }
    
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets BuildSpec
        /// </summary>
        [DataMember(Name="build_spec", EmitDefaultValue=false)]
        public BuildSpec BuildSpec { get; set; }
    
        /// <summary>
        /// Gets or Sets LeadTimeId
        /// </summary>
        [DataMember(Name="lead_time_id", EmitDefaultValue=false)]
        public int? LeadTimeId { get; set; }
    
        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name="unit_price", EmitDefaultValue=false)]
        public double? UnitPrice { get; set; }
    
        /// <summary>
        /// Gets or Sets LiPrice
        /// </summary>
        [DataMember(Name="li_price", EmitDefaultValue=false)]
        public double? LiPrice { get; set; }
    
        /// <summary>
        /// Gets or Sets LeadTimePrices
        /// </summary>
        [DataMember(Name="lead_time_prices", EmitDefaultValue=false)]
        public List<LeadTimePrice> LeadTimePrices { get; set; }
    
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }
    
        /// <summary>
        /// Gets or Sets IsActivated
        /// </summary>
        [DataMember(Name="is_activated", EmitDefaultValue=false)]
        public bool? IsActivated { get; set; }
    
        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<Attachment> Attachments { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItem {\n");
            sb.Append("  LineItemId: ").Append(LineItemId).Append("\n");
            sb.Append("  QuoteId: ").Append(QuoteId).Append("\n");
            sb.Append("  PartId: ").Append(PartId).Append("\n");
            sb.Append("  PartName: ").Append(PartName).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  BuildSpec: ").Append(BuildSpec).Append("\n");
            sb.Append("  LeadTimeId: ").Append(LeadTimeId).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  LiPrice: ").Append(LiPrice).Append("\n");
            sb.Append("  LeadTimePrices: ").Append(LeadTimePrices).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  IsActivated: ").Append(IsActivated).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            
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
            return this.Equals(obj as LineItem);
        }

        /// <summary>
        /// Returns true if LineItem instances are equal
        /// </summary>
        /// <param name="other">Instance of LineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LineItemId == other.LineItemId ||
                    this.LineItemId != null &&
                    this.LineItemId.Equals(other.LineItemId)
                ) && 
                (
                    this.QuoteId == other.QuoteId ||
                    this.QuoteId != null &&
                    this.QuoteId.Equals(other.QuoteId)
                ) && 
                (
                    this.PartId == other.PartId ||
                    this.PartId != null &&
                    this.PartId.Equals(other.PartId)
                ) && 
                (
                    this.PartName == other.PartName ||
                    this.PartName != null &&
                    this.PartName.Equals(other.PartName)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.BuildSpec == other.BuildSpec ||
                    this.BuildSpec != null &&
                    this.BuildSpec.Equals(other.BuildSpec)
                ) && 
                (
                    this.LeadTimeId == other.LeadTimeId ||
                    this.LeadTimeId != null &&
                    this.LeadTimeId.Equals(other.LeadTimeId)
                ) && 
                (
                    this.UnitPrice == other.UnitPrice ||
                    this.UnitPrice != null &&
                    this.UnitPrice.Equals(other.UnitPrice)
                ) && 
                (
                    this.LiPrice == other.LiPrice ||
                    this.LiPrice != null &&
                    this.LiPrice.Equals(other.LiPrice)
                ) && 
                (
                    this.LeadTimePrices == other.LeadTimePrices ||
                    this.LeadTimePrices != null &&
                    this.LeadTimePrices.SequenceEqual(other.LeadTimePrices)
                ) && 
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) && 
                (
                    this.IsActivated == other.IsActivated ||
                    this.IsActivated != null &&
                    this.IsActivated.Equals(other.IsActivated)
                ) && 
                (
                    this.Attachments == other.Attachments ||
                    this.Attachments != null &&
                    this.Attachments.SequenceEqual(other.Attachments)
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
                
                if (this.LineItemId != null)
                    hash = hash * 59 + this.LineItemId.GetHashCode();
                
                if (this.QuoteId != null)
                    hash = hash * 59 + this.QuoteId.GetHashCode();
                
                if (this.PartId != null)
                    hash = hash * 59 + this.PartId.GetHashCode();
                
                if (this.PartName != null)
                    hash = hash * 59 + this.PartName.GetHashCode();
                
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.BuildSpec != null)
                    hash = hash * 59 + this.BuildSpec.GetHashCode();
                
                if (this.LeadTimeId != null)
                    hash = hash * 59 + this.LeadTimeId.GetHashCode();
                
                if (this.UnitPrice != null)
                    hash = hash * 59 + this.UnitPrice.GetHashCode();
                
                if (this.LiPrice != null)
                    hash = hash * 59 + this.LiPrice.GetHashCode();
                
                if (this.LeadTimePrices != null)
                    hash = hash * 59 + this.LeadTimePrices.GetHashCode();
                
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                
                if (this.IsActivated != null)
                    hash = hash * 59 + this.IsActivated.GetHashCode();
                
                if (this.Attachments != null)
                    hash = hash * 59 + this.Attachments.GetHashCode();
                
                return hash;
            }
        }

    }
}
