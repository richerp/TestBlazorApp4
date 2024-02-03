# BlazorApp4

File Counter.razor.cs like this:

public partial class Counter : ComponentBase
    {
        protected override Task OnInitializedAsync()
        {
            var path = httpContextAccessor.HttpContext.Request.Path;

            //the path is equal to "/_blazor"
            //why is not equals to "/Counter" ?
            //and how can i get the HttpContext.Request.Path and HttpContext.Request.Headers ???
            //because i want get the HttpContext.Request.Headers["Bearer xxxx"] for the httpclient

            //my purpose is:
            //myinfo.JwtToken = await httpContextAccessor.HttpContext.GetTokenAsync(JwtBearerDefaults.AuthenticationScheme, "access_token");

            int a = myinfo.Id;

            myinfo.Name = httpContextAccessor.HttpContext.Request.Path;

            
            return base.OnInitializedAsync();
        }

        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                int a = myinfo.Id;

                //var httpClient = new HttpClient();
                //httpClient.BaseAddress =new Uri( "xxxx");

                //var contentType = new MediaTypeWithQualityHeaderValue("application/json");
                //httpClient.DefaultRequestHeaders.Accept.Add(contentType);
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", myinfo.JwtToken);

            }

            return base.OnAfterRenderAsync(firstRender);
        }
    }


    how can i get the HttpContext.Request.Path and HttpContext.Request.Headers ???
    because i want get the HttpContext.Request.Headers["Bearer xxxx"] for the httpclient
