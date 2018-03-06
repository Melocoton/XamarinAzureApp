using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinAzureApp.Model;
using XamarinAzureApp.Service;
using XamarinAzureApp.View;

namespace XamarinAzureApp.ViewModel
{
    class MainViewModel : BindableObject
    {
        //private readonly AzureService _azureService = new AzureService();
        private readonly NavigationService _navigationService = new NavigationService();

        public MainViewModel()
        {
            cargarCiudades();
            //listaCiudades = new ObservableCollection<Ciudades>(new AzureService().cargarCiudadesAsync());
        }

        private async void cargarCiudades()
        {
            List<Ciudades> lista = await AzureService.Instance.cargarCiudadesAsync();
            ListaCiudades = new ObservableCollection<Ciudades>(lista);
        }

        public ICommand comandoNuevo => new Command(x => _navigationService.NavigateForward(new NewPage()));
        public ICommand comandoActualizar => new Command(cargarCiudades);

        private ObservableCollection<Ciudades> listaCiudades;

        public ObservableCollection<Ciudades> ListaCiudades
        {
            get => listaCiudades;
            set
            {
                listaCiudades = value;
                OnPropertyChanged();
            }
        }

        private Ciudades ciudadSeleccionada;

        public Ciudades CiudadSeleccionada
        {
            get => ciudadSeleccionada;
            set
            {
                ciudadSeleccionada = value;
                OnPropertyChanged();
                try
                {
                    Application.Current.MainPage.Navigation.PushAsync(new DetailPage(ciudadSeleccionada));
                }
                catch (Exception)
                {
                    
                }
            }
        }

    }
}
