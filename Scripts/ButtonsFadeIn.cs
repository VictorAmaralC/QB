using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsFadeIn : MonoBehaviour {

	private float i = 1;
	public CanvasGroup cg;
	private float Wait = 3;

	void Update(){
		Wait -= Time.deltaTime;
		if (Wait <= 0) {
			cg = GetComponent <CanvasGroup> ();
			cg.alpha = Mathf.SmoothDamp (cg.alpha, 1, ref i, 1);
		}
	}
}
