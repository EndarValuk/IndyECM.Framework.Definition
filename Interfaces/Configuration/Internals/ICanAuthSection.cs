using System.Runtime.Serialization;

namespace IndyECM.Framework.Definition.Interfaces.Configuration
{
  ///<summary>
  /// Base auth section model
  ///</summary>
  public interface ICanAuthSection
  {
    ///<summary>
    /// Account name, used to identify context user
    ///</summary>
    string Account { get; set; }

    ///<summary>
    /// Accounts password
    ///</summary>
    string Password { get; set; }
  }
}