using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APIApplication : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //返回工程所在目录
        print(Application.dataPath);
        //返回工程下StreamingAsstes目录
        print(Application.streamingAssetsPath);
        print(Application.persistentDataPath);
        print(Application.temporaryCachePath);


        print(Application.identifier);
        print(Application.companyName);
        print(Application.productName);
        print(Application.installerName);
        print(Application.installMode);
        print(Application.isEditor);
        print(Application.isFocused);
        print(Application.isMobilePlatform);
        print(Application.isPlaying);
        print(Application.platform);
        print(Application.unityVersion);
        print(Application.version);
        print(Application.runInBackground);

        Application.Quit();
        Application.OpenURL("WWW.sikiedu.com");
        UnityEngine.ScreenCapture.CaptureScreenshot("游戏截图");



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
