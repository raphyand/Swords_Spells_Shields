using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Credits : MonoBehaviour
{
     public Animator CreditsButtonHandler, LogoHandler, MenuButtonsController, CreditsTextHandler, CreditsBackButtonHandler;
     GameObject MainMenuController, OptionsMenuController, GalleryMenuController;

     void Awake()
     {
          MainMenuController = GameObject.Find("Menu Buttons Controller");
          OptionsMenuController = GameObject.Find("Options Menu Buttons Controller");
          GalleryMenuController = GameObject.Find("Gallery Buttons Handler");
     }

     public void fadeToCredits()
     {
          CreditsButtonHandler.Play("FadeOut");
          LogoHandler.Play("FadeOut");
          MenuButtonsController.Play("MainMenuFadeOut");
          CreditsTextHandler.Play("FadeIn");
          CreditsBackButtonHandler.Play("FadeIn");
          MainMenuController.gameObject.SetActive(false);
          OptionsMenuController.gameObject.SetActive(false);
          GalleryMenuController.gameObject.SetActive(false);
     }

     public void returnToMenu()
     {
          CreditsButtonHandler.Play("FadeIn");
          LogoHandler.Play("FadeIn");
          MenuButtonsController.Play("MainMenuButtonsFadeIn");
          CreditsTextHandler.Play("FadeOut");
          CreditsBackButtonHandler.Play("FadeOut");
          MainMenuController.gameObject.SetActive(true);
          //OptionsMenuController.gameObject.SetActive(true);
          //GalleryMenuController.gameObject.SetActive(true);
     }

}
