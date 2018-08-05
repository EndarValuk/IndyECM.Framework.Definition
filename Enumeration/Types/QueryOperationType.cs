namespace IndyECM.Framework.Definition.Enumeration.Types
{
  ///<summary>
  /// Query operation types
  ///</summary>
  public enum QueryOperationType
  {
    ///<summary>
    /// Simple table query operation
    ///</summary>
    Table,
    ///<summary>
    /// Prepared parametrized query operation
    ///</summary>
    AdHocQuery,
    ///<summary>
    /// Create operation. Usually procedure or function
    ///</summary>
    Create,
  }
}