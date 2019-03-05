using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCatSprite : MonoBehaviour
{
    public Sprite catBigSmile;
    public Sprite catBigSmiletears;
    public Sprite catOpenSmile;
    public Sprite catHeartEyes;
    public Sprite catSnarky;
    public Sprite catKiss;
    public Sprite catEyesclosed;
    public Sprite catFrown;
    public Sprite catTear;
    public Sprite catWail;
    public Sprite catDefault;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeSprite()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = catBigSmile;
    }
}
