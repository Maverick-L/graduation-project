using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipBg : MonoBehaviour {

	public TweenPosition equipPanleTween;

	public void OnEquipButtonClick(){
		equipPanleTween.PlayForward();
	}

	public void OnCloseEquipButtonClick() {
		equipPanleTween.PlayReverse();
	}
}
