using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
   public void play(){
       SceneManager.LoadScene("Game");
   }

   public void getOptions(){
       SceneManager.LoadScene("OptionsMenu");
   }


}
