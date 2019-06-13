using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
     public Animator optionsAnimator, MenuButtonsController;
     GameObject MainMenuController, OptionsMenuController;


     void Awake()
     {
          MainMenuController = GameObject.Find("Menu Buttons Controller");
          OptionsMenuController = GameObject.Find("Options Menu Buttons Controller");
     }

     public void fadeToOptions()
     {
          optionsAnimator.Play("FadeIn");
          MenuButtonsController.Play("MainMenuFadeOut");
          //Options setActive(true)
          OptionsMenuController.gameObject.SetActive(true);
          //Main Menu setActive(false)
          MainMenuController.gameObject.SetActive(false);
     }

     public void fadeFromOptions()
     {
          optionsAnimator.Play("FadeOut");
          MenuButtonsController.Play("MainMenuButtonsFadeIn");
          //Options setActive(false)
          OptionsMenuController.gameObject.SetActive(false);
          //Main menu setActive(true)
          MainMenuController.gameObject.SetActive(true);
     }

}
