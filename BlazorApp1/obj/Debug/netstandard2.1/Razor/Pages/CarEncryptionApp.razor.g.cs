#pragma checksum "C:\Users\Tim Chiu\OneDrive\coding\VisualStudio\2020\catEncyption-Web\BlazorApp1\Pages\CarEncryptionApp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "777f66354beb80e97bc164870f8a541e6c93e51f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Tim Chiu\OneDrive\coding\VisualStudio\2020\catEncyption-Web\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tim Chiu\OneDrive\coding\VisualStudio\2020\catEncyption-Web\BlazorApp1\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tim Chiu\OneDrive\coding\VisualStudio\2020\catEncyption-Web\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tim Chiu\OneDrive\coding\VisualStudio\2020\catEncyption-Web\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tim Chiu\OneDrive\coding\VisualStudio\2020\catEncyption-Web\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tim Chiu\OneDrive\coding\VisualStudio\2020\catEncyption-Web\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tim Chiu\OneDrive\coding\VisualStudio\2020\catEncyption-Web\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Tim Chiu\OneDrive\coding\VisualStudio\2020\catEncyption-Web\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tim Chiu\OneDrive\coding\VisualStudio\2020\catEncyption-Web\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CarEncryptionApp")]
    public partial class CarEncryptionApp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert-" + (
#nullable restore
#line 3 "C:\Users\Tim Chiu\OneDrive\coding\VisualStudio\2020\catEncyption-Web\BlazorApp1\Pages\CarEncryptionApp.razor"
                   alertLevel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(2, 
#nullable restore
#line 3 "C:\Users\Tim Chiu\OneDrive\coding\VisualStudio\2020\catEncyption-Web\BlazorApp1\Pages\CarEncryptionApp.razor"
                                alertInfo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.AddMarkupContent(4, "<h6>This is plain text box (uncoded)</h6>\r\n");
            __builder.OpenElement(5, "textarea");
            __builder.AddAttribute(6, "style", "width:600px;height:200px;");
            __builder.AddAttribute(7, "title", "plainTextBox");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\Tim Chiu\OneDrive\coding\VisualStudio\2020\catEncyption-Web\BlazorApp1\Pages\CarEncryptionApp.razor"
                                                                        plainText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => plainText = __value, plainText));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddContent(10, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.AddMarkupContent(12, "<h6> </h6>\r\n\r\n");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Tim Chiu\OneDrive\coding\VisualStudio\2020\catEncyption-Web\BlazorApp1\Pages\CarEncryptionApp.razor"
                  encodeText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Text -> Meow");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Tim Chiu\OneDrive\coding\VisualStudio\2020\catEncyption-Web\BlazorApp1\Pages\CarEncryptionApp.razor"
                  decodeText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Meow -> Text");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Tim Chiu\OneDrive\coding\VisualStudio\2020\catEncyption-Web\BlazorApp1\Pages\CarEncryptionApp.razor"
                  clear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Clear");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.AddMarkupContent(25, "<h6>This is Meow text box (coded)</h6>\r\n");
            __builder.OpenElement(26, "textarea");
            __builder.AddAttribute(27, "style", "width:600px;height:200px;");
            __builder.AddAttribute(28, "title", "meowTextBox");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Tim Chiu\OneDrive\coding\VisualStudio\2020\catEncyption-Web\BlazorApp1\Pages\CarEncryptionApp.razor"
                                                                       codedText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => codedText = __value, codedText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\Tim Chiu\OneDrive\coding\VisualStudio\2020\catEncyption-Web\BlazorApp1\Pages\CarEncryptionApp.razor"
 
    private string Meow = "喵";

    private string alertLevel = "light";
    private string alertInfo = "";

    private string plainText = "";

    private string codedText = "";


    private void encodeText()
    {
        clearErrorMessage();

        try
        {
            codedText = catEncryption.encrypt(plainText, Meow);//encode it and give it to coded text box
        }
        catch
        {
            //nothing have to be done if user did not enter anything...
            giveAlert("Empty Content");
        }
    }

    private void decodeText()
    {
        clearErrorMessage();
        try
        {
            plainText = catEncryption.decode(codedText, Meow);// decode it and give it to plain text box
        }
        catch
        {
            if (codedText.Length != 0 && codedText.Replace(" ", "").Length != 0)
            {
                giveAlert("Decode Error. \nThis can cause by not-make-sense-ciphertext \n" +
                    "(Meow code should only consist of, 1, Meow or 喵, 2, space, 3, !)\n" +
                    "or empty ciphertext");
            }
            else giveAlert("Empty Content");
        }
    }

    private void clear()
    {
        plainText = "";
        codedText = "";
        clearErrorMessage();
    }

    private void clearErrorMessage()
    {
        //clear error info if it exists
        if (alertLevel == "danger")
        {
            alertLevel = "light";
            alertInfo = " ";
        }
    }

    private void giveAlert(string info)
    {
        alertLevel = "danger";
        alertInfo = info;
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
