namespace IndyECM.Framework.Definition.Interfaces.Configuration
{
  ///<summary>
  /// Multiple storage server connection configuration section
  ///</summary>
  ///<typeparam name="T">Type of storage supported variants</typeparam>
  public interface IReliableStorageServerSection<T>
  {
    ///<summary>
    /// Main storage server connection settings
    ///</summary>
    IStorageServerSection<T> Main { get; set; }

    ///<summary>
    /// Reserve storage server connection settings
    ///</summary>
    IStorageServerSection<T> Fallback { get; set; }

    ///<summary>
    /// Cache storage server connection settings
    ///</summary>
    IStorageServerSection<T> Cache { get; set; }
  }
}