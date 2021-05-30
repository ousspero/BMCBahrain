using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.IO;
using BMSBahrain.Models;

namespace BMSBahrain.ViewModels
{
    public class PatientInfoViewModel : BaseViewModel
    {
        public ICommand UploadImageCommand { get; set; }
        public ICommand UploadMedicineCommand { get; set; }
        public string UploadMedicine { get => uploadMedicine; set => SetProperty(ref uploadMedicine, value); }
        public PatientModel PatientModel { get => _patientModel; set => SetProperty(ref _patientModel, value); }


        PatientModel _patientModel;

        string uploadMedicine;

        public PatientInfoViewModel()
        {
            UploadImageCommand = new Command(UploadImageAction);
            UploadMedicineCommand = new Command(UploadMedicineAction);
            PatientModel = new PatientModel();
        }

        private async void UploadMedicineAction(object obj)
        {
            var imageFile = await MediaPicker.PickPhotoAsync(new MediaPickerOptions { Title = "pick medicine" });
            UploadMedicine = imageFile.FullPath;
        }

        private async void UploadImageAction(object obj)
        {
            var imageFile = await MediaPicker.PickPhotoAsync(new MediaPickerOptions { Title = "pick image" });
            PatientModel.LastMedicineImage = imageFile.FullPath;
        }
    }
}
