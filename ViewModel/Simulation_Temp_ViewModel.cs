using DevExpress.Xpf.Gauges;
using Microsoft.Expression.Interactivity.Core;
using System;
using System.Collections.Generic;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;

namespace HOYA_SIM.ViewModel
{
    public class Simulation_Temp_ViewModel : BaseViewModel
    {
        private static Simulation_Temp_ViewModel myVar;

        public static Simulation_Temp_ViewModel INS_SIMULATION_TEMP_VIEWMODEL
        {
            get
            {
                if (myVar != null)
                {
                    return myVar;
                }
                else
                {
                    myVar = new Simulation_Temp_ViewModel();
                    return myVar;
                }
            }
            set => myVar = value;
        }

        #region Variable
        DispatcherTimer ReadTimer;
        #endregion

        #region Icommand
        //This is the command that will be called when the button is clicked
        public ICommand StartCommand { get; set; }

        public ICommand TestcomCommand { get; set; }
        public ICommand Loaded { get; set; }
        public ICommand Unloaded { get; set; }

        #region Set Tank1
        /// <summary>
        /// Control Tank1
        /// </summary>
        public ICommand Set_SV_1 { get; set; }

        public ICommand Set_OH_1 { get; set; }

        public ICommand Set_OL_1 { get; set; }

        #endregion
        #region Set Tank2
        /// <summary>
        /// Control Tank2
        /// </summary>
        public ICommand Set_SV_2 { get; set; }

        public ICommand Set_OH_2 { get; set; }

        public ICommand Set_OL_2 { get; set; }

        #endregion
        #region Set Tank3
        /// <summary>
        /// Control Tank3
        /// </summary>
        public ICommand Set_SV_3 { get; set; }

        public ICommand Set_OH_3 { get; set; }

        public ICommand Set_OL_3 { get; set; }

        #endregion
        #region Set Tank4
        /// <summary>
        /// Control Tank4
        /// </summary>
        public ICommand Set_SV_4 { get; set; }

        public ICommand Set_OH_4 { get; set; }

        public ICommand Set_OL_4 { get; set; }

        #endregion
        #region Set Tank5
        /// <summary>
        /// Control Tank5
        /// </summary>
        public ICommand Set_SV_5 { get; set; }

        public ICommand Set_OH_5 { get; set; }

        public ICommand Set_OL_5 { get; set; }

        #endregion

        #region Set Tank6
        /// <summary>
        /// Control Tank6
        /// </summary>
        public ICommand Set_SV_6 { get; set; }

        public ICommand Set_OH_6 { get; set; }

        public ICommand Set_OL_6 { get; set; }

        #endregion

        #region Set Tank7
        /// <summary>
        /// Control Tank7
        /// </summary>
        public ICommand Set_SV_7 { get; set; }

        public ICommand Set_OH_7 { get; set; }

        public ICommand Set_OL_7 { get; set; }

        #endregion

        #region Set Tank8
        /// <summary>
        /// Control Tank8
        /// </summary>
        public ICommand Set_SV_8 { get; set; }

        public ICommand Set_OH_8 { get; set; }

        public ICommand Set_OL_8 { get; set; }

        #endregion

        #region Set Tank1
        /// <summary>
        /// Control Tank1
        /// </summary>
        public ICommand Set_SV_9 { get; set; }

        public ICommand Set_OH_9 { get; set; }

        public ICommand Set_OL_9 { get; set; }

        #endregion

        #region Set Tank10
        /// <summary>
        /// Control Tank10
        /// </summary>
        public ICommand Set_SV_10 { get; set; }

        public ICommand Set_OH_10 { get; set; }

        public ICommand Set_OL_10 { get; set; }

        #endregion

        #region Set Tank1
        /// <summary>
        /// Control Tank1
        /// </summary>
        public ICommand Set_SV_11 { get; set; }

        public ICommand Set_OH_11 { get; set; }

        public ICommand Set_OL_11 { get; set; }

        #endregion
        /// <summary>
        /// Up SV Tank 1 Command
        /// </summary>
        public ICommand T1_SV_Up { get; set; }
        /// <summary>
        /// Down SV Tank 1 Command
        /// </summary>
        public ICommand T1_SV_Down { get; set; }

        /// <summary>
        /// Up SV Tank 2 Command
        /// </summary>
        public ICommand T2_SV_Up { get; set; }
        /// <summary>
        /// Down SV Tank 2 Command
        /// </summary>
        public ICommand T2_SV_Down { get; set; }

        /// <summary>
        /// Up SV Tank 3 Command
        /// </summary>
        public ICommand T3_SV_Up { get; set; }
        /// <summary>
        /// Down SV Tank 3 Command
        /// </summary>
        public ICommand T3_SV_Down { get; set; }

        /// <summary>
        /// Up SV Tank 4 Command
        /// </summary>
        public ICommand T4_SV_Up { get; set; }
        /// <summary>
        /// Down SV Tank 4 Command
        /// </summary>
        public ICommand T4_SV_Down { get; set; }

        /// <summary>
        /// Up SV Tank 5 Command
        /// </summary>
        public ICommand T5_SV_Up { get; set; }
        /// <summary>
        /// Down SV Tank 5 Command
        /// </summary>
        public ICommand T5_SV_Down { get; set; }

