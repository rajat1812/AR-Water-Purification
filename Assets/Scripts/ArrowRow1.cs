using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRow1 : MonoBehaviour
{
    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow3;

    public Vector3 temp ;

    // Start is called before the first frame update
    void Start()
    {
        temp = new Vector3(1.267f, -0.2803669f, 0.4886241f);
        arrow1.gameObject.SetActive(false);
        arrow2.gameObject.SetActive(false);
        arrow1.gameObject.SetActive(false);

    }

    // Update is called once per frame
  void Update()
    {

        Invoke("arrows1",1f);
        Invoke("arrows2",3f);
        Invoke("arrows3",5f);
        Invoke("arrows1", 7f);
        Invoke("arrows2", 9f);
        Invoke("arrows3", 11f);
        Invoke("arrows1", 13f);
        Invoke("arrows2", 15f);
        Invoke("arrows3", 17f);

    }

    void arrows1()
    {
       
        arrow1.gameObject.SetActive(true);
        arrow2.gameObject.SetActive(false);
        arrow3.gameObject.SetActive(false);
       


        //if (Vector3.Distance(transform.localPosition,temp) > 0.1f)
        //{
        //    arrow1.transform.localPosition = Vector3.Lerp(arrow1.transform.localPosition, temp, Time.deltaTime * 3.0f);
        //}
        //else
        //{
        //    arrow1.transform.localPosition = temp;
        //}
      

    }

    void arrows2()
    {
        arrow2.gameObject.SetActive(true);
        arrow3.gameObject.SetActive(false);
        arrow1.gameObject.SetActive(false);

    }

    void arrows3()
    {
        arrow3.gameObject.SetActive(true);
        arrow1.gameObject.SetActive(true);
        arrow2.gameObject.SetActive(false);
    }

}
