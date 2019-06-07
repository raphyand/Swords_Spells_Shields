using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Credits : MonoBehaviour
{
     public Animator CreditsButtonHandler, LogoHandler, MenuButtonsController, CreditsTextHandler, CreditsBackButtonHandler;


     public void fadeToCredits()
     {
          CreditsButtonHandler.Play("FadeOut");
          LogoHandler.Play("FadeOut");
          MenuButtonsController.Play("MainMenuFadeOut");
          CreditsTextHandler.Play("FadeIn");
          CreditsBackButtonHandler.Play("FadeIn");


     }

     public void returnToMenu()
     {
          CreditsButtonHandler.Play("FadeIn");
          LogoHandler.Play("FadeIn");
          MenuButtonsController.Play("MainMenuButtonsFadeIn");
          CreditsTextHandler.Play("FadeOut");
          CreditsBackButtonHandler.Play("FadeOut");
     }

}
