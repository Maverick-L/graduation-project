using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace LFrameStudy{
    public class TextPool : MonoBehaviour
    {
        enum Type:uint {
            NPC,
            Marther
        }

        private void Start()
        {
            TextLevelManager(Type.NPC, Type.Marther);
        }
        /*
         * 可变参数使用params+类型数组+变量名，可变参数只能放在最后一个参数
         */

        /*
        * Enum类型可以用来遍历枚举类型，可以获取到枚举类型的对应的int类型，可以使类型在int和string之间转换*/
        public void TextLevelManager(params Enum[] Type)
        {
            foreach (Enum e in Type)
            {
                //Debug.Log(Enum.GetNames(typeof(e)));
                Debug.Log(e);
            }
        }
    }
}
