using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class AsyncLoadScene : MonoBehaviour
{
    public Image progressBar;
    public Text LodingText;

    private int curProgressValue = 0;
    private AsyncOperation operation;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == GameManagers._instance._levelManager.CutSceneName)
        {
            StartCoroutine(AsynLoding());
        }   
    }

    IEnumerator  AsynLoding()
    {
        operation = SceneManager.LoadSceneAsync(GameManagers._instance._levelManager.NextSceneName);
        operation.allowSceneActivation = false;
        yield return operation;
    }

    private void Update()
    {
        int progressValue = 100;
        if (curProgressValue < progressValue)
        {
            curProgressValue++;
        }
        LodingText.text = curProgressValue + "%";
        progressBar.fillAmount = curProgressValue / 100f;
        if (curProgressValue == 100)
        {
            operation.allowSceneActivation = true;
            LodingText.text = "OK";
        }
    }
}
