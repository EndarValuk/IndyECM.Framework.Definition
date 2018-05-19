namespace IndyECM.Framework.Definition.Enumeration.Types
{
  ///<summary>
  /// Object types enumeration used as documents/entities
  ///</summary>
  public enum ObjectType
  {
    ///<summary>
    /// Generic object type, used to define any of the object types
    ///</summary>
    Generic = -1,
    ///<summary>
    /// Сontract, which is concluded between two business units/counteragents
    ///</summary>
    Contract = 0,
    ///<summary>
    /// Primary document, particually, incoming invoice
    ///</summary>
    PrimaryDocument = 1,
    ///<summary>
    /// Extension for contract, changing dates, amounts, etc.
    ///</summary>
    ContractExtension = 2,
    ///<summary>
    /// Business unit
    ///</summary>
    BusinessUnit = 3,
    ///<summary>
    /// Counteragent
    ///</summary>
    Counteragent = 3,
    ///<summary>
    /// Payment order
    ///</summary>
    PaymentOrder = 4,
    ///<summary>
    /// User, living human entity, working in our application
    ///</summary>
    User = 5,
    ///<summary>
    /// Task, assigned to a resource, usually to a user
    ///</summary>
    Task = 6,
  }
}