module Json

type Value =
  | Int of int
  | Float of float
  | String of string
  | List of Value list
  | Object of Map<string, Value>
