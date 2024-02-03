# BlazorApp4

In program.cs:

services.AddScoped<MyInfo>();

then, in App.razor.cs,I let myinfo.Id = 10000;

 async protected override Task OnInitializedAsync()
        {
            myinfo.Id = 10000;



            //return base.OnInitializedAsync();
        }

then, in Counter.razor.cs, Why myinfo.Id is 0?

 protected override Task OnInitializedAsync()
        {
            int a = myinfo.Id;

            myinfo.Name = httpContextAccessor.HttpContext.Request.Path;

            
            return base.OnInitializedAsync();
        }

How can i get the myinfo.Id in Counter.razor.cs???

