# Computation Expressions

A block of code that can be customized. It is mainly used for:

- async/task
- queries (query expression in C#)
- generating collections/enumerables
- validation
- error handling
- testing
- code generation
- etc

## Generating Collections

```fsharp
seq {
	yield! [1..10]
	for i in [1..10] do yield square i
}
```

## Query

```fsharp
query {
	for student in db.Student do
	where (student.StudentId > 4)
	sortBy student.Name
	select student
}
```

## Anonymous Records

```fsharp
let someppl = {| Name="Patricia"; Email="patricia@gmail.com" |}
```


