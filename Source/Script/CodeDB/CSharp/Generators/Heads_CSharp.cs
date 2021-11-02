using UnityEngine;

namespace UBlockly
{
    public partial class CSharpGenerator
    {
        [CodeGenerator(BlockType = "heads_set")]
        private CodeStruct Heads_Set(Block block)
        {
            Debug.Log("HEADS SET GENERATOR");
            string code = block.GetFieldValue("ANGLE");
            float num = float.Parse(code);
            int order = num < 0 ? CSharp.ORDER_UNARY : CSharp.ORDER_ATOMIC;
            return new CodeStruct(code, order);
        }
    }
}
