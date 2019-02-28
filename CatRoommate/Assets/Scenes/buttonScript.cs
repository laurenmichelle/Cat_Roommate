using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class buttonScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    public string[] textStuff;

    public void ChangeText()
    {
        int randNum;
        randNum = Random.Range(0, textStuff.Length);
        text.text = textStuff[randNum];
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
