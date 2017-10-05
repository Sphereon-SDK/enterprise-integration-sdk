# EnterpriseIntegrationApi.IngestionResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**requestTime** | **Date** | The request date/time for this document in ISO 8601 format | [optional] 
**deliveryTime** | **Date** | The delivery date/time of this job in ISO 8601 format | [optional] 
**documentId** | **String** |  | [optional] 
**deliveryStatus** | **String** | The deliveryStatus of the document | 
**statusMessage** | **String** | A delivery status message, which can be informational, warning or error. A message here does not indicate an error per se | [optional] 


<a name="DeliveryStatusEnum"></a>
## Enum: DeliveryStatusEnum


* `CREATED` (value: `"CREATED"`)

* `QUEUED` (value: `"QUEUED"`)

* `ON_HOLD` (value: `"ON_HOLD"`)

* `PROCESSING` (value: `"PROCESSING"`)

* `DELIVERED` (value: `"DELIVERED"`)

* `ERROR` (value: `"ERROR"`)




