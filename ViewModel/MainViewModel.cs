using HOYA_SIM.ViewModel.RealTimeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HOYA_SIM.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel baseViewModel;

        public BaseViewModel SelectedViewModel
        {
            get => baseViewModel;
            set => SetProperty(ref baseViewModel, value, nameof(SelectedViewModel));
        }

        #region ICommand
        // Command to Excute when click a Button


        public ICommand Loaded { get; set; }
        public ICommand Unloaded { get; set; }
        public ICommand Connect { get; set; }
        #endregion


        #region Model
        public static READ_PLC DataPLC = new READ_PLC("192.168.0.15", 0, 1);

        #endregion
        #region Variable
        
        MainViewModel main;
        Simulation_Temp_ViewModel Simulation_Temp_ViewModel = Simulation_Temp_ViewModel.INS_SIMULATION_TEMP_VIEWMODEL;
        #endregion

        public MainViewModel()
        {
            main = this;
            main.SelectedViewModel = Simulation_Temp_ViewModel;
            Loaded = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
               // DataPLC = new READ_PLC("192.168.0.15", 0, 1);
            });
            Connect = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                DataPLC.ConnectPLC();
                _ = System.Windows.Forms.MessageBox.Show("Connected");
                DataPLC.Start_Read_Array_RealData(5, 0, 8);
                
            });
        }
    }
}
