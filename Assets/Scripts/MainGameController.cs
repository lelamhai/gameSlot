using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameController : MonoBehaviour {

    public ListItems listItems;
    public EffecttManager EffectManager; //control effect


    public void StopButton()
    {

        listItems.StopSpin();
    }
    public void ButtonStartSpin()
    {
        for (int i = 0; i < listItems.ListItemsColumn.Length; i++)
        {
            listItems.ListItemsColumn[i].isSpinning = true;
        }
    }
}
