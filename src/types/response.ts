/**
 * API host supported response types enumeration
 */
export enum ApiResponseType
{
  /**
   * API will serve response as <see>application/json</see>
   */
  Json,
  /**
   * API will serve response as <see>application/xml</see>
   */
  Xml,
  /**
   * API will serve response as <see>application/bson</see>
   */
  Bson,
  /**
   * API will serve response as <see>application/msgpack</see>
   */
  MsgPack,
  /**
   * API will serve response as <see>application/x-protobuf</see>
   */
  ProtoBuf
}