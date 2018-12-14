using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting : MonoBehaviour {

	public float volume = 1;

	public void OnVolumeChanged() {
		volume = UIProgressBar.current.value;
	}

	public TweenPosition startPanelTween;
	public TweenPosition playPanleTween;
	public TweenPosition optionPanleTween;

	public void OnPlayButtonClick(){
		startPanelTween.PlayForward();
		playPanleTween.PlayForward();
	}

	public void OnOptionButtonClick() {
		startPanelTween.PlayForward();
		optionPanleTween.PlayForward();
	}

	public void OnCompleteSettingButtonClick() {
		startPanelTween.PlayReverse();
		optionPanleTween.PlayReverse();
	}
}
