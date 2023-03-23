using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectManager : MonoBehaviour
{
    [SerializeField] Animator noteHitAnimator = null;
    [SerializeField] Animator judgementAnimator = null;
    [SerializeField] Image judgementImage = null;
    [SerializeField] Sprite[] judgementSprite = null;
     
    string hit = "Hit"; 
     
    public void JufgementEffect(int pnum)
    { 
        judgementImage.sprite = judgementSprite[pnum];
        judgementAnimator.SetTrigger(hit); 
    }
    
    

 }
