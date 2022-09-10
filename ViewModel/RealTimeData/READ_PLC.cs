using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace HOYA_SIM.ViewModel.RealTimeData
{
    public class READ_PLC
    {
        public string IP_PLC { get; set; }
        public short Rack { get; set; }
        public short Slot { get; set; }
        public Plc CPU_PLC { get; set; }
        public bool IsConnect { get; set; }
        public float[] Temperater { get; set; }

        private int numberDatablock;
        private int startbyteAdr;
        private int count;
        private DispatcherTimer readtimer = new DispatcherTimer();
        public READ_PLC()
        {

        }
        public READ_PLC(string ip, short rack, short slot)
        {
            readtimer.Tick += Readtimer_Tick;
            readtimer.Interval = new TimeSpan(5000);
            readtimer.IsEnabled = false;
            IP_PLC = ip;
            Slot = slot;
            Rack = rack;
            CPU_PLC = new Plc(CpuType.S71200,ip, rack, slot);
        }

        private void Readtimer_Tick (object sender, EventArgs e)
        {
            object a = CPU_PLC.Read(DataType.DataBlock, numberDatablock, startbyteAdr, VarType.Real, count);
            Temperater = (float[])a;
        }

        public void ConnectPLC()
        {
            try
            {
                if (!IsConnect)
                {
                    if(CPU_PLC.IsConnected == false)
                    {
                        CPU_PLC.Open();
                        IsConnect = true;
                    }
                    else
                    {
                        _ = System.Windows.Forms.MessageBox.Show("Conntection to PLC has established");
                    }
                   
                }
                else 
                {
                    _ = System.Windows.Forms.MessageBox.Show("Conntection to PLC has established");
                }
            }
            catch (Exception ex)
            {

                _ = System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }

        public void DisconnectPLC()
        {
            try
            {
                if (IsConnect)
                {
                    if (CPU_PLC.IsConnected)
                    {
                        CPU_PLC.Close();
                        IsConnect = false;
                    }
                    else
                    {
                        _ = System.Windows.Forms.MessageBox.Show("Conntection to PLC Disconnected");
                    }

                }
                else
                {
                    _ = System.Windows.Forms.MessageBox.Show("Conntection to PLC Disconnected");
                }
            }
            catch (Exception ex)
            {

                _ = System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        public void Start_Read_Array_RealData(int numberDatablock1,int startbyteAdr1,int count1)
        {
            try
            {
                numberDatablock = numberDatablock1;
                startbyteAdr = startbyteAdr1;
                count = count1;
                if (IsConnect == false)
                {
                    _ = System.Windows.Forms.MessageBox.Show("Connection is not connected");
                    
                }
                else
                {
                    if (readtimer.IsEnabled == false)
                    {
                        readtimer.IsEnabled = true;
                        readtimer.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public void WriteBit(string bit,bool value)
        {
            try
            {
                if (CPU_PLC.IsConnected)
                {
                    CPU_PLC.Write(bit, value);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }

    }
}
