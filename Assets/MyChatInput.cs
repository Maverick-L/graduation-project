using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyChatInput : MonoBehaviour {

	private UIInput Input;
	public UITextList textList;
	private string[] names = new string[] {
		"coco",
		"liran"
	};

	private void Awake()
	{
		Input = this.GetComponent<UIInput>();
	}

	public void OnChatSubmit() {
		string chatMessage = Input.value;
		string name = names[Random.Range(0, 2)];
		textList.Add(name+" : "+chatMessage);
		Input.value = "";

	}
}
