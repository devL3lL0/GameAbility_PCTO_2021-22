using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallMove : MonoBehaviour
{
    Rigidbody2D rb;              //We declare a RigidBody object for object physics
    public Text lifesText;          //We declare an object of type text
    private int lifes;              //We declare the lifes variable which will be the life counter in the game
    Vector3 movement;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>(); 
        lifes = 5;                                             //We initialize the lifes variable to 5     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))                       //When the game starts, the ball will not move yet
        {                                                      //until the space bar of the keyboard is pressed
            rb.AddForce(Vector3.right * 8);                    //when it is pressed a force is applied to the ball to make it move
            rb.AddForce(Vector3.up * 8);
        }
        lifesText.text = "X " + lifes;                          //with the text function of the lifesText object we can print the number of lives on the screen
    }

    private void OnCollisionEnter2D(Collision2D collision)      //function to detect the collision of one object with another
    {
        if (collision.gameObject.tag == "Down")                 //if the ball touches an object classified with the "Down" tag we enter the if
        {
            lifes--;                                            //we decrease lives
            movement.x = 0;                                     //we move the ball to the center of the screen
            movement.y = 0;
            transform.position = movement;
            if (lifes == 0)                                     //when the life counter is equal to 0 we enter the if
            {
                AsyncOperation operation = SceneManager.LoadSceneAsync("GameOver");             //let's change the scene called GameOver
            }
        }
    }
}