        /// <summary>
        /// Up SV Tank 6 Command
        /// </summary>
        public ICommand T6_SV_Up { get; set; }
        /// <summary>
        /// Down SV Tank 6 Command
        /// </summary>
        public ICommand T6_SV_Down { get; set; }

        /// <summary>
        /// Up SV Tank 7 Command
        /// </summary>
        public ICommand T7_SV_Up { get; set; }
        /// <summary>
        /// Down SV Tank 7 Command
        /// </summary>
        public ICommand T7_SV_Down { get; set; }

        /// <summary>
        /// Up SV Tank 8 Command
        /// </summary>
        public ICommand T8_SV_Up { get; set; }
        /// <summary>
        /// Down SV Tank 8 Command
        /// </summary>
        public ICommand T8_SV_Down { get; set; }

        /// <summary>
        /// Up SV Tank 9 Command
        /// </summary>
        public ICommand T9_SV_Up { get; set; }
        /// <summary>
        /// Down SV Tank 9 Command
        /// </summary>
        public ICommand T9_SV_Down { get; set; }

        /// <summary>
        /// Up SV Tank 10 Command
        /// </summary>
        public ICommand T10_SV_Up { get; set; }
        /// <summary>
        /// Down SV Tank 10 Command
        /// </summary>
        public ICommand T10_SV_Down { get; set; }

        /// <summary>
        /// Up SV Tank 11 Command
        /// </summary>
        public ICommand T11_SV_Up { get; set; }
        /// <summary>
        /// Down SV Tank 11 Command
        /// </summary>
        public ICommand T11_SV_Down { get; set; }

        /// <summary>
        /// Up Output High Limit Tank 1
        /// </summary>
        /// 
        public ICommand OH1_Up { get; set; }
        /// <summary>
        /// Down Output High Limit Tank 1
        /// </summary>
        public ICommand OH1_Down { get; set; }

        /// <summary>
        /// Up Output Low Limit Tank 1
        /// </summary>
        public ICommand OL1_Up { get; set; }

        /// <summary>
        /// Down Output Low Limit Tank 1
        /// </summary>
        public ICommand OL1_Down { get; set; }



        /// <summary>
        /// Up Output High Limit Tank 2
        /// </summary>
        /// 
        public ICommand OH2_Up { get; set; }
        /// <summary>
        /// Down Output High Limit Tank 1
        /// </summary>
        public ICommand OH2_Down { get; set; }

        /// <summary>
        /// Up Output Low Limit Tank 2
        /// </summary>
        public ICommand OL2_Up { get; set; }

        /// <summary>
        /// Down Output Low Limit Tank 2
        /// </summary>
        public ICommand OL2_Down { get; set; }

        /// <summary>
        /// Up Output High Limit Tank 3
        /// </summary>
        /// 
        public ICommand OH3_Up { get; set; }
        /// <summary>
        /// Down Output High Limit Tank 3
        /// </summary>
        public ICommand OH3_Down { get; set; }

        /// <summary>
        /// Up Output Low Limit Tank 3
        /// </summary>
        public ICommand OL3_Up { get; set; }

        /// <summary>
        /// Down Output Low Limit Tank 3
        /// </summary>
        public ICommand OL3_Down { get; set; }


        /// <summary>
        /// Up Output High Limit Tank 4
        /// </summary>
        /// 
        public ICommand OH4_Up { get; set; }
        /// <summary>
        /// Down Output High Limit Tank 4
        /// </summary>
        public ICommand OH4_Down { get; set; }

        /// <summary>
        /// Up Output Low Limit Tank 4
        /// </summary>
        public ICommand OL4_Up { get; set; }

        /// <summary>
        /// Down Output Low Limit Tank 4
        /// </summary>
        public ICommand OL4_Down { get; set; }

        /// <summary>
        /// Up Output High Limit Tank 5
        /// </summary>
        /// 
        public ICommand OH5_Up { get; set; }
        /// <summary>
        /// Down Output High Limit Tank 5
        /// </summary>
        public ICommand OH5_Down { get; set; }

        /// <summary>
        /// Up Output Low Limit Tank 5
        /// </summary>
        public ICommand OL5_Up { get; set; }

        /// <summary>
        /// Down Output Low Limit Tank 5
        /// </summary>
        public ICommand OL5_Down { get; set; }

        /// <summary>
        /// Up Output High Limit Tank 6
        /// </summary>
        /// 
        public ICommand OH6_Up { get; set; }
        /// <summary>
        /// Down Output High Limit Tank 6
        /// </summary>
        public ICommand OH6_Down { get; set; }

        /// <summary>
        /// Up Output Low Limit Tank 6
        /// </summary>
        public ICommand OL6_Up { get; set; }

        /// <summary>
        /// Down Output Low Limit Tank 6
        /// </summary>
        public ICommand OL6_Down { get; set; }

        /// <summary>
        /// Up Output High Limit Tank 7
        /// </summary>
        /// 
        public ICommand OH7_Up { get; set; }
        /// <summary>
        /// Down Output High Limit Tank 7
        /// </summary>
        public ICommand OH7_Down { get; set; }

        /// <summary>
        /// Up Output Low Limit Tank 7
        /// </summary>
        public ICommand OL7_Up { get; set; }

        /// <summary>
        /// Down Output Low Limit Tank 7
        /// </summary>
        public ICommand OL7_Down { get; set; }

