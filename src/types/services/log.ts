/**
 * Logging serice types enumeration
 */
export enum LogServiceType {
  Silent       = 0x0,
  WindowsEvent = 0x1,
  File         = 0x2,
  Email        = 0x4,
  Database     = 0x8,
  Console      = 0x10,
}
