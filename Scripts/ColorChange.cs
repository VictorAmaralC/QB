using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour {

	public Text text;
	public float elapsed = 0;
	IEnumerator ColorChange0 (){
		yield return new WaitForEndOfFrame();
		text.color = new Color (Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
	}

	void Update () {
		elapsed += Time.deltaTime;
		if (elapsed >= 0.4f) {
			elapsed = elapsed % 0.4f;
			StartCoroutine (ColorChange0 ());
		}
	}
}
