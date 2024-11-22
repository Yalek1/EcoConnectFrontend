using EcoConnectFrontend.Models;
using EcoConnectFrontend.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EcoConnectFrontend.ViewModels
{
    public class InstitutionsViewModel
    {
        private static InstitutionsViewModel _instance;
        public static InstitutionsViewModel Instance => _instance ??= new InstitutionsViewModel();

        private readonly InstitutionService _service;

        public ObservableCollection<Institution> Institutions { get; set; } = new ObservableCollection<Institution>();

        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public InstitutionsViewModel()
        {
            _service = new InstitutionService();

            AddCommand = new Command(OnAddInstitution);
            EditCommand = new Command(OnEditInstitution);
            DeleteCommand = new Command(OnDeleteInstitution);

            LoadInstitutions();
        }

        private async void LoadInstitutions()
        {
            var institutions = await _service.GetInstitutionsAsync();
            foreach (var institution in institutions)
            {
                Institutions.Add(institution);
            }
        }

        private void OnAddInstitution()
        {
            // Lógica para agregar una institución
        }

        private void OnEditInstitution()
        {
            // Lógica para editar una institución
        }

        private void OnDeleteInstitution()
        {
            // Lógica para eliminar una institución
        }
    }
}
