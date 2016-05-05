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
    public partial class BuildSpec :  IEquatable<BuildSpec>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildSpec" /> class.
        /// Initializes a new instance of the <see cref="BuildSpec" />class.
        /// </summary>
        /// <param name="ProcessId">ProcessId (required).</param>
        /// <param name="CategoryId">CategoryId.</param>
        /// <param name="ResolutionId">ResolutionId.</param>
        /// <param name="MaterialId">MaterialId (required).</param>
        /// <param name="FinishId">FinishId (required).</param>
        /// <param name="ColorId">ColorId (required).</param>
        /// <param name="CustomColors">CustomColors.</param>
        /// <param name="QualityId">QualityId (required).</param>
        /// <param name="DerometerId">DerometerId.</param>
        /// <param name="TextureId">TextureId.</param>
        /// <param name="SheenId">SheenId.</param>
        /// <param name="AdditionalGroups">AdditionalGroups.</param>

        public BuildSpec(int? ProcessId = null, int? CategoryId = null, int? ResolutionId = null, int? MaterialId = null, int? FinishId = null, int? ColorId = null, List<CustomColorBuildSpec> CustomColors = null, int? QualityId = null, int? DerometerId = null, int? TextureId = null, int? SheenId = null, AdditionalBuildSpec AdditionalGroups = null)
        {
            // to ensure "ProcessId" is required (not null)
            if (ProcessId == null)
            {
                throw new InvalidDataException("ProcessId is a required property for BuildSpec and cannot be null");
            }
            else
            {
                this.ProcessId = ProcessId;
            }
            this.MaterialId = MaterialId;
            this.FinishId = FinishId;
            this.ColorId = ColorId;
            this.QualityId = QualityId;
            this.CategoryId = CategoryId;
            this.ResolutionId = ResolutionId;
            this.CustomColors = CustomColors;
            this.DerometerId = DerometerId;
            this.TextureId = TextureId;
            this.SheenId = SheenId;
            this.AdditionalGroups = AdditionalGroups;
            
        }
        
    
        /// <summary>
        /// Gets or Sets ProcessId
        /// </summary>
        [DataMember(Name="process_id", EmitDefaultValue=false)]
        public int? ProcessId { get; set; }
    
        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name="category_id", EmitDefaultValue=false)]
        public int? CategoryId { get; set; }
    
        /// <summary>
        /// Gets or Sets ResolutionId
        /// </summary>
        [DataMember(Name="resolution_id", EmitDefaultValue=false)]
        public int? ResolutionId { get; set; }
    
        /// <summary>
        /// Gets or Sets MaterialId
        /// </summary>
        [DataMember(Name="material_id", EmitDefaultValue=false)]
        public int? MaterialId { get; set; }
    
        /// <summary>
        /// Gets or Sets FinishId
        /// </summary>
        [DataMember(Name="finish_id", EmitDefaultValue=false)]
        public int? FinishId { get; set; }
    
        /// <summary>
        /// Gets or Sets ColorId
        /// </summary>
        [DataMember(Name="color_id", EmitDefaultValue=false)]
        public int? ColorId { get; set; }
    
        /// <summary>
        /// Gets or Sets CustomColors
        /// </summary>
        [DataMember(Name="custom_colors", EmitDefaultValue=false)]
        public List<CustomColorBuildSpec> CustomColors { get; set; }
    
        /// <summary>
        /// Gets or Sets QualityId
        /// </summary>
        [DataMember(Name="quality_id", EmitDefaultValue=false)]
        public int? QualityId { get; set; }
    
        /// <summary>
        /// Gets or Sets DerometerId
        /// </summary>
        [DataMember(Name="derometer_id", EmitDefaultValue=false)]
        public int? DerometerId { get; set; }
    
        /// <summary>
        /// Gets or Sets TextureId
        /// </summary>
        [DataMember(Name="texture_id", EmitDefaultValue=false)]
        public int? TextureId { get; set; }
    
        /// <summary>
        /// Gets or Sets SheenId
        /// </summary>
        [DataMember(Name="sheen_id", EmitDefaultValue=false)]
        public int? SheenId { get; set; }
    
        /// <summary>
        /// Gets or Sets AdditionalGroups
        /// </summary>
        [DataMember(Name="additional_groups", EmitDefaultValue=false)]
        public AdditionalBuildSpec AdditionalGroups { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildSpec {\n");
            sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  ResolutionId: ").Append(ResolutionId).Append("\n");
            sb.Append("  MaterialId: ").Append(MaterialId).Append("\n");
            sb.Append("  FinishId: ").Append(FinishId).Append("\n");
            sb.Append("  ColorId: ").Append(ColorId).Append("\n");
            sb.Append("  CustomColors: ").Append(CustomColors).Append("\n");
            sb.Append("  QualityId: ").Append(QualityId).Append("\n");
            sb.Append("  DerometerId: ").Append(DerometerId).Append("\n");
            sb.Append("  TextureId: ").Append(TextureId).Append("\n");
            sb.Append("  SheenId: ").Append(SheenId).Append("\n");
            sb.Append("  AdditionalGroups: ").Append(AdditionalGroups).Append("\n");
            
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
            return this.Equals(obj as BuildSpec);
        }

        /// <summary>
        /// Returns true if BuildSpec instances are equal
        /// </summary>
        /// <param name="other">Instance of BuildSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildSpec other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProcessId == other.ProcessId ||
                    this.ProcessId != null &&
                    this.ProcessId.Equals(other.ProcessId)
                ) && 
                (
                    this.CategoryId == other.CategoryId ||
                    this.CategoryId != null &&
                    this.CategoryId.Equals(other.CategoryId)
                ) && 
                (
                    this.ResolutionId == other.ResolutionId ||
                    this.ResolutionId != null &&
                    this.ResolutionId.Equals(other.ResolutionId)
                ) && 
                (
                    this.MaterialId == other.MaterialId ||
                    this.MaterialId != null &&
                    this.MaterialId.Equals(other.MaterialId)
                ) && 
                (
                    this.FinishId == other.FinishId ||
                    this.FinishId != null &&
                    this.FinishId.Equals(other.FinishId)
                ) && 
                (
                    this.ColorId == other.ColorId ||
                    this.ColorId != null &&
                    this.ColorId.Equals(other.ColorId)
                ) && 
                (
                    this.CustomColors == other.CustomColors ||
                    this.CustomColors != null &&
                    this.CustomColors.SequenceEqual(other.CustomColors)
                ) && 
                (
                    this.QualityId == other.QualityId ||
                    this.QualityId != null &&
                    this.QualityId.Equals(other.QualityId)
                ) && 
                (
                    this.DerometerId == other.DerometerId ||
                    this.DerometerId != null &&
                    this.DerometerId.Equals(other.DerometerId)
                ) && 
                (
                    this.TextureId == other.TextureId ||
                    this.TextureId != null &&
                    this.TextureId.Equals(other.TextureId)
                ) && 
                (
                    this.SheenId == other.SheenId ||
                    this.SheenId != null &&
                    this.SheenId.Equals(other.SheenId)
                ) && 
                (
                    this.AdditionalGroups == other.AdditionalGroups ||
                    this.AdditionalGroups != null &&
                    this.AdditionalGroups.Equals(other.AdditionalGroups)
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
                
                if (this.ProcessId != null)
                    hash = hash * 59 + this.ProcessId.GetHashCode();
                
                if (this.CategoryId != null)
                    hash = hash * 59 + this.CategoryId.GetHashCode();
                
                if (this.ResolutionId != null)
                    hash = hash * 59 + this.ResolutionId.GetHashCode();
                
                if (this.MaterialId != null)
                    hash = hash * 59 + this.MaterialId.GetHashCode();
                
                if (this.FinishId != null)
                    hash = hash * 59 + this.FinishId.GetHashCode();
                
                if (this.ColorId != null)
                    hash = hash * 59 + this.ColorId.GetHashCode();
                
                if (this.CustomColors != null)
                    hash = hash * 59 + this.CustomColors.GetHashCode();
                
                if (this.QualityId != null)
                    hash = hash * 59 + this.QualityId.GetHashCode();
                
                if (this.DerometerId != null)
                    hash = hash * 59 + this.DerometerId.GetHashCode();
                
                if (this.TextureId != null)
                    hash = hash * 59 + this.TextureId.GetHashCode();
                
                if (this.SheenId != null)
                    hash = hash * 59 + this.SheenId.GetHashCode();
                
                if (this.AdditionalGroups != null)
                    hash = hash * 59 + this.AdditionalGroups.GetHashCode();
                
                return hash;
            }
        }

    }
}
