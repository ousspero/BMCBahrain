using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.IO;

namespace BMSBahrain.ViewModels
{
    public class PatientInfoViewModel : BaseViewModel
    {
        public ICommand UploadImageCommand { get; set; }
        public string UploadSource { get => uploadSource; set => SetProperty(ref uploadSource, value); }

        string uploadSource;
        public PatientInfoViewModel()
        {
            UploadImageCommand = new Command(UploadImageAction);
        }

        private async void UploadImageAction(object obj)
        {
            var xx = await MediaPicker.CapturePhotoAsync(new MediaPickerOptions { Title = "testtt" });
            string yy =  xx.FullPath;
            UploadSource = yy;
        }
    }
}
