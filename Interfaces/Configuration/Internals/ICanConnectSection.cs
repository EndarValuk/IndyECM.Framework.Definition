using System;

namespace IndyECM.Framework.Definition.Interfaces.Configuration
{
  ///<summary>
  /// Base connection section model
  ///</summary>
  public interface ICanConnectSection
  {
    ///<summary>
    /// Host name/address to listen on/connect to
    ///</summary>
    string Server { get; set; }

    ///<summary>
    /// Host port to listen on/connect to
    ///</summary>
    int Port { get; set; }

    ///<summary>
    /// Connection timeout
    ///</summary>
    TimeSpan ConnectTimeout { get; set; }
  }
}