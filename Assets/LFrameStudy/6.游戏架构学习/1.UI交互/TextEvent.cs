using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace LFrameStudy
{
    public class TextEvent : MonoBehaviour
    {
        public Button m_bth;
        public Toggle m_toggle;
        public Slider m_slider;
        void Start()
        {
            m_bth.onClick.AddListener(OnBthClick);
            m_toggle.onValueChanged.AddListener(OnToggleClick);
            m_slider.onValueChanged.AddListener(OnSliderClick);
        }



        public void OnBthClick()
        {
            Debug.Log("Bth Click");
        }

        public void OnToggleClick(bool isOn)
        {
            Debug.Log("Toggle Is" + isOn);
        }

        public void OnSliderClick(float rate)
        {
            Debug.Log("Slider cur is" + rate);
        }



    }
}
