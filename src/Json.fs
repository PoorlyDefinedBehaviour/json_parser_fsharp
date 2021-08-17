module Json

type Value =
  | Int of int
  | Float of float
  | List of Value list
