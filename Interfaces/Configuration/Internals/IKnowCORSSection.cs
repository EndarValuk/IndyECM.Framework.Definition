namespace IndyECM.Framework.Definition.Interfaces.Configuration
{
  ///<summary>
  /// CORS configuration section for API hosting
  ///</summary>
  public interface IKnowCORSSection
  {
    ///<summary>
    /// Allowed origins for CORS-requests
    ///</summary>
    string AllowedOrigins { get; set; }

    ///<summary>
    /// Allowed headers for CORS-requests
    ///</summary>
    string AllowedHeaders { get; set; }

    ///<summary>
    /// Allowed methods for CORS-requests
    ///</summary>
    string AllowedMethods { get; set; }
  }
}