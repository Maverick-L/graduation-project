using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagers : MonoBehaviour {

    public static GameManagers _instance;
    public PoolManager _poolManager;
    public AudioManager _audioManager;
    public GUIManager _guiManager;
    public LevelManager _levelManager;
    public Effect _effect;
    private void Start()
    { 
        if (_instance == null)
        {
            _instance = this;
        }
        DontDestroyOnLoad(_instance);
        initManager();
    }

    public void initManager()
    {
        _poolManager = new PoolManager();
        _audioManager = new AudioManager();
        _guiManager = new GUIManager();
        _levelManager = new LevelManager();
        _effect = new Effect();
    }
    /// <summary>
    /// 创建一个怪物
    /// </summary>
    public void CreatEnemy(Transform targetTransform, GameObject targetObject, int grade, float speed, float blood = 100,float attackDamage = 5f, float attackRange = 10f)
    {
      GameObject go= _poolManager.Create(targetTransform, targetObject, PoolManager.Type.NPC);
        go.SetActive(true);
        //初始化
        go.GetComponent<Enemy>().Init(attackDamage, attackRange, grade,speed,blood);
    }
    /// <summary>
    /// 创建Player
    /// </summary>
    public void CreatePlayer(Transform targetTransform, GameObject targetObject, int grade, float speed, float blood=100f)
    {
        GameObject go = _poolManager.Create(targetTransform, targetObject, PoolManager.Type.NPC);
        go.SetActive(true);
        go.GetComponent<Player>().Init(grade,speed,blood);
    }
    /// <summary>
    /// 创建Merchant
    /// </summary>
    public void CreateMerchant(Transform targetTransform, GameObject targetObject)
    {
        GameObject go = _poolManager.Create(targetTransform, targetObject, PoolManager.Type.NPC);
        go.SetActive(true);
        //go.GetComponent<Player>().Init();
    }
    /// <summary>
    /// 清除对象池中所有数据
    /// </summary>
    public void ResetPool()
    {
        _poolManager.ResetPool();
    }
    /// <summary>
    /// 怪物或者人物的状态
    /// </summary>
    /// <param name="effect"></param>
    /// <param name="Target"></param>
    public void CreateEffect(Effects.Effect effect,GameObject Target)
    {
        _effect.Task(effect, Target);
    }
}


