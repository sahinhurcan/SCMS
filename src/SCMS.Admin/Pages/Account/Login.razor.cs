using SCMS.Shared;
using Microsoft.AspNetCore.WebUtilities;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SCMS.Admin.Pages.Account
{
	public partial class Login
	{
		public bool showError = false;
		public LoginModel model = new LoginModel { Email = "", Password = "" };

        public async Task LoginUser()
		{
            var returnUrl = "admin/";
            var uri = _navigationManager.ToAbsoluteUri(_navigationManager.Uri);

            if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("returnUrl", out var param))
                returnUrl = param.First();

            var result = await Http.PostAsJsonAsync<LoginModel>("api/author/login", model);

			if (result.IsSuccessStatusCode)
			{
				showError = false;
				_navigationManager.NavigateTo(returnUrl, true);
			}
			else
			{
				showError = true;
				StateHasChanged();
			}
		}
	}
}
