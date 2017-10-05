/* 
 * Enterprise Integration API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.1
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Sphereon.SDK.EIP.Client.SwaggerDateConverter;

namespace Sphereon.SDK.EIP.Model
{
    /// <summary>
    /// The response from the ingestion controller.
    /// </summary>
    [DataContract]
    public partial class IngestionResponse :  IEquatable<IngestionResponse>, IValidatableObject
    {
        /// <summary>
        /// The deliveryStatus of the document
        /// </summary>
        /// <value>The deliveryStatus of the document</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliveryStatusEnum
        {
            
            /// <summary>
            /// Enum CREATED for "CREATED"
            /// </summary>
            [EnumMember(Value = "CREATED")]
            CREATED,
            
            /// <summary>
            /// Enum QUEUED for "QUEUED"
            /// </summary>
            [EnumMember(Value = "QUEUED")]
            QUEUED,
            
            /// <summary>
            /// Enum ONHOLD for "ON_HOLD"
            /// </summary>
            [EnumMember(Value = "ON_HOLD")]
            ONHOLD,
            
            /// <summary>
            /// Enum PROCESSING for "PROCESSING"
            /// </summary>
            [EnumMember(Value = "PROCESSING")]
            PROCESSING,
            
            /// <summary>
            /// Enum DELIVERED for "DELIVERED"
            /// </summary>
            [EnumMember(Value = "DELIVERED")]
            DELIVERED,
            
            /// <summary>
            /// Enum ERROR for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR
        }

        /// <summary>
        /// The deliveryStatus of the document
        /// </summary>
        /// <value>The deliveryStatus of the document</value>
        [DataMember(Name="deliveryStatus", EmitDefaultValue=false)]
        public DeliveryStatusEnum? DeliveryStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IngestionResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IngestionResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IngestionResponse" /> class.
        /// </summary>
        /// <param name="DocumentId">DocumentId.</param>
        public IngestionResponse(string DocumentId = default(string))
        {
            this.DocumentId = DocumentId;
        }
        
        /// <summary>
        /// The request date/time for this document in ISO 8601 format
        /// </summary>
        /// <value>The request date/time for this document in ISO 8601 format</value>
        [DataMember(Name="requestTime", EmitDefaultValue=false)]
        public DateTime? RequestTime { get; private set; }

        /// <summary>
        /// The delivery date/time of this job in ISO 8601 format
        /// </summary>
        /// <value>The delivery date/time of this job in ISO 8601 format</value>
        [DataMember(Name="deliveryTime", EmitDefaultValue=false)]
        public DateTime? DeliveryTime { get; private set; }

        /// <summary>
        /// Gets or Sets DocumentId
        /// </summary>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }


        /// <summary>
        /// A delivery status message, which can be informational, warning or error. A message here does not indicate an error per se
        /// </summary>
        /// <value>A delivery status message, which can be informational, warning or error. A message here does not indicate an error per se</value>
        [DataMember(Name="statusMessage", EmitDefaultValue=false)]
        public string StatusMessage { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IngestionResponse {\n");
            sb.Append("  RequestTime: ").Append(RequestTime).Append("\n");
            sb.Append("  DeliveryTime: ").Append(DeliveryTime).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  DeliveryStatus: ").Append(DeliveryStatus).Append("\n");
            sb.Append("  StatusMessage: ").Append(StatusMessage).Append("\n");
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
            return this.Equals(obj as IngestionResponse);
        }

        /// <summary>
        /// Returns true if IngestionResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of IngestionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IngestionResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RequestTime == other.RequestTime ||
                    this.RequestTime != null &&
                    this.RequestTime.Equals(other.RequestTime)
                ) && 
                (
                    this.DeliveryTime == other.DeliveryTime ||
                    this.DeliveryTime != null &&
                    this.DeliveryTime.Equals(other.DeliveryTime)
                ) && 
                (
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
                ) && 
                (
                    this.DeliveryStatus == other.DeliveryStatus ||
                    this.DeliveryStatus != null &&
                    this.DeliveryStatus.Equals(other.DeliveryStatus)
                ) && 
                (
                    this.StatusMessage == other.StatusMessage ||
                    this.StatusMessage != null &&
                    this.StatusMessage.Equals(other.StatusMessage)
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
                if (this.RequestTime != null)
                    hash = hash * 59 + this.RequestTime.GetHashCode();
                if (this.DeliveryTime != null)
                    hash = hash * 59 + this.DeliveryTime.GetHashCode();
                if (this.DocumentId != null)
                    hash = hash * 59 + this.DocumentId.GetHashCode();
                if (this.DeliveryStatus != null)
                    hash = hash * 59 + this.DeliveryStatus.GetHashCode();
                if (this.StatusMessage != null)
                    hash = hash * 59 + this.StatusMessage.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}