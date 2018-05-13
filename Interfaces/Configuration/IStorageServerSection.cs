namespace IndyECM.Framework.Definition.Interfaces.Configuration
{
  ///<summary>
  /// Base storage server section model
  ///</summary>
  ///<typeparam name="T">Type of storage supported variants</typeparam>
  public interface IStorageServerSection<T> : ICanStoreDataSection<T>, ICanConnectSection, ICanAuthSection
  {
  }
}