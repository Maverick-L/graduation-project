
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatBg : MonoBehaviour {

	public TweenPosition chatPanleTween;

	public void OnChatButtonClick()
	{
		chatPanleTween.PlayForward();
	}

	public void OnCloseChatButtonClick() {
		chatPanleTween.PlayReverse();
	}

}
