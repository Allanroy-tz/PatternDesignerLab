using System;
using System.Collections.Generic;

namespace Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tz20200440718_ICommnad close, open;
            Tz20200440718_CommandController commandController;
            Tz20200440718_CommandGroup lightGroup;
            Tz20200440718_Light light01 = new Tz20200440718_Light(01);
            Tz20200440718_Light light02 = new Tz20200440718_Light(02);

            close = new Tz20200440718_CloseCommand(light01);
            open = new Tz20200440718_OpenCommand(light01);
            commandController = new Tz20200440718_CommandController(close, open);
            lightGroup = new Tz20200440718_CommandGroup();
            lightGroup.Add(01,commandController);

            close = new Tz20200440718_CloseCommand(light02);
            open = new Tz20200440718_OpenCommand(light02);
            commandController = new Tz20200440718_CommandController(close, open);
            lightGroup.Add(02,commandController);

            Tz20200440718_CommandGroup airFanGroup;
            Tz20200440718_AirFan airFan01 = new Tz20200440718_AirFan(01);
            Tz20200440718_AirFan airFan02 = new Tz20200440718_AirFan(02);

            close = new Tz20200440718_CloseCommand(airFan01);
            open = new Tz20200440718_OpenCommand(airFan01);
            commandController = new Tz20200440718_CommandController(close, open);
            airFanGroup = new Tz20200440718_CommandGroup();
            airFanGroup.Add(01, commandController);

            close = new Tz20200440718_CloseCommand(airFan02);
            open = new Tz20200440718_OpenCommand(airFan02);
            commandController = new Tz20200440718_CommandController(close, open);
            airFanGroup.Add(02, commandController);

            Tz20200440718_CommandGroup airConditionerGroup;
            Tz20200440718_AirConditioner airConditioner01 = new Tz20200440718_AirConditioner(01);
            Tz20200440718_AirConditioner airConditioner02 = new Tz20200440718_AirConditioner(02);

            close = new Tz20200440718_CloseCommand(airConditioner01);
            open = new Tz20200440718_OpenCommand(airConditioner01);
            commandController = new Tz20200440718_CommandController(close, open);
            airConditionerGroup = new Tz20200440718_CommandGroup();
            airConditionerGroup.Add(01, commandController);

            close = new Tz20200440718_CloseCommand(airConditioner02);
            open = new Tz20200440718_OpenCommand(airConditioner02);
            commandController = new Tz20200440718_CommandController(close, open);
            airConditionerGroup.Add(02, commandController);

            Tz20200440718_CommandGroup multimediaEquipmentGroup;
            Tz20200440718_MultimediaEquipment multimediaEquipment01 = new Tz20200440718_MultimediaEquipment(01);
            Tz20200440718_MultimediaEquipment multimediaEquipment02 = new Tz20200440718_MultimediaEquipment(02);

            close = new Tz20200440718_CloseCommand(multimediaEquipment01);
            open = new Tz20200440718_OpenCommand(multimediaEquipment01);
            commandController = new Tz20200440718_CommandController(close, open);
            multimediaEquipmentGroup = new Tz20200440718_CommandGroup();
            multimediaEquipmentGroup.Add(01, commandController);

            close = new Tz20200440718_CloseCommand(multimediaEquipment02);
            open = new Tz20200440718_OpenCommand(multimediaEquipment02);
            commandController = new Tz20200440718_CommandController(close, open);
            multimediaEquipmentGroup.Add(02, commandController);


            lightGroup.Open();
            lightGroup.CloseAt(02);
            airFanGroup.Open();
            airFanGroup.CloseAt(01);
            airConditionerGroup.Open();
            airConditionerGroup.CloseAt(02);
            multimediaEquipmentGroup.Open();
            multimediaEquipmentGroup.CloseAt(01);
        }
    }
}
