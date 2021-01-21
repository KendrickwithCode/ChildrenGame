using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public InputField input;
    public Vector3 moveDirection = Vector3.zero;
    public GameObject Player;

    void Awake()
    {

        input = GameObject.Find("InputField").GetComponent<InputField>();
    }

    public void GetInput(string PlayerText)
    {

        Debug.Log("You entered " + PlayerText);
        
        //Controls for left, right, up and down.
        if (input.text == "left")
        {
            Player.transform.Translate(Vector3.left * 20.0f);
            input.text = "";
        }
        if (input.text == "right")
        {
            Player.transform.Translate(Vector3.right * 20.0f);
            input.text = "";
        }
        if (input.text == "up")
        {
            Player.transform.Translate(Vector3.forward * 20.0f);
            input.text = "";
        }
        if (input.text == "down")
        {
            Player.transform.Translate(Vector3.back * 20.0f);
            input.text = "";
        }

    }
}
