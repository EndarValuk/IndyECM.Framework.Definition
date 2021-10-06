/**
 * UI form state types.
 * Used in state machine, to handle events, and do consequent actions.
 */
export enum FormStateType {
  DisplayData      = 0,
  UserInput        = 1,
  PostingToBackend = 2,
  Error            = 3,
  Loading          = 4,
}
