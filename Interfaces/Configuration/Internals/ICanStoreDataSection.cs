using System.Collections.Generic;

namespace IndyECM.Framework.Definition.Interfaces.Configuration
{
  ///<summary>
  /// Base storage section model
  ///</summary>
  ///<typeparam name="T">Type of storage supported variants</typeparam>
  public interface ICanStoreDataSection<T>
  {
    ///<summary>
    /// Storage connection provider
    ///</summary>
    T Type { get; set; }

    ///<summary>
    /// Storage catalogue
    ///<remarks>
    /// For database it should be database name.
    /// If we are using LDAP-container, we need to set here root canonical domain name.
    ///</remarks>
    ///</summary>
    string Catalogue { get; set; }

    ///<summary>
    /// Storage scheme
    ///<remarks>
    /// For database storage it should be database version.
    /// If we are using LDAP-container, we need to set here root canonical domain container.
    ///</remarks>
    ///</summary>
    string Scheme { get; set; }

    ///<summary>
    /// Provider specific extended properties
    ///</summary>
    ///<returns>Returns dictionary of extended properties</returns>
    Dictionary<T, Dictionary<string, string>> ExtendedProperties { get; set; }
  }
}