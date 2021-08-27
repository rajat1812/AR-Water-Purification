using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPurify : MonoBehaviour
{
    public bool clicked;

    // Start is called before the first frame update
    void Start()
    {
        clicked = false;
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnMouseDown()
    {
        clicked = true;
        print(clicked);
    }
}
