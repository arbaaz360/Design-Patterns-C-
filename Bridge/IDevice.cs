using System;

namespace Bridge
{
    public abstract class IDevice
    {
        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract void SetChannel(int channelId);
    }
 

    public class RemoteControl
    {
        private IDevice device { get; set; }

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }
        public void TurnOn()
        {
            this.device.TurnOn();
        }
        public void Turnoff()
        {
            this.device.TurnOff();
        }

    }

    public class AdvancedRemoteControl: RemoteControl
    {
        private IDevice device { get; set; }

        public AdvancedRemoteControl(IDevice device):base(device)
        {
            this.device = device;
        }
        public void setChannel(int channelId)
        {
            this.device.SetChannel(channelId);
        }
       

    }
    public class SonyTv : IDevice
    {
        public override void SetChannel(int channelId)
        {
            Console.WriteLine("channel set");
        }

        public override void TurnOff()
        {
            Console.WriteLine("sony off");
        }

        public override void TurnOn()
        {
            Console.WriteLine("channel on");
        }
    }
}
