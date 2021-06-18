using SCMS.Shared;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SCMS.Admin.Pages.Account
{
	public partial class Register
	{
		public bool showError = false;
		public RegisterModel model = new RegisterModel { Name = "", Email = "", Password = "", PasswordConfirm = "" };

		public async Task RegisterUser()
		{
			var result = await Http.PostAsJsonAsync<RegisterModel>("api/author/register", model);

			if (result.IsSuccessStatusCode)
			{
				showError = false;
				_navigationManager.NavigateTo("admin/", true);
			}
			else
			{
				showError = true;
				StateHasChanged();
			}
		}
	}
}
