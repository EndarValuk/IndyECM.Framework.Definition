using IndyECM.Framework.Definition.Enumeration.Types;

namespace IndyECM.Framework.Definition.Interface.Entity
{
  ///<summary>
  /// Basic convention about object in application
  ///</summary>
  public interface IAmObject
  {
    #region Properties

    ///<summary>
    /// Type of object
    ///</summary>
    ///<remarks>Used enumeration: <see cref="ObjectType"/></remarks>
    ObjectType ObjectType { get; set; }

    ///<summary>
    /// Subtype of object
    ///</summary>
    ///<remarks>Used enumeration: <see cref="ObjectSubType"/></remarks>
    ObjectSubType ObjectSubType { get; set; }

    #endregion
  }

  ///<summary>
  /// Basic convention about object in application
  ///</summary>
  ///<typeparam name="TKey">Type of the unique identifier</typeparam>
  public interface IAmObject<TKey> : IAmObject
  {
    #region Properties

    ///<summary>
    /// Unique object identifier
    ///</summary>
    TKey ObjectGuid { get; set; }

    #endregion
  }
}