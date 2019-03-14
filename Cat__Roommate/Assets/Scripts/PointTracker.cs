using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTracker : MonoBehaviour
{
    public int goodResponses;
    public int badResponses;
    private int responseNum;
    public GameObject PlayerResponse;
    public GameObject CatRoommate;
    public string endResult;
    public GameObject ChangeQuestion;

    // Start is called before the first frame update
    void Start()
    {
        goodResponses = 0;
        badResponses = 0;
        responseNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void PointUpdate()
    {
        responseNum += 1;
        if (responseNum == 1)
        {

            if (PlayerResponse.GetComponent<PlayerResponse>()._rightResponseChosen == true)
            {
                badResponses += 1;

                Debug.Log("HELLO THERE. RESPONSE NUM IS 1 & badResponse = " + badResponses);

            }
            else if (PlayerResponse.GetComponent<PlayerResponse>()._leftResponseChosen == true)
            {
                goodResponses += 1;

                Debug.Log("HELLO THERE. RESPONSE NUM IS 1 & goodResponse = " + goodResponses);
            }
        }

        else if (responseNum == 2)
        {
            if (PlayerResponse.GetComponent<PlayerResponse>()._rightResponseChosen == true)
            {
                goodResponses += 1;
                Debug.Log("HELLO THERE. RESPONSE NUM IS 2 & goodResponse = " + goodResponses);



            }
            else if (PlayerResponse.GetComponent<PlayerResponse>()._leftResponseChosen == true)
            {
                badResponses += 1;
                Debug.Log("HELLO THERE. RESPONSE NUM IS 2 & badResponse = " + badResponses);


            }

        }

        else if (responseNum == 3)
        {
            if (PlayerResponse.GetComponent<PlayerResponse>()._rightResponseChosen == true)
            {
                goodResponses += 1;
                Debug.Log("HELLO THERE. RESPONSE NUM IS 3 & goodResponse = " + goodResponses);



            }
            else if (PlayerResponse.GetComponent<PlayerResponse>()._leftResponseChosen == true)
            {
                badResponses += 1;
                Debug.Log("HELLO THERE. RESPONSE NUM IS 3 & badResponse = " + badResponses);


            }
        }


        else if (responseNum == 4)
        {
            if (PlayerResponse.GetComponent<PlayerResponse>()._rightResponseChosen == true)
            {
                goodResponses += 1;
                Debug.Log("HELLO THERE. RESPONSE NUM IS 4 & badResponse = " + goodResponses);



            }
            else if (PlayerResponse.GetComponent<PlayerResponse>()._leftResponseChosen == true)
            {
                badResponses += 1;
                Debug.Log("HELLO THERE. RESPONSE NUM IS 4 & goodResponse = " + badResponses);


            }

        }
        else if (responseNum == 5)
        {
            if (PlayerResponse.GetComponent<PlayerResponse>()._rightResponseChosen == true)
            {
                badResponses += 1;
                Debug.Log("HELLO THERE. RESPONSE NUM IS 5 & badResponse = " + badResponses);



            }
            else if (PlayerResponse.GetComponent<PlayerResponse>()._leftResponseChosen == true)
            {
                goodResponses += 1;
                Debug.Log("HELLO THERE. RESPONSE NUM IS 5 & goodResponse = " + goodResponses);


            }
        }

        else if (responseNum == 6)
        {
            if (PlayerResponse.GetComponent<PlayerResponse>()._rightResponseChosen == true)
            {


                badResponses += 1;
                Debug.Log("HELLO THERE. RESPONSE NUM IS 6 & badResponse = " + badResponses);

            }
            else if (PlayerResponse.GetComponent<PlayerResponse>()._leftResponseChosen == true)
            {
               

                goodResponses += 1;
                Debug.Log("HELLO THERE. RESPONSE NUM IS 6 & goodResponse = " + goodResponses);
            }
        }

        else if (responseNum == 7)
        {
            if (PlayerResponse.GetComponent<PlayerResponse>()._rightResponseChosen == true)
            {


                badResponses += 1;
                Debug.Log("HELLO THERE. RESPONSE NUM IS 7 & badResponse = " + badResponses);

            }
            else if (PlayerResponse.GetComponent<PlayerResponse>()._leftResponseChosen == true)
            {


                goodResponses += 1;
                Debug.Log("HELLO THERE. RESPONSE NUM IS 7 & goodResponse = " + goodResponses);
            }
            ChangeQuestion.GetComponent<ChangeQuestion>().gameOver();
        }



        CatRoommate.GetComponent<ChangeCatSprite>().changeSprite();



    }
   
}

