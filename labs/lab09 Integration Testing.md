# Lab 9 - Integration Testing

As with most code, testing is important. Your GraphQL endpoints included. For testing to be successful, tests should be:

- **isolated** - tests don't affect each other
- **repeatable** - test results are always the same (if code doesn't change)
- **understandable** - just like regular code
- **structured** - just like regular code
- **easy** - make the hurdle as simple as possible for developers to write tests

**Integration test a few of your entrypoints**. A few interesting scenarios:

- testing whether the schema remains unchanged
- testing the happy path - whether data is returned correctly with/without mock data
  - this will probably include implementing mocks with mock data
- testing for exceptions

You'll probably need packages:

- `Moq`, `NSubstitute` or `FakeItEasy` for mocking
- `Snapshooter` for the test framework you're using for snapshot matching
