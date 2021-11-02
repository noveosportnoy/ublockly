
using Mainbot.Winky.API.Actuators;
using UnityEngine;
using WinkyApp;
using WinkyApp.LabAdvanced;

namespace UBlockly
{
    public partial class CSharpGenerator
    {
        
        [CodeInterpreter(BlockType = "heads_set")]
        public class AngleCmdtor : ValueCmdtor
        {
            protected override DataStruct Execute(Block block)
            {
                var angle = int.Parse(block.GetFieldValue("ANGLE"));
                Debug.Log("VALUE: " + angle);
                var neckMsg = Neck.Rotate((short) angle);
                var runner = ServiceLocator.GetService<IAdvancedProgramRunner>();
                runner.AddMessage(neckMsg);
                runner.Run();
                Number num = new Number(angle);
                return new DataStruct(num);
            }
        }

    }
}
