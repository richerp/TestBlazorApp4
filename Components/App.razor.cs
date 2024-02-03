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

namespace BlazorApp4.Components
{
    public partial class App : ComponentBase, IDisposable
    {
        async protected override Task OnInitializedAsync()
        {
            myinfo.Id = 10000;



            //return base.OnInitializedAsync();
        }

        public void Dispose()
        {

        }
    }
}
