using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefeatAnimations : MonoBehaviour
{

     //[SerializeField]
     private Animator CarlHandler, GregHandler;

     
     void Awake()   // Get the animator components for Carl and Greg
     {
          CarlHandler = GameObject.Find("Carl Handler").GetComponent<Animator>();
          GregHandler = GameObject.Find("Greg Handler").GetComponent<Animator>();
     }

     public void CarlGoAway()
     {
          CarlHandler.Play("Carl Defeated");
     }

     public void GregGoAway()
     {
          GregHandler.Play("Greg Defeated");
     }


}
