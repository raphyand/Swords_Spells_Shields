using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryMenu : MonoBehaviour
{
     public Animator GalleryAnimator, MenuButtonsController;
     GameObject MainMenuController, GalleryMenuController;


     void Awake()
     {
          MainMenuController = GameObject.Find("Menu Buttons Controller");
          GalleryMenuController = GameObject.Find("Gallery Buttons Handler");
     }

     public void fadeToGallery()
     {
          GalleryAnimator.Play("FadeIn");
          MenuButtonsController.Play("MainMenuFadeOut");
          //Options setActive(true)
          GalleryMenuController.gameObject.SetActive(true);
          //Main Menu setActive(false)
          MainMenuController.gameObject.SetActive(false);
     }

     public void fadeFromGallery()
     {
          GalleryAnimator.Play("FadeOut");
          MenuButtonsController.Play("MainMenuButtonsFadeIn");
          //Options setActive(false)
          GalleryMenuController.gameObject.SetActive(false);
          //Main menu setActive(true)
          MainMenuController.gameObject.SetActive(true);
     }
}
