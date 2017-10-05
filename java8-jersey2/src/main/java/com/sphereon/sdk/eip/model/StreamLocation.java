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
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;

/**
 * Location record of data stream
 */
@ApiModel(description = "Location record of data stream")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-10-05T11:35:42.383+02:00")
public class StreamLocation {
  @JsonProperty("folderPath")
  private String folderPath = null;

  @JsonProperty("originalFileName")
  private String originalFileName = null;

  @JsonProperty("fileName")
  private String fileName = null;

  @JsonProperty("id")
  private String id = null;

  @JsonProperty("containerId")
  private String containerId = null;

  public StreamLocation folderPath(String folderPath) {
    this.folderPath = folderPath;
    return this;
  }

   /**
   * Get folderPath
   * @return folderPath
  **/
  @ApiModelProperty(value = "")
  public String getFolderPath() {
    return folderPath;
  }

  public void setFolderPath(String folderPath) {
    this.folderPath = folderPath;
  }

  public StreamLocation originalFileName(String originalFileName) {
    this.originalFileName = originalFileName;
    return this;
  }

   /**
   * Get originalFileName
   * @return originalFileName
  **/
  @ApiModelProperty(value = "")
  public String getOriginalFileName() {
    return originalFileName;
  }

  public void setOriginalFileName(String originalFileName) {
    this.originalFileName = originalFileName;
  }

  public StreamLocation fileName(String fileName) {
    this.fileName = fileName;
    return this;
  }

   /**
   * Get fileName
   * @return fileName
  **/
  @ApiModelProperty(value = "")
  public String getFileName() {
    return fileName;
  }

  public void setFileName(String fileName) {
    this.fileName = fileName;
  }

   /**
   * Get id
   * @return id
  **/
  @ApiModelProperty(value = "")
  public String getId() {
    return id;
  }

  public StreamLocation containerId(String containerId) {
    this.containerId = containerId;
    return this;
  }

   /**
   * Get containerId
   * @return containerId
  **/
  @ApiModelProperty(value = "")
  public String getContainerId() {
    return containerId;
  }

  public void setContainerId(String containerId) {
    this.containerId = containerId;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    StreamLocation streamLocation = (StreamLocation) o;
    return Objects.equals(this.folderPath, streamLocation.folderPath) &&
        Objects.equals(this.originalFileName, streamLocation.originalFileName) &&
        Objects.equals(this.fileName, streamLocation.fileName) &&
        Objects.equals(this.id, streamLocation.id) &&
        Objects.equals(this.containerId, streamLocation.containerId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(folderPath, originalFileName, fileName, id, containerId);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class StreamLocation {\n");
    
    sb.append("    folderPath: ").append(toIndentedString(folderPath)).append("\n");
    sb.append("    originalFileName: ").append(toIndentedString(originalFileName)).append("\n");
    sb.append("    fileName: ").append(toIndentedString(fileName)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    containerId: ").append(toIndentedString(containerId)).append("\n");
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
