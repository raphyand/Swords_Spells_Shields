using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
     private AnimationController animationController;
     private GameController gameplayController;

     private string playerChoice;


     void Awake()
     {
          
          animationController = GetComponent<AnimationController>();
          gameplayController = GetComponent<GameController>();
     }

     public void GetChoice()
     {
          string choiceName = UnityEngine.EventSystems.
               EventSystem.current.currentSelectedGameObject.name;

          GameChoices selectedChoice = GameChoices.NONE;

          switch (choiceName)
          {
               case "Sword":
                    selectedChoice = GameChoices.SWORD;
                    break;
               case "Shield":
                    selectedChoice = GameChoices.SHIELD;
                    break;
               case "Spell":
                    selectedChoice = GameChoices.SPELL;
                    break;
          }

          gameplayController.SetChoices(selectedChoice);
          animationController.removeButtons();
          //animationController.showButtons();

     }


}
