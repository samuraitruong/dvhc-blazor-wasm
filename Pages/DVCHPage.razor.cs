// FetchData.razor.cs
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using dvhc_wasm.Models;

namespace dvhc_wasm.Pages
{
    public partial class DVCHPage
    {
        private List<DVHCItem> items;

        protected override async Task OnInitializedAsync()
        {
            items = (await httpClient.GetFromJsonAsync<DVHCItem[]>("dvhc/data.json")).ToList();
        }

    }
}