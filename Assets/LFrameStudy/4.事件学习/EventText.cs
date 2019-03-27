using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LFrameStudy
{
    public class EventText : MonoBehaviour
    {

        void Start()
        {
            Ddelegate.instance.BossHpEvent += BossHp;
            Ddelegate.instance.BossHpWithReturnEvent += BossHpWithReturn;

        }

        // Update is called once per frame

        public void BossHp(int hp)
        {
            Debug.Log(hp);
        }


        private string BossHpWithReturn(int hp)
        {
            Debug.Log(hp + 20);
            return "yes";
        }
    }
}
