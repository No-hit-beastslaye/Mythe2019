using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseOpacity : MonoBehaviour
{
    public bool Visible, Resuming = false;
    Color Transp;

    float OpaqueRate = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        Transp = GetComponent<Renderer>().material.color;
        Transp.a = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Transp.a);
        if(Visible == false)
        {
            Transp.a = Transp.a + OpaqueRate;
            if(Transp.a >= 0.6f)
            {
                Visible = true;
            }
        }

        else if(Resuming == true)
        {
            Transp.a = Transp.a - OpaqueRate;
            if(Transp.a <= 0f)
            {
                Visible = false;
                gameObject.SetActive(false);
            }
        }

        if(Visible == true && Input.GetKeyDown(KeyCode.Escape))
        {
            Resuming = true;
        }
    }
}
