using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
       IEnumerator OnCollisionEnter(Collision other)
       {
              Destroy(other.gameObject);
              yield return new WaitForSeconds(2);//wait for two seconds
              SceneManager.LoadScene(0);//load the scene again
       }//press return to get the usings up there
}