        /// <summary>
        /// Up Output High Limit Tank 8
        /// </summary>
        /// 
        public ICommand OH8_Up { get; set; }
        /// <summary>
        /// Down Output High Limit Tank 1
        /// </summary>
        public ICommand OH8_Down { get; set; }

        /// <summary>
        /// Up Output Low Limit Tank 1
        /// </summary>
        public ICommand OL8_Up { get; set; }

        /// <summary>
        /// Down Output Low Limit Tank 1
        /// </summary>
        public ICommand OL8_Down { get; set; }

        /// <summary>
        /// Up Output High Limit Tank 9
        /// </summary>
        /// 
        public ICommand OH9_Up { get; set; }
        /// <summary>
        /// Down Output High Limit Tank 9
        /// </summary>
        public ICommand OH9_Down { get; set; }

        /// <summary>
        /// Up Output Low Limit Tank 9
        /// </summary>
        public ICommand OL9_Up { get; set; }

        /// <summary>
        /// Down Output Low Limit Tank 9
        /// </summary>
        public ICommand OL9_Down { get; set; }

        /// <summary>
        /// Up Output High Limit Tank 10
        /// </summary>
        /// 
        public ICommand OH10_Up { get; set; }
        /// <summary>
        /// Down Output High Limit Tank 10
        /// </summary>
        public ICommand OH10_Down { get; set; }

        /// <summary>
        /// Up Output Low Limit Tank 10
        /// </summary>
        public ICommand OL10_Up { get; set; }

        /// <summary>
        /// Down Output Low Limit Tank 10
        /// </summary>
        public ICommand OL10_Down { get; set; }

        /// <summary>
        /// Up Output High Limit Tank 1
        /// </summary>
        /// 
        public ICommand OH11_Up { get; set; }
        /// <summary>
        /// Down Output High Limit Tank 11
        /// </summary>
        public ICommand OH11_Down { get; set; }

        /// <summary>
        /// Up Output Low Limit Tank 11
        /// </summary>
        public ICommand OL11_Up { get; set; }

        /// <summary>
        /// Down Output Low Limit Tank 11
        /// </summary>
        public ICommand OL11_Down { get; set; }







        public ICommand Set_Speed_Down_AX1 { get; set; }
        public ICommand Set_Speed_Up_AX1 { get; set; }
        public ICommand JogF_Down_AX1 { get; set; }
        public ICommand JogF_Up_AX1 { get; set; }
        public ICommand JogB_Down_AX1 { get; set; }
        public ICommand JogB_Up_AX1 { get; set; }
        public ICommand Home_Down_AX1 { get; set; }
        public ICommand Home_Up_AX1 { get; set; }
        public ICommand Set_Point_Down_AX1 { get; set; }
        public ICommand Set_Point_Up_AX1 { get; set; }
        public ICommand Move_Down_AX1 { get; set; }
        public ICommand Move_Up_AX1 { get; set; }
        public ICommand Up_SMP_AX1 { get; set; }
        public ICommand Down_SMP_AX1 { get; set; }
        public ICommand Up_Decel_AX1 { get; set; }
        public ICommand Down_Decel_AX1 { get; set; }
        public ICommand Up_Accel_AX1 { get; set; }
        public ICommand Down_Accel_AX1 { get; set; }
        public ICommand Up_PN_AX1 { get; set; }
        public ICommand Down_PN_AX1 { get; set; }
        public ICommand Up_PP_AX1 { get; set; }
        public ICommand Down_PP_AX1 { get; set; }
        public ICommand Up_SLP_AX1 { get; set; }
        public ICommand Down_SLP_AX1 { get; set; }

        public ICommand Set_Speed_Down_AX2 { get; set; }
        public ICommand Set_Speed_Up_AX2 { get; set; }
        public ICommand JogF_Down_AX2 { get; set; }
        public ICommand JogF_Up_AX2 { get; set; }
        public ICommand JogB_Down_AX2 { get; set; }
        public ICommand JogB_Up_AX2 { get; set; }
        public ICommand Home_Down_AX2 { get; set; }
        public ICommand Home_Up_AX2 { get; set; }
        public ICommand Set_Point_Down_AX2 { get; set; }
        public ICommand Set_Point_Up_AX2 { get; set; }
        public ICommand Move_Down_AX2 { get; set; }
        public ICommand Move_Up_AX2 { get; set; }
        public ICommand Up_SMP_AX2 { get; set; }
        public ICommand Down_SMP_AX2 { get; set; }
        public ICommand Up_Decel_AX2 { get; set; }
        public ICommand Down_Decel_AX2 { get; set; }
        public ICommand Up_Accel_AX2 { get; set; }
        public ICommand Down_Accel_AX2 { get; set; }
        public ICommand Up_PN_AX2 { get; set; }
        public ICommand Down_PN_AX2 { get; set; }
        public ICommand Up_PP_AX2 { get; set; }
        public ICommand Down_PP_AX2 { get; set; }
        public ICommand Up_SLP_AX2 { get; set; }
        public ICommand Down_SLP_AX2 { get; set; }

        #endregion

        #region Model

        private int _sp1;

        public int SpeedAX1
        {
            get => _sp1;
            set => SetProperty(ref _sp1, value, nameof(SpeedAX1));
        }

        private int _sp2;

        public int SpeedAX2
        {
            get => _sp2;
            set => SetProperty(ref _sp2, value, nameof(SpeedAX2));
        }


        private int _cp1;

