using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListItems : MonoBehaviour
{
    // cau hoi anh dat ra cho em o day la`, se stop nhu the nao ?, lam sao anh stop dc tung cot theo y muon
    // de em coi lai code, 2 ngay em tra loi anh
    public Sprite[] ListSprite; //handle all items theo index
    public ItemsColumn[] ListItemsColumn; //handle  all column
    public MainGameController MainGame;

    void FixedUpdate()
    {
        // gio chay o day 

        for (int i = 0; i < ListItemsColumn.Length; i++)
        {
            if (ListItemsColumn[i].isSpinning)
            {
                ListItemsColumn[i].StartSpin();
            }
        }

    }

    public IEnumerator StopSpinC()
    {
        for (int i = 0; i < ListItemsColumn.Length; i++)
        {
            ListItemsColumn[i].Stopspin();
            yield return new WaitForSeconds(2f);
        }
    }
    public void StopSpin()
    {
        StartCoroutine(StopSpinC());
    }
}

