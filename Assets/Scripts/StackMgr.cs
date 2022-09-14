using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class StackMgr : MonoBehaviour
{
   public string sceneName;
   private SoundManager soundManager;
   private bool repetir = true;

   void Awake() {
      soundManager = FindObjectOfType<SoundManager>();
   }
   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Vaca"))
      {
        other.transform.parent = null;
        other.gameObject.AddComponent<Rigidbody>().isKinematic = true;
        other.gameObject.AddComponent<StackMgr>();
        other.gameObject.GetComponent<Collider>().isTrigger = true;
        other.tag = gameObject.tag;
        
        GameManager.GameManagerInstance.Recoger.Add(other.transform);
        soundManager.SeleccionAudio(2, 0.1f);

      }

      if (other.CompareTag("obs"))
      {
         
         var NoSub = 1;

         if (GameManager.GameManagerInstance.Recoger.Count > NoSub)
         {
           for (int i = 0; i < NoSub; i++)
           {
            GameManager.GameManagerInstance.Recoger.ElementAt( GameManager.GameManagerInstance.Recoger.Count - 1).gameObject.SetActive(false);
            GameManager.GameManagerInstance.Recoger.RemoveAt( GameManager.GameManagerInstance.Recoger.Count - 1 );
            soundManager.SeleccionAudio(1, 0.05f);
           }
         }

         if (GameManager.GameManagerInstance.Recoger.Count <= 0)
         {
            GameManager.GameManagerInstance.StartTheGame = false;
            GameManager.GameManagerInstance.bgameOver = true;

            GameManager.GameManagerInstance.GameOver();
         }

         //other.GetComponent<Collider>().enabled = false;


      }

      if (other.CompareTag("final") && repetir == true) {
         soundManager.SeleccionAudio(3, 0.05f);
         repetir = false;
        
         
         StartCoroutine(FinalNivel());

         //SceneManager.LoadScene(3);
         
         IEnumerator FinalNivel() 
          {
           yield return new WaitForSeconds(1.0f);
    
           SceneManager.LoadScene(3);
          }
      }
   }

  

}
