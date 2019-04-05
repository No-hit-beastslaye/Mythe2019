using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Brandon Ruigrok
public class Health : MonoBehaviour
{
    int Lives = 3;
    int Counter = 0;
    bool Dead = false;

    SoulCollection Souls;

    //Lives visual
    public GameObject H1;
    public GameObject H2;
    public GameObject H3;

    private void Start()
    {
        Souls = GetComponentInParent<SoulCollection>();
    }

    //Statements for the collider, If you're hit, you get X amount of invincibility frames
    private void OnTriggerEnter(Collider col)
    {
        //If the Player object collides with an object with that "Wrong soul" tag, it takes a life off, and starts the invincibility frames.
        if(col.gameObject.tag == "Blue Soul" && Souls.Color != "Blue" && Counter == 0)
        {
            Lives--;
            Counter = 120;
        }

        else if (col.gameObject.tag == "Red Soul" && Souls.Color != "Red" && Counter == 0)
        {
            Lives--;
            Counter = 120;
        }

        else if (col.gameObject.tag == "Yellow Soul" && Souls.Color != "Yellow" && Counter == 0)
        {
            Lives--;
            Counter = 120;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Where invincibility frames get handled
        if (Counter > 0)
        {
            Counter--;
        }

        //All the visual health statements for the UI
        if (Lives == 3)
        {
            H1.SetActive(true);
            H2.SetActive(true);
            H3.SetActive(true);
        }

        else if (Lives == 2)
        {
            H1.SetActive(true);
            H2.SetActive(true);
            H3.SetActive(false);
        }

        else if (Lives == 1)
        {
            H1.SetActive(true);
            H2.SetActive(false);
            H3.SetActive(false);
        }

        else if (Lives == 0)
        {
            H1.SetActive(false);
            H2.SetActive(false);
            H3.SetActive(false);
            Dead = true;
        }
    }
}
