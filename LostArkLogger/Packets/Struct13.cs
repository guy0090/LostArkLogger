using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class Struct13
    {
        public Struct13(BitReader reader)
        {
            num = reader.ReadUInt16();
            for(var i = 0; i < num; i++)
            {
                statusEffectDatas.Add(new StatusEffectData(reader));
            }
        }
        public UInt16 num;
        public List<StatusEffectData> statusEffectDatas = new List<StatusEffectData>();
    }
}
