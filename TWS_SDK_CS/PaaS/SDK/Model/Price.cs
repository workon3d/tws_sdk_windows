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
    public partial class Price :  IEquatable<Price>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Price" /> class.
        /// Initializes a new instance of the <see cref="Price" />class.
        /// </summary>
        /// <param name="EconomyPrice">EconomyPrice.</param>
        /// <param name="FinishPrice">FinishPrice.</param>
        /// <param name="NextDayPrice">NextDayPrice.</param>
        /// <param name="QuPrice">QuPrice.</param>
        /// <param name="SellingPrice">SellingPrice.</param>
        /// <param name="ShippingCost">ShippingCost.</param>
        /// <param name="StandardPrice">StandardPrice.</param>

        public Price(double? EconomyPrice = null, double? FinishPrice = null, double? NextDayPrice = null, double? QuPrice = null, double? SellingPrice = null, double? ShippingCost = null, double? StandardPrice = null)
        {
            this.EconomyPrice = EconomyPrice;
            this.FinishPrice = FinishPrice;
            this.NextDayPrice = NextDayPrice;
            this.QuPrice = QuPrice;
            this.SellingPrice = SellingPrice;
            this.ShippingCost = ShippingCost;
            this.StandardPrice = StandardPrice;
            
        }
        
    
        /// <summary>
        /// Gets or Sets EconomyPrice
        /// </summary>
        [DataMember(Name="economy_price", EmitDefaultValue=false)]
        public double? EconomyPrice { get; set; }
    
        /// <summary>
        /// Gets or Sets FinishPrice
        /// </summary>
        [DataMember(Name="finish_price", EmitDefaultValue=false)]
        public double? FinishPrice { get; set; }
    
        /// <summary>
        /// Gets or Sets NextDayPrice
        /// </summary>
        [DataMember(Name="next_day_price", EmitDefaultValue=false)]
        public double? NextDayPrice { get; set; }
    
        /// <summary>
        /// Gets or Sets QuPrice
        /// </summary>
        [DataMember(Name="qu_price", EmitDefaultValue=false)]
        public double? QuPrice { get; set; }
    
        /// <summary>
        /// Gets or Sets SellingPrice
        /// </summary>
        [DataMember(Name="selling_price", EmitDefaultValue=false)]
        public double? SellingPrice { get; set; }
    
        /// <summary>
        /// Gets or Sets ShippingCost
        /// </summary>
        [DataMember(Name="shipping_cost", EmitDefaultValue=false)]
        public double? ShippingCost { get; set; }
    
        /// <summary>
        /// Gets or Sets StandardPrice
        /// </summary>
        [DataMember(Name="standard_price", EmitDefaultValue=false)]
        public double? StandardPrice { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Price {\n");
            sb.Append("  EconomyPrice: ").Append(EconomyPrice).Append("\n");
            sb.Append("  FinishPrice: ").Append(FinishPrice).Append("\n");
            sb.Append("  NextDayPrice: ").Append(NextDayPrice).Append("\n");
            sb.Append("  QuPrice: ").Append(QuPrice).Append("\n");
            sb.Append("  SellingPrice: ").Append(SellingPrice).Append("\n");
            sb.Append("  ShippingCost: ").Append(ShippingCost).Append("\n");
            sb.Append("  StandardPrice: ").Append(StandardPrice).Append("\n");
            
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
            return this.Equals(obj as Price);
        }

        /// <summary>
        /// Returns true if Price instances are equal
        /// </summary>
        /// <param name="other">Instance of Price to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Price other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EconomyPrice == other.EconomyPrice ||
                    this.EconomyPrice != null &&
                    this.EconomyPrice.Equals(other.EconomyPrice)
                ) && 
                (
                    this.FinishPrice == other.FinishPrice ||
                    this.FinishPrice != null &&
                    this.FinishPrice.Equals(other.FinishPrice)
                ) && 
                (
                    this.NextDayPrice == other.NextDayPrice ||
                    this.NextDayPrice != null &&
                    this.NextDayPrice.Equals(other.NextDayPrice)
                ) && 
                (
                    this.QuPrice == other.QuPrice ||
                    this.QuPrice != null &&
                    this.QuPrice.Equals(other.QuPrice)
                ) && 
                (
                    this.SellingPrice == other.SellingPrice ||
                    this.SellingPrice != null &&
                    this.SellingPrice.Equals(other.SellingPrice)
                ) && 
                (
                    this.ShippingCost == other.ShippingCost ||
                    this.ShippingCost != null &&
                    this.ShippingCost.Equals(other.ShippingCost)
                ) && 
                (
                    this.StandardPrice == other.StandardPrice ||
                    this.StandardPrice != null &&
                    this.StandardPrice.Equals(other.StandardPrice)
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
                
                if (this.EconomyPrice != null)
                    hash = hash * 59 + this.EconomyPrice.GetHashCode();
                
                if (this.FinishPrice != null)
                    hash = hash * 59 + this.FinishPrice.GetHashCode();
                
                if (this.NextDayPrice != null)
                    hash = hash * 59 + this.NextDayPrice.GetHashCode();
                
                if (this.QuPrice != null)
                    hash = hash * 59 + this.QuPrice.GetHashCode();
                
                if (this.SellingPrice != null)
                    hash = hash * 59 + this.SellingPrice.GetHashCode();
                
                if (this.ShippingCost != null)
                    hash = hash * 59 + this.ShippingCost.GetHashCode();
                
                if (this.StandardPrice != null)
                    hash = hash * 59 + this.StandardPrice.GetHashCode();
                
                return hash;
            }
        }

    }
}
