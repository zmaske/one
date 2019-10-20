#pragma checksum "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb8553c7b21ef13c0217777d3849a423d5cf3422"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace one.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\_Imports.razor"
using one;

#line default
#line hidden
#line 7 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\_Imports.razor"
using one.Shared;

#line default
#line hidden
#line 2 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
using System.Security.Cryptography;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/wellen")]
    public partial class Wellen : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 37 "C:\Users\saven\Desktop\Maske_one\3.1\one\src\one\Pages\Wellen.razor"
 
    double V { get; set; }
    double T { get; set; }
    double L { get; set; }
    double b { get; set; }
    double H { get; set; }
    const double e = Math.E;
    const double pi = Math.PI;
    bool help { get; set; }
    bool bgiv { get; set; }
    bool hgiv { get; set; }
    double C { get; set; }
    double z { get; set; }
    double f { get; set; }
    double hs { get; set; }
    double ho { get; set; }
    double h10 { get; set; }
    double hm { get; set; }
    double v { get; set; }
    double bws { get; set; }
    double h { get; set; }
    double i { get; set; }

    double p(double x,double y)
    {
        return Math.Pow(x, y);
    }

    double ln(double x)
    {
        return Math.Log(x);
    }

    double th(double x)
    {
        return (p(e,x)-p(e,-x))/(p(e,x)+p(e,-x));
    }

    double r(double x)
    {
        return Math.Round(x, 2);
    }


    void Calc()
    {
        if (!bgiv) { b=0; }
        if (!hgiv) { h=0; }
        z = 0.546 * p(V, 1.23) * th(2.54 * p(T, 0.375) / p(V, 0.923)) * th(0.102 * p(L, 1.0 / 3.0) / (p(V, 0.82) * th(2.54 * p(T, 0.375) / p(V, 0.923))));
        f = 1 / z;
        hs = 0.0145 * p(V, 2.46) * th(5.75 * p(T, 0.75) / p(V, 1.845)) * th(0.029 * p(L, 0.5) / (p(V, 1.23) * th(5.75 * p(T, 0.75) / p(V, 1.845))));
        ho = hs / 2;
        h10 = 1.3 * hs;
        hm = 2 * hs;
        double g = 6.67408 * Math.Pow(10, 13) * 5.972 / (Math.Pow((6371000 / (1 + 0.002665 * Math.Cos(2 * Math.PI * b / 180)) + H), 2));
        v = p(g * th(2 * pi * f) / (2 * pi * f * f), 0.5);
        if (v / f < 20 * T) { C = v; }
        else { C=p(g *T,0.5);}
        bws = hs / 1.3;
        h = C * z;
        i = h / 2;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
