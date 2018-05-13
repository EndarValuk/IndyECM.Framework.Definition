using System;

namespace IndyECM.Framework.Definition.Interfaces.Configuration
{
  ///<summary>
  /// Base connection limits section model
  ///</summary>
  public interface ICanLimitConnectionsSection
  {
    ///<summary>
    /// Bandwidth throttling in bytes/sec
    ///</summary>
    long BandwidthLimit { get; set; }

    ///<summary>
    /// Connections limit
    ///</summary>
    long ConnectionsLimit { get; set; }
  }
}