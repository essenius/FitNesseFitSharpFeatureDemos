using System.Diagnostics.CodeAnalysis;

// These warnings are caused by deliberate decisions for demo purposes 
[assembly: SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "X", Scope = "member",
        Target = "TestSlim.DecisionFixture.#X")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Y", Scope = "member",
        Target = "TestSlim.DecisionFixture.#Y()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", Target = "TestSlim.MethodAndProperty.#Id")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "TestSlim.MethodAndProperty.#GetId()")]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "TestSlim.ArrayTest.#ArrayOfArrays")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "TestSlim.ArrayTest.#Array")]
