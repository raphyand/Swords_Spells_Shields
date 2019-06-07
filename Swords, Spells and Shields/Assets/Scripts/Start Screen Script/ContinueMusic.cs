using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueMusic : MonoBehaviour
{
     Scene current;
     string nameOfCurrent;

     public bool toDestroy = false;


     void Awake()
     {
          current = SceneManager.GetActiveScene();
          nameOfCurrent = current.name;
          if (nameOfCurrent == "2A_PlaySceneV2")
               Destroy(GameObject.Find("Start and Menu Background Audio"));
     }

     void Update()
     {
               DontDestroyOnLoad(transform.gameObject);
     }


}
