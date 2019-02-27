using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager 
{
    private string sceneName;//当前场景名称
    private string nextSceneName;//下一个场景名称
    private string cutSceneName;//切换场景名称
    private Queue<string> nomalLevel = new Queue<string>();//普通关卡
    private List<string> hiddenLevel = new List<string>();//隐藏关卡
    private string mainSceneName;//主场景名称
    public LevelManager()
    {
        Init();
    }
    public void Init()
    {
        //给所有场景赋值
        cutSceneName = "CutScene";
        //初始化nomalLevel  如队列
        //初始化隐藏关卡
        //设置SceneName等于当前场景名称

    }
    public string NextSceneName
    {
        get {
            return nextSceneName;
        }
    }
    public string CutSceneName {
        get { return cutSceneName; }
    }
    /// <summary>
    /// 添加关卡属性
    /// </summary>
    public string NomalLevel
    {
        set { nomalLevel.Enqueue(value); }
    }
    /// <summary>
    /// 添加隐藏关卡属性
    /// </summary>
    public string HiddenLevel
    {
        set { hiddenLevel.Add(value); }
    }
    /// <summary>
    /// 进入选择关卡
    /// </summary>
    public void ChooseScene(string name)
    {
        nextSceneName = name;
        CutScene();
    }

    /// <summary>
    /// 进入下一个普通关卡
    /// </summary>
    public void NomalScene()
    {
        if (nomalLevel != null) {
            nextSceneName = nomalLevel.Dequeue();
        }
        else
        {
           // print("Queue中无关卡");
        }
        //先进入加载场景中，在加载场景中加载nextScene。
        CutScene();
    }
    /// <summary>
    /// 随机进入某一个隐藏关卡
    /// </summary>
    public void HiddenScene()
    {
        if (hiddenLevel != null)
        {
            int index = Random.Range(0, hiddenLevel.Count);
            nextSceneName = hiddenLevel[index];
        }
        else
        {
          //  print("暂时没有随机关卡");
        }
        CutScene();
    }
    /// <summary>
    /// 进入主场景
    /// </summary>
    public void MainScene()
    {
        nextSceneName = mainSceneName;
        CutScene();
    }
    /// <summary>
    /// 切换场景
    /// </summary>
    private void CutScene()
    {
        SceneManager.LoadScene(cutSceneName);
    }
    
    public void updateMassage()
    {
        //寻找人物的初始落点
        //初始化人物的资源
        //初始化人物的武器
    }

    public string Text()
    {
        return "Text成功";
    }

}
