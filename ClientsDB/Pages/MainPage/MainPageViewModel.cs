using ClientsDB.BaseClasses_Interfaces;
using ClientsDB.Entities;

namespace ClientsDB.Pages.MainPage
{
    [QueryProperty(nameof(WorkerType), "WorkerType")]
    public class MainPageViewModel : BaseViewModel
    {
		private string _workerType;
		public string WorkerType
		{
			get
			{
				return _workerType;
			}
			set
			{
				_workerType = value;
				OnPropertyChanged(nameof(WorkerType));
				SetWorker();
			}
		}

		private IWorker _worker;


		private void SetWorker()
		{
			if (_worker == null && WorkerType != string.Empty)
			{
				_worker = (_workerType == "consultant")? new Consultant() : new Manager();
			}
		}
	}
}
