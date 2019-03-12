using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerResponse : MonoBehaviour
{
    public bool _leftResponse;
    public bool _rightResponse;
    public bool _leftResponseChosen;
    public bool _rightResponseChosen;
    public TextMeshProUGUI _rightResponsetxt;
    public TextMeshProUGUI _leftResponsetxt;
    public GameObject CatRoommateQuestions;
    public GameObject Response2;
    public GameObject Response1;
    public GameObject ChangeCatSprite;
    public GameObject PointTracker;

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {


        //If Right Arrow key is pushed
        if (Input.GetAxis("Horizontal") > 0)
        {
            _rightResponse = true;
            _leftResponse = false;
            _rightResponsetxt.color = new Color(255,255,255,100);
            _leftResponsetxt.color = new Color(0, 0, 0, 100);
            //Debug.Log("The Color should be black on the right");
        }

        //If Left Arrow Key is Pushed
        else if (Input.GetAxis("Horizontal") < 0)
        {
            _leftResponse = true;
            _rightResponse = false;
            _leftResponsetxt.color = new Color(255,255,255,100);
            _rightResponsetxt.color = new Color(0,0,0, 100);
            //Debug.Log("The Color should be black on the left");
        }

        //Once Return Key is pushed
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("NEXT QUESTIONS");
            if (_leftResponse == true)
            {
                _leftResponseChosen = true;
                _rightResponseChosen = false;

                Debug.Log("LEFT RESPONSE CHOSEN");


            }
            else if(_rightResponse == true)
            {
                _rightResponseChosen = true;
                _leftResponseChosen = false;
                Debug.Log("RIGHT RESPONSE CHOSEN");
            }
            Response1.GetComponent<ChangeQuestion>().changeQuestion();
            Response2.GetComponent<ChangeQuestion>().changeQuestion();
           
            CatRoommateQuestions.GetComponent<ChangeQuestion>().changeQuestion();
            PointTracker.GetComponent<PointTracker>().PointUpdate();


        }
    }
}
