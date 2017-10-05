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
    /// A structure containing details about the document name, size, data or data location etc.
    /// </summary>
    [DataContract]
    public partial class DocumentDetails :  IEquatable<DocumentDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentDetails" /> class.
        /// </summary>
        /// <param name="FileName">The original file name.</param>
        /// <param name="StreamLocation">The storage location of the binary stream (required).</param>
        /// <param name="FileSize">The file size / stream length.</param>
        /// <param name="ContentType">The content type of the document.</param>
        public DocumentDetails(string FileName = default(string), StreamLocation StreamLocation = default(StreamLocation), long? FileSize = default(long?), string ContentType = default(string))
        {
            // to ensure "StreamLocation" is required (not null)
            if (StreamLocation == null)
            {
                throw new InvalidDataException("StreamLocation is a required property for DocumentDetails and cannot be null");
            }
            else
            {
                this.StreamLocation = StreamLocation;
            }
            this.FileName = FileName;
            this.FileSize = FileSize;
            this.ContentType = ContentType;
        }
        
        /// <summary>
        /// The original file name
        /// </summary>
        /// <value>The original file name</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// The storage location of the binary stream
        /// </summary>
        /// <value>The storage location of the binary stream</value>
        [DataMember(Name="streamLocation", EmitDefaultValue=false)]
        public StreamLocation StreamLocation { get; set; }

        /// <summary>
        /// The file size / stream length
        /// </summary>
        /// <value>The file size / stream length</value>
        [DataMember(Name="fileSize", EmitDefaultValue=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// The content type of the document
        /// </summary>
        /// <value>The content type of the document</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentDetails {\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  StreamLocation: ").Append(StreamLocation).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
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
            return this.Equals(obj as DocumentDetails);
        }

        /// <summary>
        /// Returns true if DocumentDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
                ) && 
                (
                    this.StreamLocation == other.StreamLocation ||
                    this.StreamLocation != null &&
                    this.StreamLocation.Equals(other.StreamLocation)
                ) && 
                (
                    this.FileSize == other.FileSize ||
                    this.FileSize != null &&
                    this.FileSize.Equals(other.FileSize)
                ) && 
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
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
                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();
                if (this.StreamLocation != null)
                    hash = hash * 59 + this.StreamLocation.GetHashCode();
                if (this.FileSize != null)
                    hash = hash * 59 + this.FileSize.GetHashCode();
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();
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
