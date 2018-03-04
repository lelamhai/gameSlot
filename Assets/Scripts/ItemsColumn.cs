using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsColumn : MonoBehaviour
{

    public SpriteRenderer[] ListSpritePerColumn; //handle tung items cua cot
    float speed;
    float endposition;
    float startposition;
    public ListItems listItems;
    public bool isSpinning;
    private void Start()
    {
        endposition = -0.91f * 4f;
        startposition = 0.91f * 2;
        speed = 5 * Time.deltaTime;
    }

    public void StartSpin()
    {
        for (int i = 0; i < ListSpritePerColumn.Length; i++)
        {
            ListSpritePerColumn[i].transform.position = new Vector3(ListSpritePerColumn[i].transform.position.x, ListSpritePerColumn[i].transform.position.y - speed, ListSpritePerColumn[i].transform.position.z);
            if (ListSpritePerColumn[i].transform.position.y < endposition)
            {
                float tru = -ListSpritePerColumn[i].transform.position.y + endposition;
                ListSpritePerColumn[i].transform.position = new Vector3(ListSpritePerColumn[i].transform.position.x, startposition - speed * 5 - tru - 0.91f / 2f, ListSpritePerColumn[i].transform.position.z);
                ListSpritePerColumn[i].sprite = listItems.ListSprite[Random.Range(0, listItems.ListSprite.Length)];
            }
        }
    }
    public void Stopspin()
    {
        isSpinning = false;
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
}
