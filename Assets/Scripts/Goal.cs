using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
       IEnumerator OnCollisionEnter(Collision other)
       {      
              yield return new WaitForSeconds(1);//wait for two seconds
              SceneManager.LoadScene("WinScene");//load the scene again
       }//press return to get the usings up there
}
