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
    public partial class QuoteOptions :  IEquatable<QuoteOptions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteOptions" /> class.
        /// Initializes a new instance of the <see cref="QuoteOptions" />class.
        /// </summary>
        /// <param name="Processes">Processes.</param>
        /// <param name="TimeStamp">TimeStamp.</param>

        public QuoteOptions(List<Process> Processes = null, string TimeStamp = null)
        {
            this.Processes = Processes;
            this.TimeStamp = TimeStamp;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Processes
        /// </summary>
        [DataMember(Name="processes", EmitDefaultValue=false)]
        public List<Process> Processes { get; set; }
    
        /// <summary>
        /// Gets or Sets TimeStamp
        /// </summary>
        [DataMember(Name="time_stamp", EmitDefaultValue=false)]
        public string TimeStamp { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuoteOptions {\n");
            sb.Append("  Processes: ").Append(Processes).Append("\n");
            sb.Append("  TimeStamp: ").Append(TimeStamp).Append("\n");
            
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
            return this.Equals(obj as QuoteOptions);
        }

        /// <summary>
        /// Returns true if QuoteOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of QuoteOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Processes == other.Processes ||
                    this.Processes != null &&
                    this.Processes.SequenceEqual(other.Processes)
                ) && 
                (
                    this.TimeStamp == other.TimeStamp ||
                    this.TimeStamp != null &&
                    this.TimeStamp.Equals(other.TimeStamp)
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
                
                if (this.Processes != null)
                    hash = hash * 59 + this.Processes.GetHashCode();
                
                if (this.TimeStamp != null)
                    hash = hash * 59 + this.TimeStamp.GetHashCode();
                
                return hash;
            }
        }

    }
}
