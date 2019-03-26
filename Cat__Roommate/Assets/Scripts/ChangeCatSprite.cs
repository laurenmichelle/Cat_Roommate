using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCatSprite : MonoBehaviour
{
    //public Sprite catBigSmile;
    //public Sprite catBigSmiletears;
    //public Sprite catOpenSmile;
    //public Sprite catHeartEyes;
    //public Sprite catSnarky;
    //public Sprite catKiss;
    //public Sprite catEyesclosed;
    //public Sprite catFrown;
    //public Sprite catTear;
    //public Sprite catWail;
    public Sprite catDefault;
    public GameObject PointTracker;
    private int _goodResponses;
    private int _badResponses;
    private int _previousBadResponse;
    private int _previousGoodResponse;
    private Sprite currentSprite;
    public Sprite[] allCats;
    public Sprite[] badCats;
    public Sprite[] goodCats;
    public float turnSpeed;
    public GameObject _Dial;

    public AudioSource meow;
    //public AudioClip meowSound;



    // Start is called before the first frame update
    void Start()
    {

        _previousGoodResponse = 0;
        _previousBadResponse = 0;
        //meow.clip = meowSound;

        //turnSpeed = 100f;
       



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)){
            gameObject.transform.Rotate(new Vector3(0,0,turnSpeed * Time.deltaTime));
        }

    }

    public void changeSprite()

    {

        _goodResponses = PointTracker.GetComponent<PointTracker>().goodResponses;
        _badResponses = PointTracker.GetComponent<PointTracker>().badResponses;
        currentSprite = gameObject.GetComponent<SpriteRenderer>().sprite;

        Debug.Log("Bad Responses : " + PointTracker.GetComponent<PointTracker>().badResponses);
        Debug.Log("Good Responses : " + PointTracker.GetComponent<PointTracker>().goodResponses);
       if(_badResponses + _goodResponses >=7)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = catDefault;
            
        }





        else if(_previousBadResponse< _badResponses)
        {
            int k = Random.Range(0, 5);
            gameObject.GetComponent<SpriteRenderer>().sprite = badCats[k];
            _previousBadResponse += 1;
            _Dial.transform.Rotate(new Vector3(0, 0,10 ));
            meow.Play();

            //gameObject.transform.Rotate(new Vector3(0, 0, turnSpeed * Time.deltaTime));


        }
        else if(_previousGoodResponse < _goodResponses)
        {
            int j = Random.Range(0, 5);
            gameObject.GetComponent<SpriteRenderer>().sprite = goodCats[j];
            Debug.Log("PREVIOUS GOOD RESPONSE: " + _previousGoodResponse);
            _previousGoodResponse += 1;
            Debug.Log("PREVIOUS GOOD RESPONSE: " + _previousGoodResponse);
            _Dial.transform.Rotate(new Vector3(0, 0, -10));
            meow.Play();
        }

       
}
}
