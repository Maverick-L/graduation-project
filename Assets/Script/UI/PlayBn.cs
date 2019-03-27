using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayBn : MonoBehaviour
{
	public Text UIText;
	public GameObject LoginPanel, PlayerPanel;
	private float timer;

    void Start()
    {
		timer = 0.0f;
    }

	void Update()
	{
		timer += Time.deltaTime * 2;
		if (timer % 2 > 1.0f)
		{
			UIText.text = "";
		}
		else
		{
			UIText.text = "开始游戏";
		}
    }

	public void PlayBnOnClick()
	{
		LoginPanel.SetActive(false);
		PlayerPanel.SetActive(true);
	}
}
