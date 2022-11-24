using System;

namespace Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AbstractCommand<Light> lightCMD = new AbstractCommand<Light>();
            AbstractCommand<AirFan> airFanCMD = new AbstractCommand<AirFan>();
            AbstractCommand<AirConditioner> airConditionerCMD = new AbstractCommand<AirConditioner>();
            AbstractCommand<MultimediaEquipment> MECMD = new AbstractCommand<MultimediaEquipment>();

            AirConditioner airConditioner01 = new AirConditioner(01);
            AirConditioner airConditioner02 = new AirConditioner(02);
            AirConditioner airConditioner03 = new AirConditioner(03);
            AirConditioner airConditioner04 = new AirConditioner(04);
            airConditionerCMD.AddObject(01, airConditioner01);
            airConditionerCMD.AddObject(02, airConditioner02);
            airConditionerCMD.AddObject(03, airConditioner03);
            airConditionerCMD.AddObject(04, airConditioner04);

            AirFan airFan01 = new AirFan(01);
            AirFan airFan02 = new AirFan(02);
            AirFan airFan03 = new AirFan(03);
            airFanCMD.AddObject(01, airFan01);
            airFanCMD.AddObject(02, airFan02);
            airFanCMD.AddObject(03, airFan03);

            Light light01 = new Light(01);
            Light light02 = new Light(02);
            Light light03 = new Light(03);
            Light light04 = new Light(04);
            lightCMD.AddObject(01, light01);
            lightCMD.AddObject(02, light02);
            lightCMD.AddObject(03, light03);
            lightCMD.AddObject(04, light04);

            MultimediaEquipment ME01 = new MultimediaEquipment(01);
            MultimediaEquipment ME02 = new MultimediaEquipment(02);
            MECMD.AddObject(01, ME01);
            MECMD.AddObject(02, ME02);


            Controller controller = new Controller(lightCMD,airConditionerCMD,airFanCMD,MECMD);
            controller.OpenAirConditionerAll();
            controller.OpenAirFanAll();
            controller.OpenLightAll();
            controller.OpenMEAll();

            controller.CloseAirConditionerAll();
            controller.CloseAirFanAll();
            controller.CloseLightAll();
            controller.CloseMEAll();
        }
    }
}
