using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class GetChartList : MonoBehaviour
{
    public void InitializeCashShopInfo()
    {
        SendQueue.Enqueue(Backed.Chart.GetChartContents, "62757", callback =>
        {
            SetShopInfo(callback);
        });
    }
    void SetShopInfo(BackendReturnObject bro)
    {
        List<Monster> monstarList = new List<Monster>();

        for(int i = 0; i < bro.FlattenRows().Count; i++)
        {
            Monster monster = new Monster(
                bro.FlattenRows()[i]["Monster_Name"].ToString(),
                bro.FlattenRows()[i]["Monster_HP"].ToString(),
                bro.FlattenRows()[i]["Monster_Speed"].ToString()
            );

            monstarList.Add(s);

            SetUnityIAP(monstarList);
        }
    }

    public void SetUnityIAP(List<Monster> monstarList)
    {
        var module = StandardPurchasingModule.Instance();
        ConfigureationBuilder builder = ConfigureationBuilder.Instance();

        foreach(var li in monstarList)
        {
            builder.AddProduct(li.googleProductType.Consumable);
        }

        UnityPurchasing.Initialize(this, builder);
    }


    public class Monster
    {
        string Monster_Name;
        string Monster_HP;
        string Monster_Speed;

        public Monster(string m_name, string m_hp, string m_speed)
        {
            Monster_Name = m_name;
            Monster_HP = m_hp;
            Monster_speed = m_speed;
        }
    }
}
