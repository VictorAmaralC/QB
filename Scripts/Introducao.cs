using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Introducao : MonoBehaviour {

	public Text text;

	void Start(){ 
		StartCoroutine (AnimateText ("..."));
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			i = -1;
			j = -1;
		}
	}

	private int i = 0;
	private int j = 0;

	IEnumerator AnimateText(string strComplete){
		text.text = "";
		while(i < strComplete.Length && i >= 0){
			
			text.text += strComplete[i++];
			yield return new WaitForSeconds(0.5F);
			if (text.text == "..." && i >= 0) {
				text.text = "";
				i = 0;
			}
		}
		yield return StartCoroutine (AnimateText0 ("190, qual é a emergência?"));
		while (!Input.GetKeyDown (KeyCode.Space))
			yield return null;		
		yield return StartCoroutine (AnimateText0 ("É... Acabei de acordar e ouvi alguns barulhos estranhos vindos de fora da casa. Acho que tem alguém tentando entrar aqui."));
		while (!Input.GetKeyDown (KeyCode.Space))
			yield return null;	
		yield return StartCoroutine (AnimateText0("Conseguiu ver o suspeito?"));
		while (!Input.GetKeyDown (KeyCode.Space))
			yield return null;	
		yield return StartCoroutine (AnimateText0("Não vi nada, tá muito escuro lá fora."));
		while (!Input.GetKeyDown (KeyCode.Space))
			yield return null;	
		yield return StartCoroutine (AnimateText0("Estamos enviando uma viatura. Ela chega em 10 minutos."));
		while (!Input.GetKeyDown (KeyCode.Space))
			yield return null;
		SceneManager.LoadSceneAsync("Cena01");
	}
		
	IEnumerator AnimateText0(string strComplete){
		j = 0;
		text.text = "";
		while (j < strComplete.Length){
			if (j < 0) {
				text.text = strComplete;
				yield return new WaitForEndOfFrame ();
				break;
			}
			text.text += strComplete [j++];
			yield return new WaitForSeconds (0.05F);
		}
	}
}
