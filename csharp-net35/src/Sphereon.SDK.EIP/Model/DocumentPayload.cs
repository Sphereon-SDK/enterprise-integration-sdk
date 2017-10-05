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
    /// A document payload containing file info and meta data.
    /// </summary>
    [DataContract]
    public partial class DocumentPayload :  IEquatable<DocumentPayload>
    {
        /// <summary>
        /// The markup type of the meta data payload
        /// </summary>
        /// <value>The markup type of the meta data payload</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MetaDataPayloadTypeEnum
        {
            
            /// <summary>
            /// Enum JSON for "JSON"
            /// </summary>
            [EnumMember(Value = "JSON")]
            JSON,
            
            /// <summary>
            /// Enum XML for "XML"
            /// </summary>
            [EnumMember(Value = "XML")]
            XML
        }

        /// <summary>
        /// The markup type of the meta data payload
        /// </summary>
        /// <value>The markup type of the meta data payload</value>
        [DataMember(Name="metaDataPayloadType", EmitDefaultValue=false)]
        public MetaDataPayloadTypeEnum? MetaDataPayloadType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentPayload" /> class.
        /// </summary>
        /// <param name="DocumentDetails">A structure containing details about the document name, size, data or data location etc..</param>
        /// <param name="MetaDataPayloadType">The markup type of the meta data payload.</param>
        /// <param name="MetaDataPayload">The meta data payload.</param>
        public DocumentPayload(DocumentDetails DocumentDetails = default(DocumentDetails), MetaDataPayloadTypeEnum? MetaDataPayloadType = default(MetaDataPayloadTypeEnum?), string MetaDataPayload = default(string))
        {
            this.DocumentDetails = DocumentDetails;
            this.MetaDataPayloadType = MetaDataPayloadType;
            this.MetaDataPayload = MetaDataPayload;
        }
        
        /// <summary>
        /// A structure containing details about the document name, size, data or data location etc.
        /// </summary>
        /// <value>A structure containing details about the document name, size, data or data location etc.</value>
        [DataMember(Name="documentDetails", EmitDefaultValue=false)]
        public DocumentDetails DocumentDetails { get; set; }


        /// <summary>
        /// The meta data payload
        /// </summary>
        /// <value>The meta data payload</value>
        [DataMember(Name="metaDataPayload", EmitDefaultValue=false)]
        public string MetaDataPayload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentPayload {\n");
            sb.Append("  DocumentDetails: ").Append(DocumentDetails).Append("\n");
            sb.Append("  MetaDataPayloadType: ").Append(MetaDataPayloadType).Append("\n");
            sb.Append("  MetaDataPayload: ").Append(MetaDataPayload).Append("\n");
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
            return this.Equals(obj as DocumentPayload);
        }

        /// <summary>
        /// Returns true if DocumentPayload instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentPayload other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocumentDetails == other.DocumentDetails ||
                    this.DocumentDetails != null &&
                    this.DocumentDetails.Equals(other.DocumentDetails)
                ) && 
                (
                    this.MetaDataPayloadType == other.MetaDataPayloadType ||
                    this.MetaDataPayloadType != null &&
                    this.MetaDataPayloadType.Equals(other.MetaDataPayloadType)
                ) && 
                (
                    this.MetaDataPayload == other.MetaDataPayload ||
                    this.MetaDataPayload != null &&
                    this.MetaDataPayload.Equals(other.MetaDataPayload)
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
                if (this.DocumentDetails != null)
                    hash = hash * 59 + this.DocumentDetails.GetHashCode();
                if (this.MetaDataPayloadType != null)
                    hash = hash * 59 + this.MetaDataPayloadType.GetHashCode();
                if (this.MetaDataPayload != null)
                    hash = hash * 59 + this.MetaDataPayload.GetHashCode();
                return hash;
            }
        }

    }

}
