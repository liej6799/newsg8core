#pragma checksum "/home/joesy/Development/aural/newsg8core/newsg8core/newsg8core/Shared/LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e30e853933461735a9dfef72343d4c39861d38a"
// <auto-generated/>
#pragma warning disable 1591
namespace newsg8core.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/joesy/Development/aural/newsg8core/newsg8core/newsg8core/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/joesy/Development/aural/newsg8core/newsg8core/newsg8core/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/joesy/Development/aural/newsg8core/newsg8core/newsg8core/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/joesy/Development/aural/newsg8core/newsg8core/newsg8core/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/joesy/Development/aural/newsg8core/newsg8core/newsg8core/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/joesy/Development/aural/newsg8core/newsg8core/newsg8core/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/joesy/Development/aural/newsg8core/newsg8core/newsg8core/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/joesy/Development/aural/newsg8core/newsg8core/newsg8core/_Imports.razor"
using newsg8core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/joesy/Development/aural/newsg8core/newsg8core/newsg8core/_Imports.razor"
using newsg8core.Shared;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\n        ");
                __builder2.OpenElement(3, "a");
                __builder2.AddAttribute(4, "href", "Identity/Account/Manage");
                __builder2.AddContent(5, "Hello, ");
                __builder2.AddContent(6, 
#nullable restore
#line 3 "/home/joesy/Development/aural/newsg8core/newsg8core/newsg8core/Shared/LoginDisplay.razor"
                                                  context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(7, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\n        ");
                __builder2.AddMarkupContent(9, "<form method=\"post\" action=\"Identity/Account/LogOut\">\n            <button type=\"submit\" class=\"nav-link btn btn-link\">Log out</button>\n        </form>\n    ");
            }
            ));
            __builder.AddAttribute(10, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\n        ");
                __builder2.AddMarkupContent(12, "<a href=\"Identity/Account/Register\">Register</a>\n        ");
                __builder2.AddMarkupContent(13, "<a href=\"Identity/Account/Login\">Log in</a>\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
