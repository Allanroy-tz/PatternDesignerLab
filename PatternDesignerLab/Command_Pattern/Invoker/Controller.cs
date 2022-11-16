namespace Command_Pattern
{
    public class Controller
    {
        AbstractCommand<Light> lightCMD;
        AbstractCommand<AirConditioner> airConditionerCMD;
        AbstractCommand<AirFan> airFanCMD;
        AbstractCommand<MultimediaEquipment> MECMD;
        public Controller(AbstractCommand<Light> lightcmd, AbstractCommand<AirConditioner> airConditionercmd, AbstractCommand<AirFan> airFancmd,AbstractCommand<MultimediaEquipment> mecmd) { this.lightCMD = lightcmd;this.airConditionerCMD = airConditionercmd;this.airFanCMD = airFancmd;this.MECMD = mecmd; }
        public Controller()
        {
            lightCMD.AddObject(1, new Light(1));
        }
        public void OpenLightAll()
        {
            lightCMD.OpenAll();
        }
        public void CloseLightAll()
        {
            lightCMD.CloseAll();
        }
        public void OpenMEAll()
        {
            MECMD.OpenAll();
        }
        public void CloseMEAll()
        {
            MECMD.CloseAll();
        }
        public void OpenAirFanAll()
        {
            airFanCMD.OpenAll();
        }
        public void CloseAirFanAll()
        {
            airFanCMD.CloseAll();
        }
        public void OpenAirConditionerAll()
        {
            airConditionerCMD.OpenAll();
        }
        public void CloseAirConditionerAll()
        {
            airConditionerCMD.CloseAll();
        }
        public void OpenLight(int num)
        {
            lightCMD.Open(num);
        }
        public void CloseLight(int num)
        {
            lightCMD.Close(num);
        }
        public void CloseME(int num)
        {
            MECMD.Close(num);
        }
        public void CloseAirFan(int num)
        {
            airFanCMD.Close(num);
        }
        public void CloseAirConditioner(int num)
        {
            airConditionerCMD.Close(num);
        }
        public void OpenME(int num)
        {
            MECMD.Close(num);
        }
        public void OpenAirFan(int num)
        {
            airFanCMD.Close(num);
        }
        public void OpenAirConditioner(int num)
        {
           airConditionerCMD.Close(num);
        }
    }

}