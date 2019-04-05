using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Brandon Ruigrok
public class SoulCollection : MonoBehaviour
{
    public int AmountOfSouls = 0;
    int MaxAmountOfSouls = 10;
    public bool Converted = true;

    public string Color = "Blue";

    private void OnTriggerEnter(Collider col)
    {
        //Handles the souls with the right color combination
        if (col.gameObject.tag == "Blue Soul" && Color == "Blue" || col.gameObject.tag == "Red Soul" && Color == "Red" || col.gameObject.tag == "Yellow Soul" && Color == "Yellow")
        {
            AmountOfSouls++;
            Converted = false;
        }

        //Handles the souls with the wrong color combination
        else if (col.gameObject.tag == "Blue Soul" && Color != "Blue" || col.gameObject.tag == "Red Soul" && Color != "Red" || col.gameObject.tag == "Yellow Soul" && Color != "Yellow")
        {
            AmountOfSouls = 0;
            Converted = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //All the statements for the color switching
        if (Input.GetKeyDown(KeyCode.F) && Color != "Blue")
        {
            Color = "Blue";
            Debug.Log(Color);
        }

        else if (Input.GetKeyDown(KeyCode.G) && Color != "Red")
        {
            Color = "Red";
            Debug.Log(Color);
        }

        else if (Input.GetKeyDown(KeyCode.H) && Color != "Yellow")
        {
            Color = "Yellow";
            Debug.Log(Color);
        }
        
        //Makes sure that the collected souls cap out at 10
        if (AmountOfSouls > MaxAmountOfSouls)
        {
            AmountOfSouls = MaxAmountOfSouls;
        }
    }
}
