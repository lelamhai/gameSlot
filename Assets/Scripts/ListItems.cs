using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListItems : MonoBehaviour
{
    // cau hoi anh dat ra cho em o day la`, se stop nhu the nao ?, lam sao anh stop dc tung cot theo y muon
    // de em coi lai code, 2 ngay em tra loi anh
    public SpriteRenderer[] ListSprite; //handle all items theo index
    public ItemsColumn[] ListItemsColumn; //handle  all column
    public MainGameController MainGame;
    public bool isSpinning;
    private void Update()
    {
        // gio chay o day 

        if (isSpinning)
        {
            for (int i = 0; i < ListItemsColumn.Length; i++)
            {
                ListItemsColumn[i].StartSpin();
            }
        }
    }
}
