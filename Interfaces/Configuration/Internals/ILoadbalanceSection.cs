using System;

namespace IndyECM.Framework.Definition.Interfaces.Configuration
{
  ///<summary>
  /// Base multithreaded pooling section model
  ///</summary>
  public interface ILoadbalanceSection
  {
    ///<summary>
    /// Min count of pool threads
    ///</summary>
    int MinimalSize { get; set; }

    ///<summary>
    /// Max count of pool threads
    ///</summary>
    int MaximalSize { get; set; }

    ///<summary>
    /// Loadbalance timeout
    ///</summary>
    TimeSpan LoadBalanceTimeout { get; set; }
  }
}