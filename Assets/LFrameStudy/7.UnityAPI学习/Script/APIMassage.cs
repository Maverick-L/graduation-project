using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LFrameStudy
{
    public class APIMassage : MonoBehaviour
    {
        public GameObject target;
        // Start is called before the first frame update
        void Start()
        {
            //SendMassageOption 可以控制是否必须拥有接收者
            //BroadcastMessage 可以用来广播方法，可以传播到子物体
            target.BroadcastMessage("Attack", null, SendMessageOptions.DontRequireReceiver);
            target.SendMessage("Attack", null, SendMessageOptions.DontRequireReceiver);
            //SendMessageUpwards 用来广播方法，可以传播到父物体
            target.SendMessageUpwards("Attack", null, SendMessageOptions.DontRequireReceiver);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