        public int CurrenPossitionAX1
        {
            get => _cp1;
            set => SetProperty(ref _cp1, value, nameof(CurrenPossitionAX1));
        }

        private int _cp2;

        public int CurrenPossitionAX2
        {
            get => _cp2;
            set => SetProperty(ref _cp2, value, nameof(CurrenPossitionAX2));
        }

        private int _smp1;

        public int SMPAX1
        {
            get => _smp1;
            set => SetProperty(ref _smp1, value, nameof(SMPAX1));
        }

        private int _smp2;

        public int SMPAX2
        {
            get => _smp2;
            set => SetProperty(ref _smp2, value, nameof(SMPAX2));
        }

        private int _decel1;

        public int DeccelAX1
        {
            get => _decel1;
            set => SetProperty(ref _decel1, value, nameof(DeccelAX1));
        }
        private int _decel2;

        public int DeccelAX2
        {
            get => _decel2;
            set => SetProperty(ref _decel2, value, nameof(DeccelAX2));
        }

        private int _accel1;

        public int AccelAX1
        {
            get => _accel1;
            set => SetProperty(ref _accel1, value, nameof(AccelAX1));
        }

        private int _accel2;

        public int AccelAX2
        {
            get => _accel2;
            set => SetProperty(ref _accel2, value, nameof(AccelAX2));
        }

        private int _pn1;

        public int PNAX1
        {
            get => _pn1;
            set => SetProperty(ref _pn1, value, nameof(PNAX1));
        }

        private int _pn2;

        public int PNAX2
        {
            get => _pn2;
            set => SetProperty(ref _pn2, value, nameof(PNAX2));
        }

        private int _pp1;

        public int PPAX1
        {
            get => _pp1;
            set => SetProperty(ref _pp1, value, nameof(PPAX1));
        }

        private int _pp2;

        public int PPAX2
        {
            get => _pp2;
            set => SetProperty(ref _pp2, value, nameof(PPAX2));
        }

        private int _slp1;

        public int SLPAX1
        {
            get => _slp1;
            set => SetProperty(ref _slp1, value, nameof(SLPAX1));
        }

        private int _slp2;

        public int SLPAX2
        {
            get => _slp2;
            set => SetProperty(ref _slp2, value, nameof(SLPAX2));
        }

        private float _sv1;

        /// <summary>
        /// SV Inscrese Tank 1
        /// </summary>
        public float SV1
        {
            get => _sv1;
            set => SetProperty(ref _sv1, value, nameof(SV1));
        }

        private float _sv2;

        /// <summary>
        /// SV Inscrese Tank 2
        /// </summary>
        public float SV2
        {
            get => _sv2;
            set => SetProperty(ref _sv2, value, nameof(SV2));
        }

        private float _sv3;

        /// <summary>
        /// SV Inscrese Tank 3
        /// </summary>
        public float SV3
        {
            get => _sv3;
            set => SetProperty(ref _sv3, value, nameof(SV3));
        }

        private float _sv4;

        /// <summary>
        /// SV Inscrese Tank 4
        /// </summary>
        public float SV4
        {
            get => _sv4;
            set => SetProperty(ref _sv4, value, nameof(SV4));
        }

        private float _sv5;

        /// <summary>
        /// SV Inscrese Tank 5
        /// </summary>
        public float SV5
        {
            get => _sv5;
            set => SetProperty(ref _sv5, value, nameof(SV5));
        }

        private float _sv6;

        /// <summary>
        /// SV Inscrese Tank 6
        /// </summary>
        public float SV6
        {
            get => _sv6;
            set => SetProperty(ref _sv6, value, nameof(SV6));
        }

        private float _sv7;

        /// <summary>
        /// SV Inscrese Tank 7
        /// </summary>
        public float SV7
        {
            get => _sv7;
            set => SetProperty(ref _sv7, value, nameof(SV7));
        }

        private float _sv8;

        /// <summary>
        /// SV Inscrese Tank 8
        /// </summary>
        public float SV8
        {
            get => _sv8;
            set => SetProperty(ref _sv8, value, nameof(SV8));
        }

        private float _sv9;

        /// <summary>
        /// SV Inscrese Tank 1
        /// </summary>
        public float SV9
        {
            get => _sv9;
            set => SetProperty(ref _sv9, value, nameof(SV9));
        }

        private float _sv10;

        /// <summary>
        /// SV Inscrese Tank 10
        /// </summary>
        public float SV10
        {
            get => _sv10;
            set => SetProperty(ref _sv10, value, nameof(SV10));
        }

        private float _sv11;

        /// <summary>
        /// SV Inscrese Tank 11
        /// </summary>
        public float SV11
        {
            get => _sv11;
            set => SetProperty(ref _sv11, value, nameof(SV11));
        }


        private float _oh1;

        /// <summary>
        /// Output High Limit Tank 1
        /// </summary>
        public float OH1
        {
            get => _oh1;
            set => SetProperty(ref _oh1, value, nameof(OH1));
        }

        private float _oh2;

        /// <summary>
        /// Output High Limit Tank 2
        /// </summary>
        public float OH2
        {
            get => _oh2;
            set => SetProperty(ref _oh2, value, nameof(OH2));
        }

        private float _oh3;

        /// <summary>
        /// Output High Limit Tank 3
        /// </summary>
        public float OH3
        {
            get => _oh3;
            set => SetProperty(ref _oh3, value, nameof(OH3));
        }

