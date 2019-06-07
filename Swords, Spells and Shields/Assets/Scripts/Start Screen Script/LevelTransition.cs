using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelTransition : MonoBehaviour
{
     public Animator animator;
     public Animator animator2;
     private int levelToLoad = 1;
     private int testLevelToLoad = 0;
     

     //void Update()                                // runs every frame; if mouseclick, pass 1 onto nextSceneTransition funciton
     //{
     //     if (Input.GetMouseButtonDown(0))
     //          nextSceneTransition(levelToLoad);
     //}

     public void nextSceneTransition(int levelIndex)   // receive Level Index; then set the animator variable trigger, FadeOut
     {
          levelToLoad = levelIndex;
          animator.SetTrigger("FadeOut");
     }

     public void onTransitionComplete()           // Load Scene by Index
     {
          SceneManager.LoadScene(levelToLoad); 
     }

     public void setFadeOutTrigger()
     {
          animator.SetTrigger("FadeOut");
          if (animator2)
               animator2.SetTrigger("FadeOut");
     }

     public void setQuitFadeOutTrigger()
     {
          animator.Play("FadeToQuit");
          animator.SetTrigger("QuitFadeOut");
     }

     public void loadPlayScene()           // Load Scene by Name
     {    

          
          //SceneManager.LoadScene("2A_PlaySceneV1");
          SceneManager.LoadScene("2A_PlaySceneV2");
     }


     public void QuitGame()
     {

          Application.Quit();
          Debug.Log("Game is exiting.");
     }


}
