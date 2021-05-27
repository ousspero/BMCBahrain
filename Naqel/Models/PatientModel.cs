using BMSBahrain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BMSBahrain.Models
{
    public class PatientModel: BaseViewModel
    {
        public string Id { get; set; }
        public bool IsFirstVisit { get; set; }
        public string DiseaseName { get; set; }
        public string DiseaseDescription { get; set; }
        public DateTime ProblemDay { get; set; }
        public bool IsTakenMedicine { get; set; }
        public string Medicine { get; set; }
        public string MedicineImageUrl { get; set; }
        public bool HaveAllergy { get; set; }
        public string AllergyDescription { get; set; }
        public bool HaveRegularMedicine { get; set; }
        public DateTime LastVisit { get; set; }
        public bool IsImproved { get; set; }
        public double ImprovmentPercentage { get; set; }

        public string LastMedicineImage { get => _LastMedicineImage; set => SetProperty(ref _LastMedicineImage , value); }

        string _LastMedicineImage;    
    }
}
