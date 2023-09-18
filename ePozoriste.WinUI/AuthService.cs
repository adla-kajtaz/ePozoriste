using ePozoriste.Model.Requests;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.WinUI
{
    public class AuthService : APIService
    {
        private const string API_ROUTE = "Auth";
        public AuthService() : base(API_ROUTE)
        {

        }

        public async Task<Model.Korisnik> LoginAdmin(LoginRequest request)
        {
            string endpoint = $"{Properties.Settings.Default.ApiURL}/{API_ROUTE}/login/admin";
            try
            {

                var result = await endpoint.PostJsonAsync(request).ReceiveJson<Model.Korisnik>(); ;
                return result;
            }
            catch
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka", "Netačni kredencijali", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
