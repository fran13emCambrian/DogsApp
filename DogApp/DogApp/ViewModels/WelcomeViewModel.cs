using System;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DogsApp.ViewModels
{
    class WelcomeViewModel : BaseViewModel
    {
        public ICommand OpenGoogleCommand { get; }
        public ICommand OpenDogsAPICommand { get; }

        public WelcomeViewModel()
        {
            Title = "Welcome";

            OpenGoogleCommand = new AsyncCommand(OpenGoogle);
            OpenDogsAPICommand = new AsyncCommand(OpenDogsAPI);
        }

        private async Task OpenGoogle()
        {
            await Browser.OpenAsync("https://www.google.com");
        }

        private async Task OpenDogsAPI()
        {
            var service = DependencyService.Get<IWebClientService>();
            var content = await service.GetString("https://dog.ceo/api/breeds/list/all");
            var emailService = DependencyService.Get<IEmailClientService>();
            var response = emailService.SendEmail("toperson", "fromthisperson", "subject", "body");
        }

    }

}