using System;

namespace IndyECM.Framework.Definition.Enumeration.Types
{
  ///<summary>
  /// Enumeration of operation result types
  ///</summary>
  ///<remarks>
  /// Describes main result types and combinations of them.
  /// E.g. to describe an error, throwed at notification service connection,
  /// error name will looks like: "SuccessType"+"ServiceType"+"OperationType"+"ResultType".
  /// In that case we should use:
  ///</remarks>
  ///<example>
  /// <code>
  /// ErrorNotificationConnectionDenied = Error | Notification | Connection | Denied,
  /// </code>
  ///</example>
  [Flags]
  public enum OperationResultType
  {
#region Success result types

    ///<summary>
    /// No result yet
    ///</summary>
    NoResultYet                    = 1 << 0,
    ///<summary>
    /// Successful result
    ///</summary>
    Success                        = 1 << 1,
    ///<summary>
    /// Error
    ///</summary>
    Error                          = 1 << 2,

#endregion

#region Service types

    ///<summary>
    /// Database service
    ///</summary>
    Database                       = 1 << 3,
    ///<summary>
    /// Filestorage service
    ///</summary>
    FileService                    = 1 << 4,
    ///<summary>
    /// API service
    ///</summary>
    ApiService                     = 1 << 5,
    ///<summary>
    /// Auth service
    ///</summary>
    AuthService                    = 1 << 6,
    ///<summary>
    /// Memory related
    ///</summary>
    Memory                         = 1 << 7,
    ///<summary>
    /// Notification service
    ///</summary>
    Notification                   = 1 << 8,
    ///<summary>
    /// Configuration service
    ///</summary>
    Configuration                  = 1 << 9,

#endregion

#region Type of operations

    ///<summary>
    /// Connection stage
    ///</summary>
    Connection                     = 1 << 10,
    ///<summary>
    /// Access stage
    ///</summary>
    Access                         = 1 << 11,
    ///<summary>
    /// Read operation
    ///</summary>
    Read                           = 1 << 12,
    ///<summary>
    /// Create operation
    ///</summary>
    Create                         = 1 << 13,
    ///<summary>
    /// Update operation
    ///</summary>
    Update                         = 1 << 14,
    ///<summary>
    /// Patch operation
    ///</summary>
    Patch                          = 1 << 15,
    ///<summary>
    /// Delete operation
    ///</summary>
    Delete                         = 1 << 16,

#endregion

#region Operation result types

    ///<summary>
    /// Entry not found
    ///</summary>
    NotFound                       = 1 << 17,
    ///<summary>
    /// Same entry exists
    ///</summary>
    Exists                         = 1 << 18,
    ///<summary>
    /// Operation Not Yet Implemented
    ///</summary>
    NYI                            = 1 << 19,
    ///<summary>
    /// Bad input values
    ///</summary>
    BadInput                       = 1 << 20,
    ///<summary>
    /// Unknown error
    ///</summary>
    Unknown                        = 1 << 21,
    ///<summary>
    /// Access to operation denied
    ///</summary>
    Denied                         = 1 << 22,

#endregion

#region Result combinations

  #region Working with API

    ///<summary>
    /// Generic API service error
    ///</summary>
    ErrorApiService                = Error | ApiService,

  #endregion

  #region Working with configuration files

    ErrorConfigurationAccess       = Error | Configuration | Access,
    ErrorConfigurationRead         = Error | Configuration | Read,
    ErrorConfigurationReadNotFound = ErrorConfigurationRead | NotFound,
    ErrorConfigurationReadBadInput = ErrorConfigurationRead | BadInput,

  #endregion

  #region Working with data storage

    ErrorDatabaseConnection        = Error | Database | Connection,
    ErrorDatabaseAccess            = Error | Database | Access,

    ErrorDatabaseRead              = Error | Database | Read,
    ErrorDatabaseReadNotFound      = ErrorDatabaseRead | NotFound,
    ErrorDatabaseReadBadInput      = ErrorDatabaseRead | BadInput,
    ErrorDatabaseReadNYI           = ErrorDatabaseRead | NYI,
    ErrorDatabaseReadDenied        = ErrorDatabaseRead | Denied,

    ErrorDatabaseCreate            = Error | Database | Create,
    ErrorDatabaseCreateExists      = ErrorDatabaseCreate | Exists,
    ErrorDatabaseCreateBadInput    = ErrorDatabaseCreate | BadInput,
    ErrorDatabaseCreateNYI         = ErrorDatabaseCreate | NYI,

    ErrorDatabaseUpdate            = Error | Database | Update,
    ErrorDatabaseUpdateNotFound    = ErrorDatabaseUpdate | NotFound,
    ErrorDatabaseUpdateBadInput    = ErrorDatabaseUpdate | BadInput,
    ErrorDatabaseUpdateNYI         = ErrorDatabaseUpdate | NYI,

    ErrorDatabasePatch             = Error | Database | Patch,
    ErrorDatabasePatchNotFound     = ErrorDatabasePatch | NotFound,
    ErrorDatabasePatchBadInput     = ErrorDatabasePatch | BadInput,
    ErrorDatabasePatchNYI          = ErrorDatabasePatch | NYI,

    ErrorDatabaseDelete            = Error | Database | Delete,
    ErrorDatabaseDeleteNotFound    = ErrorDatabaseDelete | NotFound,
    ErrorDatabaseDeleteBadInput    = ErrorDatabaseDelete | BadInput,
    ErrorDatabaseDeleteNYI         = ErrorDatabaseDelete | NYI,

  #endregion

  #region Working with file storage

    ///<summary>
    /// Generic Fileservice error
    ///</summary>
    ErrorFileService               = Error | FileService,
    ErrorFileServiceAccess         = ErrorFileService | Access,
    ErrorFileServiceCreate         = ErrorFileService | Create,

  #endregion

#endregion
  }
}