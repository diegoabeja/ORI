using UnityEngine;
using UnityEngine.SceneManagement;

public class R_Nivel3 : MonoBehaviour {
 public void OnButtonClick()
 {
    SceneManager.LoadScene(1,LoadSceneMode.Additive);
 	//Debug.Log("Clcik");
 }

 public void SiguienteEscena(){
 	SceneManager.LoadScene("Nivel_3");
 }
	
	}
