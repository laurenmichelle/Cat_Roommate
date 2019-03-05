using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerResponse : MonoBehaviour
{
    public bool _leftResponse;
    public bool _rightResponse;
    public TextMeshProUGUI _rightResponsetxt;
    public TextMeshProUGUI _leftResponsetxt;
    public GameObject CatRoommateQuestions;
    public GameObject Response2;
    public GameObject Response1;
    public GameObject ChangeCatSprite;

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello please work");

        //If Right Arrow key is pushed
        if (Input.GetAxis("Horizontal") > 0)
        {
            _rightResponse = true;
            _leftResponse = false;
            _rightResponsetxt.color = new Color(0, 0, 0,100);
            _leftResponsetxt.color = new Color(255, 255, 255, 100);
            Debug.Log("The Color should be black on the right");
        }

        //If Left Arrow Key is Pushed
        else if (Input.GetAxis("Horizontal") < 0)
        {
            _leftResponse = true;
            _rightResponse = false;
            _leftResponsetxt.color = new Color(0, 0, 0, 100);
            _rightResponsetxt.color = new Color(255, 255, 255, 100);
            Debug.Log("The Color should be black on the left");
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("NEXT QUESTIONS");
            Response1.GetComponent<ChangeQuestion>().changeQuestion();
            Response2.GetComponent<ChangeQuestion>().changeQuestion();
            CatRoommateQuestions.GetComponent<ChangeQuestion>().changeQuestion();
            ChangeCatSprite.GetComponent<ChangeCatSprite>().changeSprite();

        }
    }
}
