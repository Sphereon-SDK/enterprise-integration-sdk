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
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import com.sphereon.sdk.eip.model.StreamLocation;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * A structure containing details about the document name, size, data or data location etc.
 */
@ApiModel(description = "A structure containing details about the document name, size, data or data location etc.")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-10-05T11:38:50.794+02:00")
public class DocumentDetails {
  @SerializedName("fileName")
  private String fileName = null;

  @SerializedName("streamLocation")
  private StreamLocation streamLocation = null;

  @SerializedName("fileSize")
  private Long fileSize = null;

  @SerializedName("contentType")
  private String contentType = null;

  public DocumentDetails fileName(String fileName) {
    this.fileName = fileName;
    return this;
  }

   /**
   * The original file name
   * @return fileName
  **/
  @ApiModelProperty(value = "The original file name")
  public String getFileName() {
    return fileName;
  }

  public void setFileName(String fileName) {
    this.fileName = fileName;
  }

  public DocumentDetails streamLocation(StreamLocation streamLocation) {
    this.streamLocation = streamLocation;
    return this;
  }

   /**
   * The storage location of the binary stream
   * @return streamLocation
  **/
  @ApiModelProperty(required = true, value = "The storage location of the binary stream")
  public StreamLocation getStreamLocation() {
    return streamLocation;
  }

  public void setStreamLocation(StreamLocation streamLocation) {
    this.streamLocation = streamLocation;
  }

  public DocumentDetails fileSize(Long fileSize) {
    this.fileSize = fileSize;
    return this;
  }

   /**
   * The file size / stream length
   * @return fileSize
  **/
  @ApiModelProperty(value = "The file size / stream length")
  public Long getFileSize() {
    return fileSize;
  }

  public void setFileSize(Long fileSize) {
    this.fileSize = fileSize;
  }

  public DocumentDetails contentType(String contentType) {
    this.contentType = contentType;
    return this;
  }

   /**
   * The content type of the document
   * @return contentType
  **/
  @ApiModelProperty(value = "The content type of the document")
  public String getContentType() {
    return contentType;
  }

  public void setContentType(String contentType) {
    this.contentType = contentType;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DocumentDetails documentDetails = (DocumentDetails) o;
    return Objects.equals(this.fileName, documentDetails.fileName) &&
        Objects.equals(this.streamLocation, documentDetails.streamLocation) &&
        Objects.equals(this.fileSize, documentDetails.fileSize) &&
        Objects.equals(this.contentType, documentDetails.contentType);
  }

  @Override
  public int hashCode() {
    return Objects.hash(fileName, streamLocation, fileSize, contentType);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DocumentDetails {\n");
    
    sb.append("    fileName: ").append(toIndentedString(fileName)).append("\n");
    sb.append("    streamLocation: ").append(toIndentedString(streamLocation)).append("\n");
    sb.append("    fileSize: ").append(toIndentedString(fileSize)).append("\n");
    sb.append("    contentType: ").append(toIndentedString(contentType)).append("\n");
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

