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
    public partial class UpdatePartOptions :  IEquatable<UpdatePartOptions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePartOptions" /> class.
        /// Initializes a new instance of the <see cref="UpdatePartOptions" />class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="IsMetric">IsMetric.</param>
        /// <param name="X">X.</param>
        /// <param name="Y">Y.</param>
        /// <param name="Z">Z.</param>
        /// <param name="SurfaceArea">SurfaceArea.</param>
        /// <param name="Volume">Volume.</param>
        /// <param name="TwsResponse">TwsResponse.</param>
        /// <param name="Scale">Scale.</param>
        /// <param name="CustomOrientation">CustomOrientation.</param>
        /// <param name="Visible">Visible.</param>

        public UpdatePartOptions(string Description = null, bool? IsMetric = null, double? X = null, double? Y = null, double? Z = null, double? SurfaceArea = null, double? Volume = null, string TwsResponse = null, double? Scale = null, bool? CustomOrientation = null, bool? Visible = null)
        {
            this.Description = Description;
            this.IsMetric = IsMetric;
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.SurfaceArea = SurfaceArea;
            this.Volume = Volume;
            this.TwsResponse = TwsResponse;
            this.Scale = Scale;
            this.CustomOrientation = CustomOrientation;
            this.Visible = Visible;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets IsMetric
        /// </summary>
        [DataMember(Name="is_metric", EmitDefaultValue=false)]
        public bool? IsMetric { get; set; }
    
        /// <summary>
        /// Gets or Sets X
        /// </summary>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public double? X { get; set; }
    
        /// <summary>
        /// Gets or Sets Y
        /// </summary>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public double? Y { get; set; }
    
        /// <summary>
        /// Gets or Sets Z
        /// </summary>
        [DataMember(Name="z", EmitDefaultValue=false)]
        public double? Z { get; set; }
    
        /// <summary>
        /// Gets or Sets SurfaceArea
        /// </summary>
        [DataMember(Name="surface_area", EmitDefaultValue=false)]
        public double? SurfaceArea { get; set; }
    
        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public double? Volume { get; set; }
    
        /// <summary>
        /// Gets or Sets TwsResponse
        /// </summary>
        [DataMember(Name="tws_response", EmitDefaultValue=false)]
        public string TwsResponse { get; set; }
    
        /// <summary>
        /// Gets or Sets Scale
        /// </summary>
        [DataMember(Name="scale", EmitDefaultValue=false)]
        public double? Scale { get; set; }
    
        /// <summary>
        /// Gets or Sets CustomOrientation
        /// </summary>
        [DataMember(Name="custom_orientation", EmitDefaultValue=false)]
        public bool? CustomOrientation { get; set; }
    
        /// <summary>
        /// Gets or Sets Visible
        /// </summary>
        [DataMember(Name="visible", EmitDefaultValue=false)]
        public bool? Visible { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePartOptions {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsMetric: ").Append(IsMetric).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Z: ").Append(Z).Append("\n");
            sb.Append("  SurfaceArea: ").Append(SurfaceArea).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  TwsResponse: ").Append(TwsResponse).Append("\n");
            sb.Append("  Scale: ").Append(Scale).Append("\n");
            sb.Append("  CustomOrientation: ").Append(CustomOrientation).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            
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
            return this.Equals(obj as UpdatePartOptions);
        }

        /// <summary>
        /// Returns true if UpdatePartOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdatePartOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePartOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.IsMetric == other.IsMetric ||
                    this.IsMetric != null &&
                    this.IsMetric.Equals(other.IsMetric)
                ) && 
                (
                    this.X == other.X ||
                    this.X != null &&
                    this.X.Equals(other.X)
                ) && 
                (
                    this.Y == other.Y ||
                    this.Y != null &&
                    this.Y.Equals(other.Y)
                ) && 
                (
                    this.Z == other.Z ||
                    this.Z != null &&
                    this.Z.Equals(other.Z)
                ) && 
                (
                    this.SurfaceArea == other.SurfaceArea ||
                    this.SurfaceArea != null &&
                    this.SurfaceArea.Equals(other.SurfaceArea)
                ) && 
                (
                    this.Volume == other.Volume ||
                    this.Volume != null &&
                    this.Volume.Equals(other.Volume)
                ) && 
                (
                    this.TwsResponse == other.TwsResponse ||
                    this.TwsResponse != null &&
                    this.TwsResponse.Equals(other.TwsResponse)
                ) && 
                (
                    this.Scale == other.Scale ||
                    this.Scale != null &&
                    this.Scale.Equals(other.Scale)
                ) && 
                (
                    this.CustomOrientation == other.CustomOrientation ||
                    this.CustomOrientation != null &&
                    this.CustomOrientation.Equals(other.CustomOrientation)
                ) && 
                (
                    this.Visible == other.Visible ||
                    this.Visible != null &&
                    this.Visible.Equals(other.Visible)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.IsMetric != null)
                    hash = hash * 59 + this.IsMetric.GetHashCode();
                
                if (this.X != null)
                    hash = hash * 59 + this.X.GetHashCode();
                
                if (this.Y != null)
                    hash = hash * 59 + this.Y.GetHashCode();
                
                if (this.Z != null)
                    hash = hash * 59 + this.Z.GetHashCode();
                
                if (this.SurfaceArea != null)
                    hash = hash * 59 + this.SurfaceArea.GetHashCode();
                
                if (this.Volume != null)
                    hash = hash * 59 + this.Volume.GetHashCode();
                
                if (this.TwsResponse != null)
                    hash = hash * 59 + this.TwsResponse.GetHashCode();
                
                if (this.Scale != null)
                    hash = hash * 59 + this.Scale.GetHashCode();
                
                if (this.CustomOrientation != null)
                    hash = hash * 59 + this.CustomOrientation.GetHashCode();
                
                if (this.Visible != null)
                    hash = hash * 59 + this.Visible.GetHashCode();
                
                return hash;
            }
        }

    }
}
