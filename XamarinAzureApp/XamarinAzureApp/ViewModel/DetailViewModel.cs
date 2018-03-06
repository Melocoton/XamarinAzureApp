using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinAzureApp.Model;
using XamarinAzureApp.Service;
using XamarinAzureApp.View;

namespace XamarinAzureApp.ViewModel
{
    class DetailViewModel : BindableObject
    {

        //private AzureService _service = new AzureService();
        public DetailViewModel(Ciudades ciudad)
        {
            CiudadSeleccionada = ciudad;
        }

        public ICommand comandoEliminar => new Command(x => borrarCiudadAsync());

        private async void borrarCiudadAsync()
        {
            //await _service.borrarCiudadAsync(ciudadSeleccionada);
            await AzureService.Instance.borrarCiudadAsync(ciudadSeleccionada);
        }

        private Ciudades ciudadSeleccionada;

        public Ciudades CiudadSeleccionada
        {
            get => ciudadSeleccionada;
            set
            {
                ciudadSeleccionada = value;
                OnPropertyChanged();
            }
        }

    }
}
