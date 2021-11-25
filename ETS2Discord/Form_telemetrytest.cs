using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCSSdkClient;
using SCSSdkClient.Object;
using Newtonsoft.Json;

namespace ETS2Discord
{
    public partial class Form_telemetrytest : Form
    {

        public SCSSdkTelemetry Telemetry;
        private float fuel;

        public Form_telemetrytest()
        {
            InitializeComponent();

            Telemetry = new SCSSdkTelemetry();
            Telemetry.Data += Telemetry_Data;
        }


        private void Telemetry_Data(SCSTelemetry data, bool updated)
        {
            if (!updated) return;
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new TelemetryData(Telemetry_Data), data, updated);
                    return;
                }
                l_updateRate.Text = Telemetry.UpdateInterval + "ms";

                lbGeneral.Text = "General info:\r\n " +
                                 "\t SDK Running:" +
                                 $"\t\t\t{data.SdkActive}\r\n" +
                                 "\tSDK Version:\r\n" +
                                 $"\t\t\t{data.DllVersion}\r\n" +
                                 "\tGame:\r\n " +
                                 $"\t\t\t{data.Game}\r\n" +
                                 "\tTelemetry Version:\r\n" +
                                 $"\t\t\t{data.TelemetryVersion}\r\n" +
                                 "\tTimeStamp:\r\n" +
                                 $"\t\t\t{data.Timestamp}\r\n" +
                                 "\tSimulation TimeStamp:\r\n" +
                                 $"\t\t\t{data.SimulationTimestamp}\r\n" +
                                 "\tRender TimeStamp:\r\n" +
                                 $"\t\t\t{data.RenderTimestamp}\r\n" +
                                 "\tGame Paused:\r\n" +
                                 $"\t\t\t{data.Paused}\r\n" +
                                 "\tOn Job:\r\n" +
                                 $"\t\t\t{data.SpecialEventsValues.OnJob}\r\n" +
                                 "\tJob Finished:\r\n" +
                                 $"\t\t\t{data.SpecialEventsValues.JobFinished}\r\n" +
                                 "\tJob Delivered:\r\n" +
                                 $"\t\t\t{data.SpecialEventsValues.JobDelivered}\r\n" +
                                 "\tJob Cancelled:\r\n" +
                                 $"\t\t\t{data.SpecialEventsValues.JobCancelled}\r\n" +
                                 "\tFined:\r\n" +
                                 $"\t\t\t{data.SpecialEventsValues.Fined}\r\n" +
                                  "\tSpeed:\r\n" +
                                 $"\t\t\t{data.TruckValues.CurrentValues.DashboardValues.Speed.Kph}\r\n" +
                                  "\tVelocity[Max]:" +
                                 $"\t\t\t{data.TruckValues.CurrentValues.WheelsValues.Velocity.Max()}\r\n" +
                                  "\tVelocity[Min]:" +
                                 $"\t\t\t{data.TruckValues.CurrentValues.WheelsValues.Velocity.Min()}\r\n";

                //common.Text = JsonConvert.SerializeObject(data.CommonValues, Formatting.Indented);
                //truck.Text = JsonConvert.SerializeObject(data.TruckValues, Formatting.Indented);
                //trailer.Text =
                //    JsonConvert.SerializeObject(data.TrailerValues[0],
                //                                Formatting
                //                                    .Indented); //TODO: UNTIL I WORK ON A BETTER DEMO SHOW ONLY TRAILER 0
                //job.Text = JsonConvert.SerializeObject(data.JobValues, Formatting.Indented);
                //control.Text = JsonConvert.SerializeObject(data.ControlValues, Formatting.Indented);
                //navigation.Text = JsonConvert.SerializeObject(data.NavigationValues, Formatting.Indented);
                //substances.Text = JsonConvert.SerializeObject(data.Substances, Formatting.Indented);
                //gameplayevent.Text = JsonConvert.SerializeObject(data.GamePlay, Formatting.Indented);
                //rtb_fuel.Text = data.TruckValues.CurrentValues.DashboardValues.FuelValue.Amount + " " + data.SpecialEventsValues.Refuel;
                fuel = data.GamePlay.RefuelEvent.Amount;

            }
            catch (Exception ex)
            {
                // ignored atm i found no proper way to shut the telemetry down and down call this anymore when this or another thing is already disposed
                Console.WriteLine("Telemetry was closed: " + ex);
            }
        }
    }
}
