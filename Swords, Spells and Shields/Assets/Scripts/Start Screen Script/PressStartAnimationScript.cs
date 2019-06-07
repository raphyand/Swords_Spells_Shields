using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressStartAnimationScript : MonoBehaviour
{
     public Animator anim;
     int levelToLoad = 1;


     void Start()
     {
          anim = this.GetComponent<Animator>();
     }

     //void Update()                                // runs every frame; if mouseclick, pass 1 onto nextSceneTransition funciton
     //{
     //     if (Input.GetMouseButtonDown(0))
     //          nextSceneTransition(levelToLoad);
     //}




     void Update()
     {
          anim.Play("RepeatFade");
          if (Input.GetMouseButtonDown(0))
               nextSceneTransition(levelToLoad);


     }


     public void nextSceneTransition(int levelIndex)   // receive Level Index; then set the animator variable trigger, FadeOut
     {
          levelToLoad = levelIndex;
          anim.SetTrigger("FadeOut");
     }

}
