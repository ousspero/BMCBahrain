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
        public ICommand UploadMedicineCommand { get; set; }
        public string UploadSource { get => uploadSource; set => SetProperty(ref uploadSource, value); }
        public string UploadMedicine { get => uploadMedicine; set => SetProperty(ref uploadMedicine, value); }


        string uploadSource;
        string uploadMedicine;

        public PatientInfoViewModel()
        {
            UploadImageCommand = new Command(UploadImageAction);
            UploadMedicineCommand = new Command(UploadMedicineAction);
        }

        private async void UploadMedicineAction(object obj)
        {
            var imageFile = await MediaPicker.PickPhotoAsync(new MediaPickerOptions { Title = "pick medicine" });
            UploadMedicine = imageFile.FullPath;
        }

        private async void UploadImageAction(object obj)
        {
            var imageFile = await MediaPicker.PickPhotoAsync(new MediaPickerOptions { Title = "pick image" });
            UploadSource = imageFile.FullPath;
        }
    }
}