        private float _oh4;

        /// <summary>
        /// Output High Limit Tank 4
        /// </summary>
        public float OH4
        {
            get => _oh4;
            set => SetProperty(ref _oh4, value, nameof(OH4));
        }

        private float _oh5;

        /// <summary>
        /// Output High Limit Tank 5
        /// </summary>
        public float OH5
        {
            get => _oh5;
            set => SetProperty(ref _oh5, value, nameof(OH5));
        }

        private float _oh6;

        /// <summary>
        /// Output High Limit Tank 6
        /// </summary>
        public float OH6
        {
            get => _oh6;
            set => SetProperty(ref _oh6, value, nameof(OH6));
        }

        private float _oh7;

        /// <summary>
        /// Output High Limit Tank 7
        /// </summary>
        public float OH7
        {
            get => _oh7;
            set => SetProperty(ref _oh7, value, nameof(OH7));
        }

        private float _oh8;

        /// <summary>
        /// Output High Limit Tank 8
        /// </summary>
        public float OH8
        {
            get => _oh8;
            set => SetProperty(ref _oh8, value, nameof(OH8));
        }

        private float _oh9;

        /// <summary>
        /// Output High Limit Tank 9
        /// </summary>
        public float OH9
        {
            get => _oh9;
            set => SetProperty(ref _oh9, value, nameof(OH9));
        }

        private float _oh10;

        /// <summary>
        /// Output High Limit Tank 10
        /// </summary>
        public float OH10
        {
            get => _oh10;
            set => SetProperty(ref _oh10, value, nameof(OH10));
        }

        private float _oh11;

        /// <summary>
        /// Output High Limit Tank 11
        /// </summary>
        public float OH11
        {
            get => _oh11;
            set => SetProperty(ref _oh11, value, nameof(OH11));
        }


        private float _ol1;
        /// <summary>
        /// Output Low Limit 1
        /// </summary>
        public float OL1
        {
            get => _ol1;
            set => SetProperty(ref _ol1, value, nameof(OL1));
        }

        private float _ol2;
        /// <summary>
        /// Output Low Limit 2
        /// </summary>
        public float OL2
        {
            get => _ol2;
            set => SetProperty(ref _ol2, value, nameof(OL2));
        }

        private float _ol3;
        /// <summary>
        /// Output Low Limit 3
        /// </summary>
        public float OL3
        {
            get => _ol3;
            set => SetProperty(ref _ol3, value, nameof(OL3));
        }

        private float _ol4;
        /// <summary>
        /// Output Low Limit 4
        /// </summary>
        public float OL4
        {
            get => _ol4;
            set => SetProperty(ref _ol4, value, nameof(OL4));
        }

        private float _ol5;
        /// <summary>
        /// Output Low Limit 5
        /// </summary>
        public float OL5
        {
            get => _ol5;
            set => SetProperty(ref _ol5, value, nameof(OL5));
        }

        private float _ol6;
        /// <summary>
        /// Output Low Limit 6
        /// </summary>
        public float OL6
        {
            get => _ol6;
            set => SetProperty(ref _ol6, value, nameof(OL6));
        }

        private float _ol7;
        /// <summary>
        /// Output Low Limit 7
        /// </summary>
        public float OL7
        {
            get => _ol7;
            set => SetProperty(ref _ol7, value, nameof(OL7));
        }

        private float _ol8;
        /// <summary>
        /// Output Low Limit 8
        /// </summary>
        public float OL8
        {
            get => _ol8;
            set => SetProperty(ref _ol8, value, nameof(OL8));
        }

        private float _ol9;
        /// <summary>
        /// Output Low Limit 9
        /// </summary>
        public float OL9
        {
            get => _ol9;
            set => SetProperty(ref _ol9, value, nameof(OL9));
        }

        private float _ol10;
        /// <summary>
        /// Output Low Limit 10
        /// </summary>
        public float OL10
        {
            get => _ol10;
            set => SetProperty(ref _ol10, value, nameof(OL10));
        }

        private float _ol11;
        /// <summary>
        /// Output Low Limit 11
        /// </summary>
        public float OL11
        {
            get => _ol11;
            set => SetProperty(ref _ol11, value, nameof(OL11));
        }
        private float[] _temp;

        public float[] Data_Temper
        {
            get => _temp;
            set => SetProperty(ref _temp, value, nameof(Data_Temper));
        }
        private bool _en;

        public bool Enable
        {
            get => _en;
            set => SetProperty(ref _en, value, nameof(Enable));
        }


