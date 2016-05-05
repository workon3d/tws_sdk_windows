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
    public partial class Process :  IEquatable<Process>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Process" /> class.
        /// Initializes a new instance of the <see cref="Process" />class.
        /// </summary>
        /// <param name="ProcessId">ProcessId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Category">Category.</param>
        /// <param name="IsInstant">IsInstant.</param>
        /// <param name="Categories">Categories.</param>
        /// <param name="Materials">Materials.</param>
        /// <param name="Qualities">Qualities.</param>
        /// <param name="LeadTimes">LeadTimes.</param>
        /// <param name="AdditionalGroups">AdditionalGroups.</param>

        public Process(int? ProcessId = null, string Name = null, string Category = null, bool? IsInstant = null, List<Category> Categories = null, List<Material> Materials = null, List<Quality> Qualities = null, List<LeadTime> LeadTimes = null, List<AdditionalOptions> AdditionalGroups = null)
        {
            this.ProcessId = ProcessId;
            this.Name = Name;
            this.Category = Category;
            this.IsInstant = IsInstant;
            this.Categories = Categories;
            this.Materials = Materials;
            this.Qualities = Qualities;
            this.LeadTimes = LeadTimes;
            this.AdditionalGroups = AdditionalGroups;
            
        }
        
    
        /// <summary>
        /// Gets or Sets ProcessId
        /// </summary>
        [DataMember(Name="process_id", EmitDefaultValue=false)]
        public int? ProcessId { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }
    
        /// <summary>
        /// Gets or Sets IsInstant
        /// </summary>
        [DataMember(Name="is_instant", EmitDefaultValue=false)]
        public bool? IsInstant { get; set; }
    
        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<Category> Categories { get; set; }
    
        /// <summary>
        /// Gets or Sets Materials
        /// </summary>
        [DataMember(Name="materials", EmitDefaultValue=false)]
        public List<Material> Materials { get; set; }
    
        /// <summary>
        /// Gets or Sets Qualities
        /// </summary>
        [DataMember(Name="qualities", EmitDefaultValue=false)]
        public List<Quality> Qualities { get; set; }
    
        /// <summary>
        /// Gets or Sets LeadTimes
        /// </summary>
        [DataMember(Name="lead_times", EmitDefaultValue=false)]
        public List<LeadTime> LeadTimes { get; set; }
    
        /// <summary>
        /// Gets or Sets AdditionalGroups
        /// </summary>
        [DataMember(Name="additional_groups", EmitDefaultValue=false)]
        public List<AdditionalOptions> AdditionalGroups { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Process {\n");
            sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  IsInstant: ").Append(IsInstant).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Materials: ").Append(Materials).Append("\n");
            sb.Append("  Qualities: ").Append(Qualities).Append("\n");
            sb.Append("  LeadTimes: ").Append(LeadTimes).Append("\n");
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
            return this.Equals(obj as Process);
        }

        /// <summary>
        /// Returns true if Process instances are equal
        /// </summary>
        /// <param name="other">Instance of Process to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Process other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.IsInstant == other.IsInstant ||
                    this.IsInstant != null &&
                    this.IsInstant.Equals(other.IsInstant)
                ) && 
                (
                    this.Categories == other.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(other.Categories)
                ) && 
                (
                    this.Materials == other.Materials ||
                    this.Materials != null &&
                    this.Materials.SequenceEqual(other.Materials)
                ) && 
                (
                    this.Qualities == other.Qualities ||
                    this.Qualities != null &&
                    this.Qualities.SequenceEqual(other.Qualities)
                ) && 
                (
                    this.LeadTimes == other.LeadTimes ||
                    this.LeadTimes != null &&
                    this.LeadTimes.SequenceEqual(other.LeadTimes)
                ) && 
                (
                    this.AdditionalGroups == other.AdditionalGroups ||
                    this.AdditionalGroups != null &&
                    this.AdditionalGroups.SequenceEqual(other.AdditionalGroups)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                
                if (this.IsInstant != null)
                    hash = hash * 59 + this.IsInstant.GetHashCode();
                
                if (this.Categories != null)
                    hash = hash * 59 + this.Categories.GetHashCode();
                
                if (this.Materials != null)
                    hash = hash * 59 + this.Materials.GetHashCode();
                
                if (this.Qualities != null)
                    hash = hash * 59 + this.Qualities.GetHashCode();
                
                if (this.LeadTimes != null)
                    hash = hash * 59 + this.LeadTimes.GetHashCode();
                
                if (this.AdditionalGroups != null)
                    hash = hash * 59 + this.AdditionalGroups.GetHashCode();
                
                return hash;
            }
        }

    }
}
