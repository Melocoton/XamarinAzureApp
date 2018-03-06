using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using XamarinAzureApp.Model;

namespace XamarinAzureApp.Service
{
    class AzureService
    {

        private readonly MobileServiceClient _client = new MobileServiceClient("https://melocotonnode.azurewebsites.net");
        private IMobileServiceTable<Ciudades> _table;
        private static AzureService _instance;

        private List<Ciudades> listaCiudades;

        public static AzureService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AzureService();
                }

                return _instance;
            }
        }

        public AzureService()
        {
            _table = _client.GetTable<Ciudades>();
        }

        public async Task<List<Ciudades>> cargarCiudadesAsync()
        {  
            return await _table.ToListAsync();
        }

        public async Task borrarCiudadAsync(Ciudades ciudad)
        {
            await _table.DeleteAsync(ciudad);
        }

        public async Task addCiudadesAsync(Ciudades ciudad)
        {
            if (string.IsNullOrEmpty(ciudad.id))
            {
                await _table.InsertAsync(ciudad);
            }
            else
            {
                await _table.UpdateAsync(ciudad);
            }
        }

    }
}
