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
    public GameObject PointTracker;
    private int _goodResponses;
    private int _badResponses;
    private Sprite currentSprite;


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
        _goodResponses = PointTracker.GetComponent<PointTracker>().goodResponses;
        _badResponses = PointTracker.GetComponent<PointTracker>().badResponses;
        currentSprite = gameObject.GetComponent<SpriteRenderer>().sprite;

        Debug.Log("Bad Responses : " + PointTracker.GetComponent<PointTracker>().badResponses);
        Debug.Log("Good Responses : " + PointTracker.GetComponent<PointTracker>().goodResponses);

       if ((_badResponses + _goodResponses)<2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = catOpenSmile;
            Debug.Log("CAT SMILE SHOULD APPEAR");
        }
        else if (_badResponses == 1 && _goodResponses == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = catEyesclosed;
            Debug.Log("CAT EYES CLOSED");
        }
        else if (_badResponses == 2 && _goodResponses == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = catKiss;
            Debug.Log("CAT FROWN");
        }
        else if (_badResponses == 0 && _goodResponses == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = catBigSmile;
            Debug.Log("CAT BIG SMILE");
        }
        else if (_badResponses == 1 && _goodResponses == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = catHeartEyes;
            Debug.Log("CAT HEART EYES");
        }
        else if (_badResponses == 2 && _goodResponses == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = catWail;
            Debug.Log("CAT WAIL");
        }
        else if (_badResponses == 3 && _goodResponses == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = catFrown;
            Debug.Log("CAT TEAR");
        }

        else if (_badResponses == 0 && _goodResponses == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = catBigSmiletears;
            Debug.Log("CAT HEART EYES");
        }
        else if (_badResponses == 4 && _goodResponses == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = catTear;
            Debug.Log("CAT TEAR");
        }
        else if (_badResponses == 0 && _goodResponses == 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = catHeartEyes;
            Debug.Log("CAT HEART EYES");
        }
        else if (_badResponses == 2 && _goodResponses == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = catOpenSmile;
            Debug.Log("CAT HEART EYES");
        }

    }
}
