using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinAzureApp.Model;
using XamarinAzureApp.Service;

namespace XamarinAzureApp.ViewModel
{
    class NewViewModel : BindableObject
    {

        //private AzureService service = new AzureService();
        private Ciudades ciudad = new Ciudades();

        public NewViewModel()
        {
            Nombre = "Ciudad";
            Imagen = "http://www.allspaintravel.com/wp-content/uploads/2017/11/madrid-overview-sunsetovermadrid-xlarge.jpg";
            Descripcion = "Descripcion";
        }

        public ICommand comandoAdd => new Command(x => addCiudadAsync(ciudad));

        private String nombre;

        public String Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
                OnPropertyChanged();
                ciudad.Name = nombre;
            }
        }

        private String imagen;

        public String Imagen
        {
            get => imagen;
            set
            {
                imagen = value;
                OnPropertyChanged();
                ciudad.Image = imagen;
            }
        }

        private String descripcion;

        public String Descripcion
        {
            get => descripcion;
            set
            {
                descripcion = value;
                OnPropertyChanged();
                ciudad.Description = descripcion;
            }
        }

        private async void addCiudadAsync(Ciudades ciudadsel)
        {

            //await service.addCiudadesAsync(ciudadsel);
            await AzureService.Instance.addCiudadesAsync(ciudadsel);

        }

    }
}
