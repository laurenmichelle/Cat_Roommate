using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeQuestion : MonoBehaviour
{
    public TextMeshProUGUI _catQuestions;
    public string[] _allQuestions;
    private int _currentQuestion = 0;
    private int _totalQuestions;
    public GameObject PointTracker;
    private int _goodResponses;
    private int _badResponses;


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

        }
        else if(_badResponses >= 4)
        {
            _catQuestions.text = _allQuestions[7];
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
