using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
     [SerializeField]    //private, but shown in inspector; animators
     private Animator CarlButtonAnimator, SelectionAnimator;


      void Awake()
     {
          CarlButtonAnimator.Play("FadeIn");
     }


     public void showButtons() // Used before player clicks on a choice
     {
          CarlButtonAnimator.Play("FadeIn");
          SelectionAnimator.Play("ResetChosen");
     }

     public void removeButtons() // Used after the player clicks on a choice
     {
          CarlButtonAnimator.Play("FadeOut");
          SelectionAnimator.Play("RevealChosen");
     }


}
