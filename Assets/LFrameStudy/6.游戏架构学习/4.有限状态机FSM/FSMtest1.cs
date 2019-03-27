using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LFrameStudy
{
    public class FSMtest1 : MonoBehaviour
    {
        public FSM fsm;
        // Start is called before the first frame update
        void Start()
        {
            fsm = new FSM();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.Y))
            {
                fsm.HandleInput(TRAN_INPUT.BUTTON_A);
                StopAllCoroutines();
                StartCoroutine(autoTimeOut(2));
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                fsm.HandleInput(TRAN_INPUT.BUTTON_B);
                StopAllCoroutines();
                StartCoroutine(autoTimeOut(1));
            }
        }

        IEnumerator autoTimeOut(float sec)
        {
            yield return new WaitForSeconds(sec);
            fsm.HandleInput(TRAN_INPUT.TIME_OUT);
        }
    }
}
