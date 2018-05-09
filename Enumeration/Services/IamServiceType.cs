namespace IndyECM.Framework.Definition.Enumeration.Services
{
  ///<summary>
  /// Identity and access management supported service types enumeration
  ///</summary>
  public enum IamServiceType
  {
    ///<summary>
    /// Always use anonymous access
    ///</summary>
    None,
    ///<summary>
    /// ActiveDirectory based
    ///</summary>
    ActiveDirectory,
    ///<summary>
    /// LDAP based
    ///</summary>
    LDAP,
    ///<summary>
    /// DataStorage based
    ///</summary>
    DataStorage,
    ///<summary>
    /// OAuth based
    ///</summary>
    OAuth,
  }
}