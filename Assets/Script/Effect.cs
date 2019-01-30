using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects
{
    public enum Effect
    {
        Nomal,
        Frozen,//冰冻
        Brun,//灼伤
        Dizziness,//眩晕
    }
}
public class Effect : MonoBehaviour
{
   public  Effect()
    {
        init();
    }

  public void init()
    {
        //获取到各个效果的动画或者是粒子效果
    }

    public void Task(Effects.Effect effects,GameObject Target)
    {
        switch (effects)
        {
            case Effects.Effect.Frozen:break;
            case Effects.Effect.Brun:break;
            case Effects.Effect.Dizziness:break;
        }
    }
}
