using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace LFrameStudy
{
    public class AsyncLoadScene : MonoBehaviour
    {
        public Image progressBar;
        public Text LodingText;

        private int curProgressValue = 0;
        private AsyncOperation operation;

        private bool isOk=true;

        private void Start()
        {
            SceneManager.sceneLoaded += SceneManager_sceneLoaded;
            SceneManager.sceneUnloaded += SceneManager_sceneUnloaded;
            SceneManager.activeSceneChanged += SceneManager_activeSceneChanged;
            StartCoroutine(LodingScene());
        }

        IEnumerator LodingScene()
        {
          operation=  SceneManager.LoadSceneAsync("Example-02");
            operation.allowSceneActivation = false;
            yield return operation;
        }

        private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
        {
            isOk = false;
        }

        private void SceneManager_sceneUnloaded(Scene arg0)
        {
            isOk = false;

        }

        private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
        {
            isOk = false;

        }



        private void Update()
        {
            int progressValue = 100;
            if (isOk)
            {
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
                    print("ok");
                }
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isOk = true;
            }
        }
    }
}
