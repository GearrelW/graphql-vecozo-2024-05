# Lab 15 - N+1

Add a `Console.WriteLine()` in the `GetById()` method in your `BlogRepository`. If you then execute this query:

```gql
query {
  a: blogById(id: "b1") {
    title
  }
  b: blogById(id: "b1") {
    title
  }
  c: blogById(id: "b1") {
    title
  }
}
```

You'll notice `a`, `b` and `c` are all calling the repository, meaning we're also calling our data source 3 times.

Fix this by implementing a `BatchDataLoader`. If all went well, your `Console.WriteLine()` should only be called once.
