/**
 * Query operation types
 */
export enum QueryOperationType {
  /**
   * Simple table query operation
   */
  Table      = 0,
  /**
   * Prepared parametrized query operation
   */
  AdHocQuery = 1,
  /**
   * Procedure or function
   */
  Procedure  = 2,
  /**
   * Bulk insert/delete
   */
  Batch      = 3,
}
