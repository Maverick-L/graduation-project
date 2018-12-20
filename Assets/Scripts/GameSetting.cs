using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting : MonoBehaviour {

	public float volume = 1;
	public void OnVolumeChanged() {
		volume = UIProgressBar.current.value;//调节声音大小
	}

	//设置画面切换
	public TweenPosition startPanelTween;
	public TweenPosition optionPanleTween;


	public void OnOptionButtonClick() {
		startPanelTween.PlayForward();
		optionPanleTween.PlayForward();
	}

	public void OnCompleteSettingButtonClick() {
		startPanelTween.PlayReverse();
		optionPanleTween.PlayReverse();
	}

}
