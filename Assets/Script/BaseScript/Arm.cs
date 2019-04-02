using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm : MonoBehaviour
{
    #region Field

    protected string Name;//武器名字
    protected float attackSpeed;//武器攻击速度
    protected float attackDamage;//武器伤害
    protected int grade;//武器等级
    protected float durable;//武器耐久
    protected int price;//武器售卖价格
    protected Effect.Effects effect;//武器的特殊效果

    #endregion

    #region property

    public float AttackSpeed { get { return attackSpeed; } }
    public float AttackDamage { get { return attackDamage; } }
    public int Grade { get { return grade; } }
    public float Durable { get { return durable; } }
    public int Price { get { return price; } }
    public Effect.Effects Effect { get { return effect; } }
    #endregion

    private void Start()
    {
        Init();
    }
    public virtual void Init() {
        int columnNum = 0;
        int rowNum = 0;
        string[,] item = ExcelContral.DataReader(Application.dataPath + "/Resources/Form/Item.xlsx",ref columnNum,ref rowNum);
       for(int i = 0; i < rowNum; i++)
        {
            print(item[i, 0]);
            print(float.Parse(item[i, 1]));
            print(uint.Parse(item[i, 2]));
            print(uint.Parse(item[i, 3]));

        }
    }

   
    

    
}
