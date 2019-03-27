using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LFrameStudy
{
    public class TaxtTime : MonoBehaviour
    {
        private void Update()
        {
            Debug.Log("TimeScale: " + Time.timeScale + "\n" +
                 "DeltaTime: " + Time.deltaTime + "\n" +
                 "Unscaled DeltaTime: " + Time.unscaledDeltaTime + "\n" +
                 "Smooth DeltaTime: " + Time.smoothDeltaTime);
        }
        private void OnGUI()
        {
            //游戏时间线
            GUILayout.Label("Time Scale: " + Time.timeScale);
            Time.timeScale = GUILayout.HorizontalSlider(Time.timeScale, 0, 2, GUILayout.Width(200));
            GUILayout.Space(20);
            //显示时间流失线
            GUILayout.Label("RealTime: " + Time.realtimeSinceStartup);
            GUILayout.Label("GameTime: " + Time.time);
            GUILayout.Space(20);
        }
    }
}
