using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameController : MonoBehaviour {

    public  ListItems listItems;
    public EffecttManager EffectManager; //control effect
  
    //MainGame se ra lenh cho ListItems Scroll cot. nao` co.t nao
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      // gio ko chay o day nua
    }
    public void SpinColumn()
    {
        listItems.isSpinning = true;
    }
}
