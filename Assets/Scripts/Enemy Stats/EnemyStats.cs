using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyRoot : ScriptableObject {

    public string Name;
    public int Life;
    public int Basic_Attack;
    public int Magic_Armor;
    public int Magic_Res;
    public int Physic_Armor;
    public int Physic_Res;

}
[CreateAssetMenu(fileName = "new Enemy", menuName = "Add_Enemy_Warrior")]
class Warrior :EnemyRoot
{
    public int Rage;
}
[CreateAssetMenu(fileName = "new Enemy", menuName = "Add_Enemy_Type_Mage")]
class Mage : EnemyRoot
{
    public int Mana;
    public int Mana_Reg;
}
