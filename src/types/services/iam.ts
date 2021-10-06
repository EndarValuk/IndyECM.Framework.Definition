/**
 * Identity and access management supported service types enumeration
 */
export enum IamServiceType {
  /**
   * Always use anonymous access
   */
  None            = 0,
  /**
   * ActiveDirectory based
   */
  ActiveDirectory = 1,
  /**
   * LDAP based
   */
  LDAP            = 2,
  /**
   * DataStorage based
   */
  DataStorage     = 3,
  /**
   * OAuth based
   */
  OAuth           = 4,
}
