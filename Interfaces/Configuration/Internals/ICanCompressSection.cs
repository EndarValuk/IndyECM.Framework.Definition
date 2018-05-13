using System;

namespace IndyECM.Framework.Definition.Interfaces.Configuration
{
  ///<summary>
  /// Compression configuration section
  ///</summary>
  public interface ICanCompressSection
  {
    ///<summary>
    /// Is compression enabled?
    ///</summary>
    bool CompressionEnabled { get; set; }
  }
}