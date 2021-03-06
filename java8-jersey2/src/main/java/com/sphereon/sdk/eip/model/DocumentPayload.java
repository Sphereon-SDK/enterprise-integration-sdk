/*
 * Enterprise Integration API
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.1
 * Contact: dev@sphereon.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.sphereon.sdk.eip.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonValue;
import com.sphereon.sdk.eip.model.DocumentDetails;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;

/**
 * A document payload containing file info and meta data.
 */
@ApiModel(description = "A document payload containing file info and meta data.")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-10-05T11:35:42.383+02:00")
public class DocumentPayload {
  @JsonProperty("documentDetails")
  private DocumentDetails documentDetails = null;

  /**
   * The markup type of the meta data payload
   */
  public enum MetaDataPayloadTypeEnum {
    JSON("JSON"),
    
    XML("XML");

    private String value;

    MetaDataPayloadTypeEnum(String value) {
      this.value = value;
    }

    @JsonValue
    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    @JsonCreator
    public static MetaDataPayloadTypeEnum fromValue(String text) {
      for (MetaDataPayloadTypeEnum b : MetaDataPayloadTypeEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }
  }

  @JsonProperty("metaDataPayloadType")
  private MetaDataPayloadTypeEnum metaDataPayloadType = null;

  @JsonProperty("metaDataPayload")
  private String metaDataPayload = null;

  public DocumentPayload documentDetails(DocumentDetails documentDetails) {
    this.documentDetails = documentDetails;
    return this;
  }

   /**
   * A structure containing details about the document name, size, data or data location etc.
   * @return documentDetails
  **/
  @ApiModelProperty(value = "A structure containing details about the document name, size, data or data location etc.")
  public DocumentDetails getDocumentDetails() {
    return documentDetails;
  }

  public void setDocumentDetails(DocumentDetails documentDetails) {
    this.documentDetails = documentDetails;
  }

  public DocumentPayload metaDataPayloadType(MetaDataPayloadTypeEnum metaDataPayloadType) {
    this.metaDataPayloadType = metaDataPayloadType;
    return this;
  }

   /**
   * The markup type of the meta data payload
   * @return metaDataPayloadType
  **/
  @ApiModelProperty(value = "The markup type of the meta data payload")
  public MetaDataPayloadTypeEnum getMetaDataPayloadType() {
    return metaDataPayloadType;
  }

  public void setMetaDataPayloadType(MetaDataPayloadTypeEnum metaDataPayloadType) {
    this.metaDataPayloadType = metaDataPayloadType;
  }

  public DocumentPayload metaDataPayload(String metaDataPayload) {
    this.metaDataPayload = metaDataPayload;
    return this;
  }

   /**
   * The meta data payload
   * @return metaDataPayload
  **/
  @ApiModelProperty(value = "The meta data payload")
  public String getMetaDataPayload() {
    return metaDataPayload;
  }

  public void setMetaDataPayload(String metaDataPayload) {
    this.metaDataPayload = metaDataPayload;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DocumentPayload documentPayload = (DocumentPayload) o;
    return Objects.equals(this.documentDetails, documentPayload.documentDetails) &&
        Objects.equals(this.metaDataPayloadType, documentPayload.metaDataPayloadType) &&
        Objects.equals(this.metaDataPayload, documentPayload.metaDataPayload);
  }

  @Override
  public int hashCode() {
    return Objects.hash(documentDetails, metaDataPayloadType, metaDataPayload);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DocumentPayload {\n");
    
    sb.append("    documentDetails: ").append(toIndentedString(documentDetails)).append("\n");
    sb.append("    metaDataPayloadType: ").append(toIndentedString(metaDataPayloadType)).append("\n");
    sb.append("    metaDataPayload: ").append(toIndentedString(metaDataPayload)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
  
}

