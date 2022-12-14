using AspNetIdentityDemo.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AspNetIdentityDemo.Client
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegisterWindow : Page
    {
        public RegisterWindow()
        {
            this.InitializeComponent();
        }

        private async void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();

            var model = new RegisterViewModel
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                ConfirmPassword = txtConfirmPassword.Text,
            };

            var jsonData = JsonConvert.SerializeObject(model);

            var content = new StringContent(jsonData, Encoding.UTF8, "Application/Json");
            var response = await client.PostAsync("http://localhost:2994/api/Auth/Register", content);
            var responseBody = await response.Content.ReadAsStringAsync();
                
            var responseObject = JsonConvert.DeserializeObject<UserManagerResponse>(responseBody);

            if (responseObject.IsSuccess)
            {
                var dialog = new MessageDialog("Your account has been created successfuly!");
                await dialog.ShowAsync();
            }
            else
            {
                var dialog = new MessageDialog(responseObject.Errors.FirstOrDefault());
                await dialog.ShowAsync();

            }

        }

    }
}
