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
    public partial class Quote : IEquatable<Quote>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Quote" /> class.
        /// Initializes a new instance of the <see cref="Quote" />class.
        /// </summary>
        /// <param name="QuoteId">QuoteId.</param>
        /// <param name="CustomerNote">CustomerNote.</param>
        /// <param name="AdditionalNote">AdditionalNote.</param>
        /// <param name="Pdf">Pdf.</param>
        /// <param name="Price">Price.</param>
        /// <param name="LineItems">LineItems.</param>
        /// <param name="Attachments">Attachments.</param>
        /// <param name="OrderInfo">OrderInfo.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="UpdatedAt">UpdatedAt.</param>

        public Quote(int? QuoteId = null, string CustomerNote = null, string AdditionalNote = null, string Pdf = null, Price Price = null, List<LineItem> LineItems = null, List<Attachment> Attachments = null, QuoteOrderInfo OrderInfo = null, string CreatedAt = null, string UpdatedAt = null)
        {
            this.QuoteId = QuoteId;
            this.CustomerNote = CustomerNote;
            this.AdditionalNote = AdditionalNote;
            this.Pdf = Pdf;
            this.Price = Price;
            this.LineItems = LineItems;
            this.Attachments = Attachments;
            this.OrderInfo = OrderInfo;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;

        }


        /// <summary>
        /// Gets or Sets QuoteId
        /// </summary>
        [DataMember(Name = "quote_id", EmitDefaultValue = false)]
        public int? QuoteId { get; set; }

        /// <summary>
        /// Gets or Sets CustomerNote
        /// </summary>
        [DataMember(Name = "customer_note", EmitDefaultValue = false)]
        public string CustomerNote { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalNote
        /// </summary>
        [DataMember(Name = "additional_note", EmitDefaultValue = false)]
        public string AdditionalNote { get; set; }

        /// <summary>
        /// Gets or Sets Pdf
        /// </summary>
        [DataMember(Name = "pdf", EmitDefaultValue = false)]
        public string Pdf { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public Price Price { get; set; }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name = "line_items", EmitDefaultValue = false)]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets OrderInfo
        /// </summary>
        [DataMember(Name = "order_info", EmitDefaultValue = false)]
        public QuoteOrderInfo OrderInfo { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "temporary_user_token", EmitDefaultValue = false)]
        public string TemporaryUserToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quote {\n");
            sb.Append("  QuoteId: ").Append(QuoteId).Append("\n");
            sb.Append("  CustomerNote: ").Append(CustomerNote).Append("\n");
            sb.Append("  AdditionalNote: ").Append(AdditionalNote).Append("\n");
            sb.Append("  Pdf: ").Append(Pdf).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  OrderInfo: ").Append(OrderInfo).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");

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
            return this.Equals(obj as Quote);
        }

        /// <summary>
        /// Returns true if Quote instances are equal
        /// </summary>
        /// <param name="other">Instance of Quote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Quote other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.QuoteId == other.QuoteId ||
                    this.QuoteId != null &&
                    this.QuoteId.Equals(other.QuoteId)
                ) &&
                (
                    this.CustomerNote == other.CustomerNote ||
                    this.CustomerNote != null &&
                    this.CustomerNote.Equals(other.CustomerNote)
                ) &&
                (
                    this.AdditionalNote == other.AdditionalNote ||
                    this.AdditionalNote != null &&
                    this.AdditionalNote.Equals(other.AdditionalNote)
                ) &&
                (
                    this.Pdf == other.Pdf ||
                    this.Pdf != null &&
                    this.Pdf.Equals(other.Pdf)
                ) &&
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) &&
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) &&
                (
                    this.Attachments == other.Attachments ||
                    this.Attachments != null &&
                    this.Attachments.SequenceEqual(other.Attachments)
                ) &&
                (
                    this.OrderInfo == other.OrderInfo ||
                    this.OrderInfo != null &&
                    this.OrderInfo.Equals(other.OrderInfo)
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

                if (this.QuoteId != null)
                    hash = hash * 59 + this.QuoteId.GetHashCode();

                if (this.CustomerNote != null)
                    hash = hash * 59 + this.CustomerNote.GetHashCode();

                if (this.AdditionalNote != null)
                    hash = hash * 59 + this.AdditionalNote.GetHashCode();

                if (this.Pdf != null)
                    hash = hash * 59 + this.Pdf.GetHashCode();

                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();

                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();

                if (this.Attachments != null)
                    hash = hash * 59 + this.Attachments.GetHashCode();

                if (this.OrderInfo != null)
                    hash = hash * 59 + this.OrderInfo.GetHashCode();

                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();

                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();

                return hash;
            }
        }

    }
}
