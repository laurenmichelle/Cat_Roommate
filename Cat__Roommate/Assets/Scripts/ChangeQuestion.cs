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

    //Change the Response/Question that the player can choose
    public void changeQuestion()
    {

        _totalQuestions = _allQuestions.Length;

        if(_currentQuestion < _totalQuestions){
            _catQuestions.text = _allQuestions[_currentQuestion];
        }
        _currentQuestion++;




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
