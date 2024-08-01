using Blazored.SessionStorage;
using Domain.DTO_Models;
using Domain.Models;
using Microsoft.AspNetCore.Components;

namespace CustomerUI.Components.Layout
{
    public partial class NavBar
    {
        [Inject]
        public ISessionStorageService session { get; set; }

        //protected override async Task OnInitializedAsync()
        //{

        //    var check = await session.GetItemAsync<LoginResponse>("UserInfo");
        //}

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                var check = await session.GetItemAsync<LoginResponse>("UserInfo");
                StateHasChanged(); // Notify the component to re-render
            }
        }


    }
}
