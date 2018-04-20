using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillCoolDown : MonoBehaviour {

    public List<Skill> skills;
    public bool skillactivated = false;



    
    void FixedUpdate()
    {
        
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
            for (int i = 0; i < skills.Count; i++)
            {
                if (skills[i].currentCooldown >= skills[i].cooldown)
                {
                    skills[i].currentCooldown = 0;
                }
            }
            }
            if(Input.GetKeyDown(KeyCode.Alpha2))
            {
            for (int i = 0; i < skills.Count; i++)
            {
                if (skills[i].currentCooldown >= skills[i].cooldown)
                {
                    skills[i].currentCooldown = 0;
                }
            }
        }
        

    }
    void Update()
    {
        
            foreach (Skill s in skills)
            {
                if (s.currentCooldown < s.cooldown)
                {
                    s.currentCooldown += Time.deltaTime;
                    s.skillIcon.fillAmount = s.currentCooldown / s.cooldown;
                }
            }
        
    }
}
[System.Serializable]
public class Skill
{
    public float cooldown;
    public Image skillIcon;
 //   [HideInInspector]
    public float currentCooldown;
}
