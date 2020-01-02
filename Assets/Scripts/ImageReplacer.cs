using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageReplacer : MonoBehaviour {

    public UIHandlerInfinite UII;
    public UIHandlerHiragana UIH;
    public UIHandlerDakuten UID;
    public UIHandlerCombo UIC;
    public UIHandlerAll UIA;
    public Sprite sprite1; // Blank sprite is placed here   
    public Sprite sprite2;
    public Sprite[] spritearray;
    public int tCount;

    public SpriteRenderer spriteRenderer;

    public List<Sprite> mSprites;
    public List<Sprite> nSprites;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        mSprites = new List<Sprite>();
        foreach(var tSprite in spritearray)
        {
            mSprites.Add(tSprite);
        }
        ChangeTheDamnSprite();
    }

    public bool ChangeTheDamnSprite()
    {
        tCount = mSprites.Count; // sets tCount to the length of the list
        if (tCount > 0) // if there is still something in the list then do this
        {
            spriteRenderer.sprite = mSprites[Random.Range(0, tCount)];
            nSprites.Add(spriteRenderer.sprite);
            mSprites.Remove(spriteRenderer.sprite);
            return true;
        }
        return false;
    }

    public bool GoAgain()
    {
        Debug.Log("GoAgain has been called");
        
        foreach (var tSprite in nSprites)
        {
            mSprites.Add(tSprite);
            tCount = mSprites.Count;
        }
        if (tCount >= 46)
        {
            nSprites.Clear();
            ChangeTheDamnSprite();
            return true;
        }
        return false;
    }
}

