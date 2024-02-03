using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;
using System.Security.Cryptography.Xml;

namespace BlazorApp4.Components.Pages
{
    public partial class Counter : ComponentBase
    {
        protected override Task OnInitializedAsync()
        {
            int a = myinfo.Id;

            myinfo.Name = httpContextAccessor.HttpContext.Request.Path;

            
            return base.OnInitializedAsync();
        }

        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                int a = myinfo.Id;
            }

            return base.OnAfterRenderAsync(firstRender);
        }
    }
}
