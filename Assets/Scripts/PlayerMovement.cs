using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public GameObject Player;
    public Rigidbody Player_RB;
    public Text FuelText;

    protected Vector3 PlayerGroundedPosition;
    protected Vector3 PlayerLastPosition;
    protected int Score;

    private float Fuel;
    private bool onFloor;
    private bool Falling;
    private float MovementUnit = 1f;


    protected void Movemnt()
    {
        //Moves Right
        if (Input.GetKey(KeyCode.D))
        {
            if (Player.transform.position.x >= 61)
            {
                Player.transform.position = PlayerLastPosition;
            }
            else
                Player.transform.position += new Vector3(MovementUnit, 0, 0);
        }

        //Moves Left
        if (Input.GetKey(KeyCode.A))
        {
            if (Player.transform.position.x <= -61)
            {
                Player.transform.position = PlayerLastPosition;
            }
            else
                Player.transform.position += new Vector3(-MovementUnit, 0, 0);

        }

        //Jumps
        if (Input.GetKey(KeyCode.Space))
        {
            if (Player.transform.position.y >= 24.4f && Fuel > 0)
            {
                Player.transform.position = PlayerLastPosition;
            }
            else if (Fuel > 0)
            {
                Player.transform.position += new Vector3(0, MovementUnit * 2, 0);
                onFloor = false;
                if (onFloor == false && Player.transform.position.y > PlayerGroundedPosition.y * 3)
                {
                    Falling = true;
                    Player.transform.position += new Vector3(0, -MovementUnit, 0);
                }
            }
        }

        //Falls
        if (!Input.GetKey(KeyCode.Space))
        {
            if (Player.transform.position.y <= -23.9f)
            {
                Player.transform.position = PlayerLastPosition;
                onFloor = true;
            }
            else
                Player.transform.position += new Vector3(0, -MovementUnit * 1, 0);
            Falling = true;
        }

    }

    // Sets Defaults
    void Start()
    {
        onFloor = false;
        Falling = true;
        Fuel = 100.0f;
    }

    void Update()
    {
        PlayerLastPosition = Player.transform.position;
        Movemnt();
        if (onFloor == true)
        {
            PlayerGroundedPosition = Player.transform.position;
            Falling = false;
        }
        if (onFloor == false)
        {
            Fuel -= 0.1f;
            FuelText.text = "Fuel Is: " + Fuel.ToString();
        }
    }
}
