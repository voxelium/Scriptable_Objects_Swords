using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Unity разделяет ассеты на подгруппы с множителем 50. То есть значение 51 поместит новый ассет во вторую группу Asset Menu.
[CreateAssetMenu(fileName = "New SwordData", menuName = "Sword Data", order = 51)]
public class SwordData : ScriptableObject
{

    [SerializeField]
    private string swordName;

    public string SwordName
    {
        get
        {
            return swordName;
        }
    }


    [SerializeField]
    private string description;

    public string Description
    {
        get
        {
            return description;
        }
    }


    [SerializeField]
    private Sprite icon;

    public Sprite Icon
    {
        get
        {
            return icon;
        }
    }


    [SerializeField]
    private int goldCost;

    public int GoldCost
    {
        get
        {
            return goldCost;
        }
    }


    [SerializeField]
    private int attackDamage;

    public int AttackDamage
    {
        get
        {
            return attackDamage;
        }
    }
}
