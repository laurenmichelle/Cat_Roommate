using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// This Function is used to change the text of both the Cat Roommate & the Player's responses
public class ChangeQuestion : MonoBehaviour
{
    public TextMeshProUGUI _catQuestions;
    public string[] _allQuestions;
    private int _currentQuestion = 0;
    private int _totalQuestions;
    public GameObject PointTracker;
    private int _goodResponses;
    private int _badResponses;
    public AudioSource hiss;
    //public AudioClip hissSound;
    public AudioSource purr;
    //public AudioClip purrSound;


    //Change the Response/Question that the player can choose
    public void changeQuestion()
    {

        _totalQuestions = _allQuestions.Length;

        if(_currentQuestion < _totalQuestions){
            _catQuestions.text = _allQuestions[_currentQuestion];
        }
        _currentQuestion++;




    }

    public void gameOver()
    {
        _goodResponses = PointTracker.GetComponent<PointTracker>().goodResponses;
        _badResponses = PointTracker.GetComponent<PointTracker>().badResponses;

        if (_goodResponses >= 4)
        {

            _catQuestions.text = _allQuestions[6];
            purr.Play();


        }
        else if(_badResponses >= 4)
        {
            _catQuestions.text = _allQuestions[7];
            hiss.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //purr.clip = purrSound;
        //hiss.clip = hissSound;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
