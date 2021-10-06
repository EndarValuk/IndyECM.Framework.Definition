/**
 * Notification serice types enumeration
 */
 export enum NotificationServiceType {
  Silent            = 0x0,
  SMTP              = 0x1,
  MicrosoftExchange = 0x2,
  InstantMessenger  = 0x4,
  SMS               = 0x8,
  Console           = 0x10,
  DatabaseMail      = 0x20,
}
