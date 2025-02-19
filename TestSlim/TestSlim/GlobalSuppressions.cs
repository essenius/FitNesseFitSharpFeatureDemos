using System.Diagnostics.CodeAnalysis;

// These warnings are caused by deliberate decisions for demo purposes 

[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "FitNesse takes care of that")]
[assembly: SuppressMessage("Design", "CA1052:Static holder types should be Static or NotInheritable", Justification = "FitSharp cannot find static classes")]
[assembly: SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Demo")]
[assembly: SuppressMessage("Design", "CA1024:Use properties where appropriate", Justification = "Demo", Scope = "member", Target = "~M:TestSlim.MethodAndProperty.GetData~System.Int32")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Demo", Scope = "member", Target = "~P:TestSlim.SubFixture.SubProperty")]
[assembly: SuppressMessage("Naming", "CA1721:Property names should not match get methods", Justification = "Demonstrating FitSharp behavior", Scope = "member", Target = "~P:TestSlim.MethodAndProperty.Data")]
[assembly: SuppressMessage("Usage", "CA2211:Non-constant fields should not be visible", Justification = "Demonstrating FitSharp behavior", Scope = "member", Target = "~F:TestSlim.NamingConventions.PublicStaticField")]
[assembly: SuppressMessage("Design", "CA1051:Do not declare visible instance fields", Justification = "Demonstrating FitSharp behavior", Scope = "member", Target = "~F:TestSlim.NamingConventions.PublicField")]
[assembly: SuppressMessage("Design", "CA1002:Do not expose generic lists", Justification = "Table Table interface")]
