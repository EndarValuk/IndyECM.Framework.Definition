namespace IndyECM.Framework.Definition.Enumeration.Services
{
  ///<summary>
  /// API host supported response types enumeration
  ///</summary>
  public enum ApiResponseType
  {
    ///<summary>
    /// API will serve response as <see>application/json</see>
    ///</summary>
    Json,
    ///<summary>
    /// API will serve response as <see>application/xml</see>
    ///</summary>
    Xml,
    ///<summary>
    /// API will serve response as <see>application/bson</see>
    ///</summary>
    Bson,
    ///<summary>
    /// API will serve response as <see>application/msgpack</see>
    ///</summary>
    MsgPack,
    ///<summary>
    /// API will serve response as <see>application/x-protobuf</see>
    ///</summary>
    ProtoBuf
  }
}