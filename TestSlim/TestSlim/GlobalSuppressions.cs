using System.Diagnostics.CodeAnalysis;

// These warnings are caused by deliberate decisions for demo purposes 

[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "FitNesse takes care of that")]
[assembly: SuppressMessage("Design", "CA1052:Static holder types should be Static or NotInheritable", Justification = "FitSharp cannot find static classes")]
[assembly: SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Demo")]
[assembly: SuppressMessage("Design", "CA1024:Use properties where appropriate", Justification = "Demo", Scope = "member", Target = "~M:TestSlim.MethodAndProperty.GetData~System.Int32")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Demo", Scope = "member", Target = "~P:TestSlim.SubFixture.SubProperty")]
