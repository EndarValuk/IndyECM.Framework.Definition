/**
 * API host supported response types enumeration
 */
export enum ApiResponseType {
  /**
   * API will serve response as <see>application/json</see>
   */
  Json     = 0,
  /**
   * API will serve response as <see>application/xml</see>
   */
  Xml      = 1,
  /**
   * API will serve response as <see>application/bson</see>
   */
  Bson     = 2,
  /**
   * API will serve response as <see>application/msgpack</see>
   */
  MsgPack  = 3,
  /**
   * API will serve response as <see>application/x-protobuf</see>
   */
  ProtoBuf = 4,
}
