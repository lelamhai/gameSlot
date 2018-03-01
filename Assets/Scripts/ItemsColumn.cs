using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsColumn : MonoBehaviour
{

    public SpriteRenderer[] ListSpritePerColumn; //handle tung items cua cot

    public void StartSpin()
    {
        for (int i = 0; i < ListSpritePerColumn.Length; i++)
        {
            //move tung items
        }
    }
    public void ChangeImageItems()
    {
        //doi hinh tung items cua tung cot.
    }
    public void StopSpin()
    {
        //stop tung cot o day
    }
}
