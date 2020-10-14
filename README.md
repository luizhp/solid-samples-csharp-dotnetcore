[![GPLv3 License](https://img.shields.io/badge/License-GPL%20v3-yellow.svg)](https://opensource.org/licenses/) [![Open Source](https://badges.frapsoft.com/os/v1/open-source.svg?v=103)](https://opensource.org/)

# SOLID samples in C# .NET Core

Here are code examples of each SOLID principle written in C# with .NET Core

### [Single Responsibility Principle][single-responsibility-principle]

Every module, class or function in a computer program should have responsibility over a single part of that program's functionality, which it should encapsulate.

The reason it is important to keep a class focused on a single concern is that it makes the class more robust.

### [Open-Closed Principle][open-closed principle]

Software entities should be open for extension but closed for modification.

The risk of changing an existing class is that you will introduce an inadvertent change in behaviour.

The solution is create another class that overrides the behaviour of the original class.

By following the OCP, a component is more likely to contain maintainable and re-usable code.

### [Liskov Substitution Principle][liskov-substitution-principle]

Child classes should never break the parent class’ type definitions.

The concept of this principle was introduced by Barbara Liskov in a 1987 conference keynote and later published in a paper together with Jeannette Wing in 1994.

As simple as that, a subclass should override the parent class methods in a way that does not break functionality from a client’s point of view.

### [Interface Segregation Principle][interface-segregation-principle]

It is quite common to find that an interface is in essence just a description of an entire class.

The ISP states that we should write a series of smaller and more specific interfaces that are implemented by the class.

Each interface provides an single behavior.

### [Dependency Inversion Principle][dependency-inversion-principle]

The DIP simply states that high-level classes shouldn’t depend on low-level components, but instead depend on an abstraction.

## References

Adapted from [Solid Principles with TypeScript] by [Samuele Resca]

## Contributing

Contributions are always welcome! 👊

You can reach me out at Twitter [@luizhp](https://twitter.com/luizhp)

## Show your support

Give a ⭐️ if this project helped you!

## License

Copyright © 2020 [.luizhp](https://github.com/luizhp)

This project is [GPL v3][license] licensed.

[solid principles with typescript]: https://samueleresca.net/solid-principles-using-typescript/
[samuele resca]: https://github.com/samueleresca
[license]: https://github.com/luizhp/solid-samples-csharp-dotnetcore/blob/master/license
[single-responsibility-principle]: https://github.com/luizhp/solid-samples-csharp-dotnetcore/blob/master/SOLID01SingleResponsibilityPrinciple/Program.cs
[open-closed principle]: https://github.com/luizhp/solid-samples-csharp-dotnetcore/blob/master/SOLID02OpenClosedPrinciple/Program.cs
[liskov-substitution-principle]: https://github.com/luizhp/solid-samples-csharp-dotnetcore/blob/master/SOLID03LiskovSubstitutionPrinciple/Program.cs
[interface-segregation-principle]: https://github.com/luizhp/solid-samples-csharp-dotnetcore/blob/master/SOLID04InterfaceSegregationPrinciple/Program.cs
[dependency-inversion-principle]: https://github.com/luizhp/solid-samples-csharp-dotnetcore/blob/master/SOLID05DependencyInversionPrinciple/Program.cs
