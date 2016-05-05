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
    public partial class Material :  IEquatable<Material>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Material" /> class.
        /// Initializes a new instance of the <see cref="Material" />class.
        /// </summary>
        /// <param name="MaterialId">MaterialId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Finishes">Finishes.</param>
        /// <param name="Colors">Colors.</param>
        /// <param name="CustomColors">CustomColors.</param>
        /// <param name="Textures">Textures.</param>
        /// <param name="Sheen">Sheen.</param>
        /// <param name="PlatformSize">PlatformSize.</param>

        public Material(int? MaterialId = null, string Name = null, List<Finish> Finishes = null, List<Color> Colors = null, List<CustomColor> CustomColors = null, List<Texture> Textures = null, List<Sheen> Sheen = null, List<double?> PlatformSize = null)
        {
            this.MaterialId = MaterialId;
            this.Name = Name;
            this.Finishes = Finishes;
            this.Colors = Colors;
            this.CustomColors = CustomColors;
            this.Textures = Textures;
            this.Sheen = Sheen;
            this.PlatformSize = PlatformSize;
            
        }
        
    
        /// <summary>
        /// Gets or Sets MaterialId
        /// </summary>
        [DataMember(Name="material_id", EmitDefaultValue=false)]
        public int? MaterialId { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Finishes
        /// </summary>
        [DataMember(Name="finishes", EmitDefaultValue=false)]
        public List<Finish> Finishes { get; set; }
    
        /// <summary>
        /// Gets or Sets Colors
        /// </summary>
        [DataMember(Name="colors", EmitDefaultValue=false)]
        public List<Color> Colors { get; set; }
    
        /// <summary>
        /// Gets or Sets CustomColors
        /// </summary>
        [DataMember(Name="custom_colors", EmitDefaultValue=false)]
        public List<CustomColor> CustomColors { get; set; }
    
        /// <summary>
        /// Gets or Sets Textures
        /// </summary>
        [DataMember(Name="textures", EmitDefaultValue=false)]
        public List<Texture> Textures { get; set; }
    
        /// <summary>
        /// Gets or Sets Sheen
        /// </summary>
        [DataMember(Name="sheen", EmitDefaultValue=false)]
        public List<Sheen> Sheen { get; set; }
    
        /// <summary>
        /// Gets or Sets PlatformSize
        /// </summary>
        [DataMember(Name="platform_size", EmitDefaultValue=false)]
        public List<double?> PlatformSize { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Material {\n");
            sb.Append("  MaterialId: ").Append(MaterialId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Finishes: ").Append(Finishes).Append("\n");
            sb.Append("  Colors: ").Append(Colors).Append("\n");
            sb.Append("  CustomColors: ").Append(CustomColors).Append("\n");
            sb.Append("  Textures: ").Append(Textures).Append("\n");
            sb.Append("  Sheen: ").Append(Sheen).Append("\n");
            sb.Append("  PlatformSize: ").Append(PlatformSize).Append("\n");
            
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
            return this.Equals(obj as Material);
        }

        /// <summary>
        /// Returns true if Material instances are equal
        /// </summary>
        /// <param name="other">Instance of Material to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Material other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MaterialId == other.MaterialId ||
                    this.MaterialId != null &&
                    this.MaterialId.Equals(other.MaterialId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Finishes == other.Finishes ||
                    this.Finishes != null &&
                    this.Finishes.SequenceEqual(other.Finishes)
                ) && 
                (
                    this.Colors == other.Colors ||
                    this.Colors != null &&
                    this.Colors.SequenceEqual(other.Colors)
                ) && 
                (
                    this.CustomColors == other.CustomColors ||
                    this.CustomColors != null &&
                    this.CustomColors.SequenceEqual(other.CustomColors)
                ) && 
                (
                    this.Textures == other.Textures ||
                    this.Textures != null &&
                    this.Textures.SequenceEqual(other.Textures)
                ) && 
                (
                    this.Sheen == other.Sheen ||
                    this.Sheen != null &&
                    this.Sheen.SequenceEqual(other.Sheen)
                ) && 
                (
                    this.PlatformSize == other.PlatformSize ||
                    this.PlatformSize != null &&
                    this.PlatformSize.SequenceEqual(other.PlatformSize)
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
                
                if (this.MaterialId != null)
                    hash = hash * 59 + this.MaterialId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Finishes != null)
                    hash = hash * 59 + this.Finishes.GetHashCode();
                
                if (this.Colors != null)
                    hash = hash * 59 + this.Colors.GetHashCode();
                
                if (this.CustomColors != null)
                    hash = hash * 59 + this.CustomColors.GetHashCode();
                
                if (this.Textures != null)
                    hash = hash * 59 + this.Textures.GetHashCode();
                
                if (this.Sheen != null)
                    hash = hash * 59 + this.Sheen.GetHashCode();
                
                if (this.PlatformSize != null)
                    hash = hash * 59 + this.PlatformSize.GetHashCode();
                
                return hash;
            }
        }

    }
}