        #endregion
        public Simulation_Temp_ViewModel()
        {
            TestcomCommand = new ActionCommand((p) =>
            {
                string a = (string)p;
            });
            Loaded = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (ReadTimer == null)
                {
                    ReadTimer = new DispatcherTimer();
                    ReadTimer.Tick += ReadTimer_Tick;
                    ReadTimer.Interval = new TimeSpan(1000);
                    ReadTimer.IsEnabled = true;
                    ReadTimer.Start();
                }
                else
                {
                    if (!ReadTimer.IsEnabled)
                    {
                        ReadTimer.Start();
                    }
                }

            });
            Unloaded = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (ReadTimer.IsEnabled)
                {
                    ReadTimer.Stop();
                    ReadTimer.IsEnabled = false;
                }
            });

            #region Control temp
            T1_SV_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV1 += 0.1f;
                SV1 = (float)Math.Round(SV1, 1);
            });

            T1_SV_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV1 -= 0.1f;
                if (SV1 < 0) SV1 = 0;
                SV1 = (float)Math.Round(SV1, 1);
            });

            //-----------------------------------------------------------------------------------------------
            T2_SV_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV2 += 0.1f;
                SV2 = (float)Math.Round(SV2, 1);
            });

            T2_SV_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV2 -= 0.1f;
                if (SV2 < 0) SV2 = 0;
                SV2 = (float)Math.Round(SV2, 1);
            });

            //-----------------------------------------------------------------------------------------------
            T3_SV_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV3 += 0.1f;
                SV3 = (float)Math.Round(SV3, 1);
            });

            T3_SV_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV3 -= 0.1f;
                if (SV3 < 0) SV3 = 0;
                SV3 = (float)Math.Round(SV3, 1);
            });

            //-----------------------------------------------------------------------------------------------
            T4_SV_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV4 += 0.1f;
                SV4 = (float)Math.Round(SV4, 1);
            });

            T4_SV_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV4 -= 0.1f;
                if (SV4 < 0) SV4 = 0;
                SV4 = (float)Math.Round(SV4, 1);
            });


            //-----------------------------------------------------------------------------------------------
            T5_SV_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV5 += 0.1f;
                SV5 = (float)Math.Round(SV5, 1);
            });

            T5_SV_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV5 -= 0.1f;
                if (SV5 < 0) SV5 = 0;
                SV5 = (float)Math.Round(SV5, 1);
            });

            //-----------------------------------------------------------------------------------------------
            T6_SV_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV6 += 0.1f;
                SV6 = (float)Math.Round(SV6, 1);
            });

            T6_SV_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV6 -= 0.1f;
                if (SV6 < 0) SV6 = 0;
                SV6 = (float)Math.Round(SV6, 1);
            });

            //-----------------------------------------------------------------------------------------------
            T7_SV_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV7 += 0.1f;
                SV7 = (float)Math.Round(SV7, 1);
            });

            T7_SV_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV7 -= 0.1f;
                if (SV7 < 0) SV7 = 0;
                SV7 = (float)Math.Round(SV7, 1);
            });


            //-----------------------------------------------------------------------------------------------
            T8_SV_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV8 += 0.1f;
                SV8 = (float)Math.Round(SV8, 1);
            });

            T8_SV_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV8 -= 0.1f;
                if (SV8 < 0) SV8 = 0;
                SV8 = (float)Math.Round(SV8, 1);
            });

            //-----------------------------------------------------------------------------------------------
            T9_SV_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV9 += 0.1f;
                SV9 = (float)Math.Round(SV9, 1);
            });

            T9_SV_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV9 -= 0.1f;
                if (SV9 < 0) SV9 = 0;
                SV9 = (float)Math.Round(SV9, 1);
            });

            //-----------------------------------------------------------------------------------------------
            T10_SV_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV10 += 0.1f;
                SV10 = (float)Math.Round(SV10, 1);
            });

            T10_SV_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV10 -= 0.1f;
                if (SV10 < 0) SV10 = 0;
                SV10 = (float)Math.Round(SV10, 1);
            });

            //-----------------------------------------------------------------------------------------------
            T11_SV_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV11 += 0.1f;
                SV11 = (float)Math.Round(SV11, 1);
            });

            T11_SV_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SV11 -= 0.1f;
                if (SV11 < 0) SV11 = 0;
                SV11 = (float)Math.Round(SV11, 1);
            });

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            OH1_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH1 += 0.1f;
                OH1 = (float)Math.Round(OH1, 1);
            });
            OH1_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH1 -= 0.1f;
                if (OH1 < 0) OH1 = 0;
                OH1 = (float)Math.Round(OH1, 1);
            });

            OL1_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL1 += 0.1f;
                OL1 = (float)Math.Round(OL1, 1);
            });
            OL1_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL1 -= 0.1f;
                if (OL1 < 0) OL1 = 0;
                OL1 = (float)Math.Round(OL1, 1);
            });

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            OH2_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH2 += 0.1f;
                OH2 = (float)Math.Round(OH2, 1);
            });
            OH2_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH2 -= 0.1f;
                if (OH2 < 0) OH2 = 0;
                OH2 = (float)Math.Round(OH2, 1);
            });

            OL2_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL2 += 0.1f;
                OL2 = (float)Math.Round(OL2, 1);
            });
            OL2_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL2 -= 0.1f;
                if (OL2 < 0) OL2 = 0;
                OL2 = (float)Math.Round(OL2, 1);
            });

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            OH3_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH3 += 0.1f;
                OH3 = (float)Math.Round(OH3, 1);
            });
            OH3_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH3 -= 0.1f;
                if (OH3 < 0) OH3 = 0;
                OH3 = (float)Math.Round(OH3, 1);
            });

            OL3_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL3 += 0.1f;
                OL3 = (float)Math.Round(OL3, 1);
            });
            OL3_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL3 -= 0.1f;
                if (OL3 < 0) OL3 = 0;
                OL3 = (float)Math.Round(OL3, 1);
            });

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            OH4_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH4 += 0.1f;
                OH4 = (float)Math.Round(OH4, 1);
            });
            OH4_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH4 -= 0.1f;
                if (OH4 < 0) OH4 = 0;
                OH4 = (float)Math.Round(OH4, 1);
            });

            OL4_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL4 += 0.1f;
                OL4 = (float)Math.Round(OL4, 1);
            });
            OL4_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL4 -= 0.1f;
                if (OL4 < 0) OL4 = 0;
                OL4 = (float)Math.Round(OL4, 1);
            });

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            OH5_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH5 += 0.1f;
                OH5 = (float)Math.Round(OH5, 1);
            });
            OH5_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH5 -= 0.1f;
                if (OH5 < 0) OH5 = 0;
                OH5 = (float)Math.Round(OH5, 1);
            });

            OL5_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL5 += 0.1f;
                OL5 = (float)Math.Round(OL5, 1);
            });
            OL5_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL5 -= 0.1f;
                if (OL5 < 0) OL5 = 0;
                OL5 = (float)Math.Round(OL5, 1);
            });

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            OH6_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH6 += 0.1f;
                OH6 = (float)Math.Round(OH6, 1);
            });
            OH6_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH6 -= 0.1f;
                if (OH6 < 0) OH6 = 0;
                OH6 = (float)Math.Round(OH6, 1);
            });

            OL6_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL6 += 0.1f;
                OL6 = (float)Math.Round(OL6, 1);
            });
            OL6_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL6 -= 0.1f;
                if (OL6 < 0) OL6 = 0;
                OL6 = (float)Math.Round(OL6, 1);
            });

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            OH7_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH7 += 0.1f;
                OH7 = (float)Math.Round(OH7, 1);
            });
            OH7_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH7 -= 0.1f;
                if (OH7 < 0) OH7 = 0;
                OH7 = (float)Math.Round(OH7, 1);
            });

            OL7_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL7 += 0.1f;
                OL7 = (float)Math.Round(OL7, 1);
            });
            OL7_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL7 -= 0.1f;
                if (OL7 < 0) OL7 = 0;
                OL7 = (float)Math.Round(OL7, 1);
            });

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            OH8_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH8 += 0.1f;
                OH8 = (float)Math.Round(OH8, 1);
            });
            OH8_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH8 -= 0.1f;
                if (OH8 < 0) OH8 = 0;
                OH8 = (float)Math.Round(OH8, 1);
            });

            OL8_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL8 += 0.1f;
                OL8 = (float)Math.Round(OL8, 1);
            });
            OL8_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL8 -= 0.1f;
                if (OL8 < 0) OL8 = 0;
                OL8 = (float)Math.Round(OL8, 1);
            });

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            OH9_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH9 += 0.1f;
                OH9 = (float)Math.Round(OH9, 1);
            });
            OH9_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH9 -= 0.1f;
                if (OH9 < 0) OH9 = 0;
                OH9 = (float)Math.Round(OH9, 1);
            });

            OL9_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL9 += 0.1f;
                OL9 = (float)Math.Round(OL9, 1);
            });
            OL9_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL9 -= 0.1f;
                if (OL9 < 0) OL9 = 0;
                OL9 = (float)Math.Round(OL9, 1);
            });

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            OH10_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH10 += 0.1f;
                OH10 = (float)Math.Round(OH10, 1);
            });
            OH10_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH10 -= 0.1f;
                if (OH10 < 0) OH10 = 0;
                OH10 = (float)Math.Round(OH10, 1);
            });

            OL10_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL10 += 0.1f;
                OL10 = (float)Math.Round(OL10, 1);
            });
            OL10_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL10 -= 0.1f;
                if (OL10 < 0) OL10 = 0;
                OL10 = (float)Math.Round(OL10, 1);
            });

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            OH11_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH11 += 0.1f;
                OH11 = (float)Math.Round(OH11, 1);
            });
            OH11_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OH11 -= 0.1f;
                if (OH11 < 0) OH11 = 0;
                OH11 = (float)Math.Round(OH11, 1);
            });

            OL11_Up = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL11 += 0.1f;
                OL11 = (float)Math.Round(OL11, 1);
            });
            OL11_Down = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                OL11 -= 0.1f;
                if (OL11 < 0) OL11 = 0;
                OL11 = (float)Math.Round(OL11, 1);
            });
            #endregion
            #region Control Axis 1
            Set_Speed_Down_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            Set_Speed_Up_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            JogF_Down_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            JogF_Up_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            JogB_Down_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            JogB_Up_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            Home_Down_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            Home_Up_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            Set_Point_Down_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            Set_Point_Up_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            Move_Down_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            Move_Up_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            Up_Accel_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                AccelAX1 += 1;
            });
            Down_Accel_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (AccelAX1 > 20)
                {
                    AccelAX1 -= 1;
                }
            });
            Up_Decel_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                DeccelAX1 += 1;
            });
            Down_Decel_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (DeccelAX1 > 20)
                {
                    DeccelAX1 -= 1;
                }
            });
            Down_SMP_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SMPAX1 -= 1;
                if (SMPAX1 < 1)
                {
                    SMPAX1 = 0;
                }
            });
            Up_SMP_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SMPAX1 += 1;
                if (SMPAX1 > 4000)
                {
                    SMPAX1 = 4000;
                }
            });
            Down_SLP_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SLPAX1 -= 1;
                if (SLPAX1 < 1)
                {
                    SLPAX1 = 1;
                }
            });
            Up_SLP_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SLPAX1 += 1;
                if (SLPAX1 > 30)
                {
                    SLPAX1 = 30;
                }
            });
            Down_PP_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                PPAX1 -= 1;
                if (PPAX1 < 0)
                {
                    PPAX1 = 0;
                }
            });
            Up_PP_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                PPAX1 += 1;
                if (PPAX1 > 9999)
                {
                    PPAX1 = 9999;
                }
            });
            Down_PN_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                PNAX1 -= 1;
                if (PNAX1 < 1)
                {
                    PNAX1 = 1;
                }
            });
            Up_PN_AX1 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                PNAX1 += 1;
                if (PNAX1 > 30)
                {
                    PNAX1 = 30;
                }
            });

            #endregion
            //------------------------------------------------------------------------------------------------------------
            #region Control Axis 2
            Set_Speed_Down_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }

            });
            Set_Speed_Up_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            JogF_Down_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            JogF_Up_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            JogB_Down_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            JogB_Up_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            Home_Down_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            Home_Up_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            Set_Point_Down_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            Set_Point_Up_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            Move_Down_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            Move_Up_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    //MainViewModel.DataPLC.WriteBit("", true);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("PLC is not connected");
                }
            });
            Up_Accel_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                AccelAX2 += 1;
            });
            Down_Accel_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (AccelAX2 > 20)
                {
                    AccelAX2 -= 1;
                }
            });
            Up_Decel_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                DeccelAX2 += 1;
            });
            Down_Decel_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                if (DeccelAX2 > 20)
                {
                    DeccelAX2 -= 1;
                }
            });
            Down_SMP_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SMPAX2 -= 1;
                if (SMPAX2 < 1)
                {
                    SMPAX2 = 0;
                }
            });
            Up_SMP_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SMPAX1 += 1;
                if (SMPAX2 > 4000)
                {
                    SMPAX2 = 4000;
                }
            });
            Down_SLP_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SLPAX2 -= 1;
                if (SLPAX2 < 1)
                {
                    SLPAX2 = 1;
                }
            });
            Up_SLP_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                SLPAX2 += 1;
                if (SLPAX2 > 30)
                {
                    SLPAX2 = 30;
                }
            });
            Down_PP_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                PPAX2 -= 1;
                if (PPAX2 < 0)
                {
                    PPAX2 = 0;
                }
            });
            Up_PP_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                PPAX2 += 1;
                if (PPAX2 > 9999)
                {
                    PPAX2 = 9999;
                }
            });
            Down_PN_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                PNAX2 -= 1;
                if (PNAX2 < 1)
                {
                    PNAX2 = 1;
                }
            });
            Up_PN_AX2 = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                PNAX2 += 1;
                if (PNAX2 > 30)
                {
                    PNAX2 = 30;
                }
            });
            #endregion


            #region Setting Temperater

            Set_SV_1 = new RelayCommand<object>((p) => { return true; }, (p) => { });

            #endregion
            //------------------------------------------------------------------------------------------------------------

        }
        
        
        
        private void ReadTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (MainViewModel.DataPLC.IsConnect)
                {
                    Enable = true;
                }
                else
                {
                    Enable = false;
                }
                Data_Temper = test(MainViewModel.DataPLC.Temperater);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        public float[] test(float[] tttt)
        {
            if (!MainViewModel.DataPLC.IsConnect)
            {
                return null;
            }
            if (tttt != null)
            {
                float[] aa = new float[8];
                for (int i = 0; i < tttt.Length; i++)
                {
                    aa[i] = tttt[i] % 100;
                }
                return aa;
            }
            else { return null; }
        }
    }
    public class DemoValuesProvider
    {
        public IEnumerable<PredefinedElementKind> PredefinedCircularGaugeModelKinds { get { return CircularGaugeControl.PredefinedModels; } }
        public IEnumerable<PredefinedElementKind> PredefinedLinearGaugeModelKinds { get { return LinearGaugeControl.PredefinedModels; } }
        public IEnumerable<PredefinedElementKind> PredefinedDigitalGaugeModelKinds { get { return DigitalGaugeControl.PredefinedModels; } }
    }

    public class PredefinedElementKindToCircularGaugeModel : IValueConverter
    {
        #region IValueConverter implementation
        object IValueConverter.Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            PredefinedElementKind gaugeModelKind = value as PredefinedElementKind;
            if (gaugeModelKind != null && gaugeModelKind.Type.BaseType == typeof(CircularGaugeModel))
                return Activator.CreateInstance(gaugeModelKind.Type);
            return value;
        }
        object IValueConverter.ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
        #endregion
    }

    public class PredefinedElementKindToLinearGaugeModel : IValueConverter
    {
        #region IValueConverter implementation
        object IValueConverter.Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            PredefinedElementKind gaugeModelKind = value as PredefinedElementKind;
            if (gaugeModelKind != null && gaugeModelKind.Type.BaseType == typeof(LinearGaugeModel))
                return Activator.CreateInstance(gaugeModelKind.Type);
            return value;
        }
        object IValueConverter.ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
        #endregion
    }

    public class PredefinedElementKindToDigitalGaugeModel : IValueConverter
    {
        #region IValueConverter implementation
        object IValueConverter.Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            PredefinedElementKind gaugeModelKind = value as PredefinedElementKind;
            if (gaugeModelKind != null && gaugeModelKind.Type.BaseType == typeof(DigitalGaugeModel))
                return Activator.CreateInstance(gaugeModelKind.Type);
            return value;
        }
        object IValueConverter.ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
        #endregion
    }
    
    
}
