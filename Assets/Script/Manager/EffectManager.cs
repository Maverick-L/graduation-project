using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect
{
    public enum Effects
    {
        Nomal,
        Frozen,//冰冻
        Brun,//灼伤
        Dizziness,//眩晕
    }
}
public class EffectManager 
{
   public  EffectManager()
    {
        init();
    }

  public void init()
    {
        //获取到各个效果的动画或者是粒子效果
    }

    public void Task(Effect.Effects effects,GameObject Target)
    {
        switch (effects)
        {
            case Effect.Effects.Frozen:break;
            case Effect.Effects.Brun:break;
            case Effect.Effects.Dizziness:break;
        }
    }
}
