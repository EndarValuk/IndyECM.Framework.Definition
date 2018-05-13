using System;

namespace IndyECM.Framework.Definition.Interfaces.Configuration
{
  ///<summary>
  /// Cache configuration section
  ///</summary>
  public interface ICanCacheSection
  {
    ///<summary>
    /// Is cache enabled?
    ///</summary>
    bool CachingEnabled { get; set; }

    ///<summary>
    /// Cache timeout
    ///</summary>
    TimeSpan CacheTimeOut { get; set; }
  }
}