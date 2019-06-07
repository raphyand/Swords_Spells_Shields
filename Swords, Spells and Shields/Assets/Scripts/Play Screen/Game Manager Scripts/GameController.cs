using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameChoices
{
     NONE,
     SWORD,
     SPELL,
     SHIELD
}

public class GameController : MonoBehaviour
{
     [SerializeField]
     private Sprite sword_sprite, shield_sprite, spell_sprite;

     [SerializeField]
     private Sprite Gsword_sprite, Gshield_sprite, Gspell_sprite;

     [SerializeField]
     private Image CarlChoice_Img, GregChoice_Img;

     [SerializeField]
     private Text infoText;

     private GameChoices CarlChoice = GameChoices.NONE, GregChoice = GameChoices.NONE;

     private GameObject CarlHealthHandler;
     private HealthDisplay CarlHealthTracker;

     private GameObject GregHealthHandler;
     private HealthDisplay GregHealthTracker;

     private AnimationController animationController;

     private DefeatAnimations defeatAnimations;


     void Awake()
     {
          CarlHealthHandler = GameObject.Find("Carl Heart Handler");
          GregHealthHandler = GameObject.Find("Greg Heart Handler");

          CarlHealthTracker = CarlHealthHandler.GetComponent<HealthDisplay>();
          GregHealthTracker = GregHealthHandler.GetComponent<HealthDisplay>();

          defeatAnimations = this.GetComponent<DefeatAnimations>();

          animationController = GetComponent<AnimationController>();
     }

     void Update()
     {

          if (CarlHealthTracker.health == 0)
          {
               //yield return new WaitForSeconds(2f);
               defeatAnimations.CarlGoAway();
          }
          if (GregHealthTracker.health == 0)
          {
               //yield return new WaitForSeconds(2f);
               defeatAnimations.GregGoAway();
          }
          

     }

     public void SetChoices(GameChoices gameChoices)
     {
          switch (gameChoices)
          {
               case GameChoices.SWORD:
                    CarlChoice = GameChoices.SWORD;
                    CarlChoice_Img.sprite = sword_sprite;        // Set Img.sprite to sword sprite
                    break;
               case GameChoices.SHIELD:
                    CarlChoice = GameChoices.SHIELD;
                    CarlChoice_Img.sprite = shield_sprite;
                    break;
               case GameChoices.SPELL:
                    CarlChoice = GameChoices.SPELL;
                    CarlChoice_Img.sprite = spell_sprite;
                    break;
          }




          setGregChoice();
          DetermineWinner();
     }

 

     void setGregChoice()
     {
          int rnd = Random.Range(0, 3);
          
          switch (rnd)
          {
               case 0:
                    GregChoice = GameChoices.SWORD;
                    GregChoice_Img.sprite = Gsword_sprite;
                    break;
               case 1:
                    GregChoice = GameChoices.SHIELD;
                    GregChoice_Img.sprite = Gshield_sprite;
                    break;
               case 2:
                    GregChoice = GameChoices.SPELL;
                    GregChoice_Img.sprite = Gspell_sprite;
                    break;

          }
     }

     void DetermineWinner()
     {
          if (CarlChoice == GregChoice)
          {
               infoText.text = "It's a Draw!";
               StartCoroutine(DisplayWinnerAndRestart());
               // This line for DrawscoreScript; make it.
               return;
          }
         
          //Sword Block
          if (CarlChoice == GameChoices.SWORD && GregChoice == GameChoices.SPELL)
          {
               infoText.text = "Carl the Adventurer Wins!";
               StartCoroutine(DisplayWinnerAndRestart());

               // Greg loses one point of health
               GregHealthTracker.health--;
               // This line for DrawscoreScript; make it.
               return;

          }

          if (GregChoice == GameChoices.SWORD && CarlChoice == GameChoices.SPELL)
          {

               infoText.text = "Greg the Goblin Wins!";
               StartCoroutine(DisplayWinnerAndRestart());

               // Carl loses one point of health
               CarlHealthTracker.health--;
               // This line for DrawscoreScript; make it.
               return;
          }
          ////////////////
          ///

          //Shield Block
          if (CarlChoice == GameChoices.SHIELD && GregChoice == GameChoices.SWORD)
          {
               infoText.text = "Carl the Adventurer Wins!";
               StartCoroutine(DisplayWinnerAndRestart());

               // Greg loses one point of health
               GregHealthTracker.health--;
               // This line for DrawscoreScript; make it.
               return;
          }

          if (GregChoice == GameChoices.SHIELD && CarlChoice == GameChoices.SWORD)
          {
               infoText.text = "Greg the Goblin Wins!";
               StartCoroutine(DisplayWinnerAndRestart());

               // Carl loses one point of health
               CarlHealthTracker.health--;
               // This line for DrawscoreScript; make it.
               return;
          }
          ////////////////

          //Spell Block
          if (CarlChoice == GameChoices.SPELL && GregChoice == GameChoices.SHIELD)
          {
               infoText.text = "Carl the Adventurer Wins!";
               StartCoroutine(DisplayWinnerAndRestart());

               // Greg loses one point of health
               GregHealthTracker.health--;
               // This line for DrawscoreScript; make it.
               return;
          }

          if (GregChoice == GameChoices.SPELL && CarlChoice == GameChoices.SHIELD)
          {
               infoText.text = "Greg the Goblin Wins!";
               StartCoroutine(DisplayWinnerAndRestart());

               // Carl loses one point of health
               CarlHealthTracker.health--;
               // This line for DrawscoreScript; make it.
               return;
          }
          ////////////////
     }



     IEnumerator DisplayWinnerAndRestart()
     {
          yield return new WaitForSeconds(2f);
          infoText.gameObject.SetActive(true);

          yield return new WaitForSeconds(2f);
          infoText.gameObject.SetActive(false);

          //animationController.removeButtons();
          animationController.showButtons();
     }

}
