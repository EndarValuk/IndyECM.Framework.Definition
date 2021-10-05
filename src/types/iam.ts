/**
 * Identity and access management supported service types enumeration
 */
export enum IamServiceType
{
  /**
   * Always use anonymous access
   */
  None,
  /**
   * ActiveDirectory based
   */
  ActiveDirectory,
  /**
   * LDAP based
   */
  LDAP,
  /**
   * DataStorage based
   */
  DataStorage,
  /**
   * OAuth based
   */
  OAuth,
}