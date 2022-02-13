using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BoxCounter : MonoBehaviour
{
    public Text scoreText;                  //text type object
    private int counter;                    //integer type variable 
                                            //represents the score counter

    void Start()
    {
        counter = 0;                        //we initialize the counter to 0
    }

    // Update is called once per frame
    void Update()
    {
       if(counter == 98)                         //When the counter equals 98 we enter the if
        {
            AsyncOperation operation = SceneManager.LoadSceneAsync("Win");  //let's change scene by switching to the one called "Win"

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)          //function to check the collision of one object with another
    {
        if (collision.gameObject.tag == "Block")                    //if the function detects a collision with an object with the "Block" tag, the instructions in the if are executed
        {
            counter = counter + 1;                                  //the score counter is incremented
            scoreText.text = "Score:" + counter;                    //the counter with the text function of the scoreText object is printed on the screen

        }
    }
}
