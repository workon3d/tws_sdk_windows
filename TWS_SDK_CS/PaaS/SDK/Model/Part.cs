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
    public partial class Part :  IEquatable<Part>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Part" /> class.
        /// Initializes a new instance of the <see cref="Part" />class.
        /// </summary>
        /// <param name="PartId">PartId.</param>
        /// <param name="StorId">StorId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="IsMetric">if this is true, x-y-z should be converted to inch already..</param>
        /// <param name="X">unit of value is always inch regardless of is_metric.</param>
        /// <param name="Y">unit of value is always inch regardless of is_metric.</param>
        /// <param name="Z">unit of value is always inch regardless of is_metric.</param>
        /// <param name="SurfaceArea">unit of value is always inch regardless of is_metric.</param>
        /// <param name="Volume">unit of value is always inch regardless of is_metric.</param>
        /// <param name="Size">file size (byte).</param>
        /// <param name="Scale">Scale.</param>
        /// <param name="CustomOrientation">CustomOrientation.</param>
        /// <param name="Visible">Visible.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>
        /// <param name="Meta">Meta.</param>

        public Part(int? PartId = null, string StorId = null, string Name = null, string Description = null, bool? IsMetric = null, double? X = null, double? Y = null, double? Z = null, double? SurfaceArea = null, double? Volume = null, string Size = null, double? Scale = null, bool? CustomOrientation = null, bool? Visible = null, string CreatedAt = null, string UpdatedAt = null, PartMeta Meta = null)
        {
            this.PartId = PartId;
            this.StorId = StorId;
            this.Name = Name;
            this.Description = Description;
            this.IsMetric = IsMetric;
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.SurfaceArea = SurfaceArea;
            this.Volume = Volume;
            this.Size = Size;
            this.Scale = Scale;
            this.CustomOrientation = CustomOrientation;
            this.Visible = Visible;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.Meta = Meta;
            
        }
        
    
        /// <summary>
        /// Gets or Sets PartId
        /// </summary>
        [DataMember(Name="part_id", EmitDefaultValue=false)]
        public int? PartId { get; set; }
    
        /// <summary>
        /// Gets or Sets StorId
        /// </summary>
        [DataMember(Name="stor_id", EmitDefaultValue=false)]
        public string StorId { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// if this is true, x-y-z should be converted to inch already.
        /// </summary>
        /// <value>if this is true, x-y-z should be converted to inch already.</value>
        [DataMember(Name="is_metric", EmitDefaultValue=false)]
        public bool? IsMetric { get; set; }
    
        /// <summary>
        /// unit of value is always inch regardless of is_metric
        /// </summary>
        /// <value>unit of value is always inch regardless of is_metric</value>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public double? X { get; set; }
    
        /// <summary>
        /// unit of value is always inch regardless of is_metric
        /// </summary>
        /// <value>unit of value is always inch regardless of is_metric</value>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public double? Y { get; set; }
    
        /// <summary>
        /// unit of value is always inch regardless of is_metric
        /// </summary>
        /// <value>unit of value is always inch regardless of is_metric</value>
        [DataMember(Name="z", EmitDefaultValue=false)]
        public double? Z { get; set; }
    
        /// <summary>
        /// unit of value is always inch regardless of is_metric
        /// </summary>
        /// <value>unit of value is always inch regardless of is_metric</value>
        [DataMember(Name="surface_area", EmitDefaultValue=false)]
        public double? SurfaceArea { get; set; }
    
        /// <summary>
        /// unit of value is always inch regardless of is_metric
        /// </summary>
        /// <value>unit of value is always inch regardless of is_metric</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public double? Volume { get; set; }
    
        /// <summary>
        /// file size (byte)
        /// </summary>
        /// <value>file size (byte)</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public string Size { get; set; }
    
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
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
    
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }
    
        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public PartMeta Meta { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Part {\n");
            sb.Append("  PartId: ").Append(PartId).Append("\n");
            sb.Append("  StorId: ").Append(StorId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsMetric: ").Append(IsMetric).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Z: ").Append(Z).Append("\n");
            sb.Append("  SurfaceArea: ").Append(SurfaceArea).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Scale: ").Append(Scale).Append("\n");
            sb.Append("  CustomOrientation: ").Append(CustomOrientation).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            
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
            return this.Equals(obj as Part);
        }

        /// <summary>
        /// Returns true if Part instances are equal
        /// </summary>
        /// <param name="other">Instance of Part to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Part other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PartId == other.PartId ||
                    this.PartId != null &&
                    this.PartId.Equals(other.PartId)
                ) && 
                (
                    this.StorId == other.StorId ||
                    this.StorId != null &&
                    this.StorId.Equals(other.StorId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
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
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
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
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.Meta == other.Meta ||
                    this.Meta != null &&
                    this.Meta.Equals(other.Meta)
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
                
                if (this.PartId != null)
                    hash = hash * 59 + this.PartId.GetHashCode();
                
                if (this.StorId != null)
                    hash = hash * 59 + this.StorId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
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
                
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                
                if (this.Scale != null)
                    hash = hash * 59 + this.Scale.GetHashCode();
                
                if (this.CustomOrientation != null)
                    hash = hash * 59 + this.CustomOrientation.GetHashCode();
                
                if (this.Visible != null)
                    hash = hash * 59 + this.Visible.GetHashCode();
                
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
                
                return hash;
            }
        }

    }
}
