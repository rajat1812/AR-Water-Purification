using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reservoir : MonoBehaviour
{

   // public ParticleSystem pipelineWater1;
    public ParticleSystem waterFall1;
    public ParticleSystem pipelineWater2;
    public ParticleSystem waterFall2;
    public ParticleSystem pipelineWater3;
    public ParticleSystem waterFall3;
    public ParticleSystem pipelineWater4;
    public ParticleSystem waterFall4;
    public ParticleSystem waterFall5;
    public ParticleSystem pipelineWater51;
    public ParticleSystem pipelineWater52;
    public ParticleSystem pipelineWater53;
    public ParticleSystem clSalt;
    public ParticleSystem waste;
    public ParticleSystem wasteFall;


    //public Material water;
    //public Material water2;
    public Color water;
    public Color startcolor;

    public GameObject coagulation;
    public GameObject sedimenation;
    public GameObject filteration;
    public GameObject disinfection;

    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow3;
    public GameObject arrow4;
  
    public GameObject impureText;
    public GameObject tap2;
    public GameObject sludge;
    public GameObject tankWater2;
    public GameObject tankWater3;
    public GameObject tankWater4;
    public GameObject tankWater5;
    public GameObject tank4;
    public GameObject alum1;
    public GameObject alum2;
    public GameObject alum3;
    public GameObject alum;
    public GameObject startPurify;
    public GameObject startArrow;

    public bool pip2 = false;
    public bool pip3 = false;
    public bool pip4 = false;
    public bool pip5 = false;
  

    public bool salt = false;
    public bool waterset = false;
    public bool tap2mvmnt = false;
    public bool waterfall22 = false;
    public bool waterfall33 = false;
    public bool waterfall44 = false;
    public bool waterfall55 = false;
    public bool saltrxn = true;
    public bool alums1 = true;
    public bool alums2 = true;
    public bool alums3 = true;
    public bool up;
    public int counts = 0;

    public bool coagulations = false;
    public bool sedimenations = false;
    public bool filterations = false;
    public bool disinfections = false;
    public bool impureWater = false;

    public StartPurify script;

    public Vector3 temp;
    public Vector3 temp2;
    public Vector3 temp6;
    public Vector3 temp8;
    public Vector3 temp10;
    public Vector3 temp7;
    public Vector3 temp11;
    public Vector3 temp12;
    public Vector3 temp13;
    public Vector3 temp14;
    public Vector3 temp15;
    public Vector3 temp16;
    public Vector3 temp17;
    public Vector3 temp18;
    public Vector3 temp19;


    public Vector3 temparrow1;
    public Vector3 temparrow2;
    public Vector3 temparrow3;
    public Vector3 temparrow4;
   

    float starttime;
    public Vector3 too = new Vector3(-11.88f,2.41f,0.8f);
    // Start is called before the first frame update
    void Start()
    {






        alum1.gameObject.SetActive(false);
        alum2.gameObject.SetActive(false);
        alum3.gameObject.SetActive(false);



        coagulation.gameObject.SetActive(false);
        sedimenation.gameObject.SetActive(false);
        filteration.gameObject.SetActive(false);
        disinfection.gameObject.SetActive(false);
        impureText.gameObject.SetActive(false);
        


        starttime = 43.5f;

        waterFall1.Stop();
        pipelineWater2.Stop();
        waterFall2.Stop();
        wasteFall.Stop();
        pipelineWater3.Stop();
        waterFall3.Stop();
        pipelineWater4.Stop();
        waterFall4.Stop();
        pipelineWater51.Stop();
        pipelineWater52.Stop();
        pipelineWater53.Stop();
        waterFall5.Stop();
        clSalt.Stop();
        waste.Stop();

        arrow1.gameObject.SetActive(false);
        arrow2.gameObject.SetActive(false);
        arrow3.gameObject.SetActive(false);
        arrow4.gameObject.SetActive(false);
        


        sludge.gameObject.SetActive(false);
        tankWater2.gameObject.SetActive(false);
        tankWater3.gameObject.SetActive(false);
        tankWater4.gameObject.SetActive(false);
        tankWater5.gameObject.SetActive(false);


    


    }

    // Update is called once per frame
    void Update()
    {

       

        if (counts == 0)
        {
            if (script.clicked == true)
            {
                Invoke("pipe2", 1);
                Invoke("Tap2Movemnt", 1);
                Invoke("fall2", 5);
                Invoke("true1", 5f);
                Invoke("pipe3", 13);
                Invoke("fall3", 17.5f);
                Invoke("true3", 18f);
                Invoke("pipe4", 26);
                Invoke("fall4", 30f);
                Invoke("true4", 31f);
                Invoke("waters", 44.5f);
                //Invoke("pipe51", 46.5f);    //57  
                //Invoke("pipe52", 48);    //59.5
                Invoke("pipe53", 47f);    //61.5
                Invoke("fall5", 51);      //63.5
                Invoke("true5", 51);
                Invoke("fall1", 53);
                counts = 1;
            }
        }


        if (script.clicked == false)
        {
            temp = startArrow.transform.localPosition;
            if (up == false)
            {
                temp.y = Mathf.MoveTowards(temp.y, 4.44f, 1 * Time.deltaTime);

                if (temp.y == 4.44f)
                {
                    up = true;
                }
                startArrow.transform.localPosition = temp;
            }

            if (up == true)
            {
                temp.y = Mathf.MoveTowards(temp.y, 4.76f, 1 * Time.deltaTime);

                if (temp.y == 4.76f)
                {
                    up = false;
                }
                startArrow.transform.localPosition = temp;
            }


        }

        if (script.clicked == true)
        {
            script.gameObject.SetActive(false);
            startArrow.gameObject.SetActive(false);
            impureText.gameObject.SetActive(true);

            //// ImpureWater 
            if (impureWater == false)
            {
                temp19 = impureText.transform.localScale;
                if (impureText.gameObject.activeInHierarchy == true)
                {

                    if (temp19.x > 90 && temp19.y > 90 && temp19.z > 90)
                    {
                        temp19.x -= Time.deltaTime * 30f;
                        temp19.y -= Time.deltaTime * 30f;
                        temp19.z -= Time.deltaTime * 30f;
                        impureText.transform.localScale = temp19;

                    }
                    else
                    {
                        impureWater = true;
                    }
                }
            }
            else
            {


                temp19 = impureText.transform.localScale;
                if (impureText.gameObject.activeInHierarchy == true)
                {

                    if (temp19.x < 100 && temp19.y < 100 && temp19.z < 100)
                    {
                        temp19.x += Time.deltaTime * 30f;
                        temp19.y += Time.deltaTime * 30f;
                        temp19.z += Time.deltaTime * 30f;
                        impureText.transform.localScale = temp19;

                    }

                    else
                    {
                        impureWater = false;
                    }
                }
            }


            //if (alums1 == false)
            //{
            //    temp15 = alum1.transform.localPosition;
            //    temp15.y = Mathf.MoveTowards(temp15.y, -10.04f, Time.deltaTime * 1);
            //    alum1.transform.localPosition = temp15;

            //    if (temp15.y == -10.04f)
            //    {
            //        alum1.gameObject.SetActive(false);
            //    }
            //}

            //if (alums2 == false)
            //{
            //    temp16 = alum2.transform.localPosition;
            //    temp16.y = Mathf.MoveTowards(temp16.y, -8.04f, Time.deltaTime * 1);
            //    alum2.transform.localPosition = temp16;

            //    if (temp16.y == -8.04f)
            //    {
            //        alum2.gameObject.SetActive(false);
            //    }
            //}

            //if (alums3 == false)
            //{
            //    temp17 = alum3.transform.localPosition;
            //    temp17.y = Mathf.MoveTowards(temp17.y, -6.04f, Time.deltaTime * 1);
            //    alum3.transform.localPosition = temp17;

            //    if (temp17.y == -6.04f)
            //    {
            //        alum3.gameObject.SetActive(false);
            //    }
            //}


            // COAGULATION 
            if (coagulations == false)
            {
                temp11 = coagulation.transform.localScale;
                if (coagulation.gameObject.activeInHierarchy == true)
                {

                    if (temp11.x > 5500 && temp11.y > 5500 && temp11.z > 5500)
                    {
                        temp11.x -= Time.deltaTime * 500f;
                        temp11.y -= Time.deltaTime * 500f;
                        temp11.z -= Time.deltaTime * 500f;
                        coagulation.transform.localScale = temp11;

                    }
                    else
                    {
                        coagulations = true;
                    }
                }
            }
            else
            {


                temp11 = coagulation.transform.localScale;
                if (coagulation.gameObject.activeInHierarchy == true)
                {

                    if (temp11.x < 6000 && temp11.y < 6000 && temp11.z < 6000)
                    {
                        temp11.x += Time.deltaTime * 500f;
                        temp11.y += Time.deltaTime * 500f;
                        temp11.z += Time.deltaTime * 500f;
                        coagulation.transform.localScale = temp11;

                    }

                    else
                    {
                        coagulations = false;
                    }
                }
            }


            // SEDIMENATION

            if (sedimenations == false)
            {
                temp12 = sedimenation.transform.localScale;
                if (sedimenation.gameObject.activeInHierarchy == true)
                {

                    if (temp12.x > 5500 && temp12.y > 5500 && temp12.z > 5500)
                    {
                        temp12.x -= Time.deltaTime * 500f;
                        temp12.y -= Time.deltaTime * 500f;
                        temp12.z -= Time.deltaTime * 500f;
                        sedimenation.transform.localScale = temp12;

                    }
                    else
                    {
                        sedimenations = true;
                    }
                }
            }
            else
            {


                temp12 = sedimenation.transform.localScale;
                if (sedimenation.gameObject.activeInHierarchy == true)
                {

                    if (temp12.x < 6000 && temp12.y < 6000 && temp12.z < 6000)
                    {
                        temp12.x += Time.deltaTime * 500f;
                        temp12.y += Time.deltaTime * 500f;
                        temp12.z += Time.deltaTime * 500f;
                        sedimenation.transform.localScale = temp12;

                    }

                    else
                    {
                        sedimenations = false;

                    }
                }
            }



            // FILTRATION


            if (filterations == false)
            {
                temp13 = coagulation.transform.localScale;
                if (filteration.gameObject.activeInHierarchy == true)
                {

                    if (temp13.x > 5500 && temp13.y > 5500 && temp13.z > 5500)
                    {
                        temp13.x -= Time.deltaTime * 500f;
                        temp13.y -= Time.deltaTime * 500f;
                        temp13.z -= Time.deltaTime * 500f;
                        filteration.transform.localScale = temp13;

                    }
                    else
                    {
                        filterations = true;
                    }
                }
            }
            else
            {


                temp13 = filteration.transform.localScale;
                if (filteration.gameObject.activeInHierarchy == true)
                {

                    if (temp13.x < 6000 && temp13.y < 6000 && temp13.z < 6000)
                    {
                        temp13.x += Time.deltaTime * 500f;
                        temp13.y += Time.deltaTime * 500f;
                        temp13.z += Time.deltaTime * 500f;
                        filteration.transform.localScale = temp13;

                    }

                    else
                    {
                        filterations = false;
                    }
                }
            }




            // DISINFECTION

            if (disinfections == false)
            {
                temp14 = disinfection.transform.localScale;
                if (disinfection.gameObject.activeInHierarchy == true)
                {

                    if (temp14.x > 5500 && temp14.y > 5500 && temp14.z > 5500)
                    {
                        temp14.x -= Time.deltaTime * 500f;
                        temp14.y -= Time.deltaTime * 500f;
                        temp14.z -= Time.deltaTime * 500f;
                        disinfection.transform.localScale = temp14;

                    }
                    else
                    {
                        disinfections = true;
                    }
                }
            }
            else
            {


                temp14 = disinfection.transform.localScale;
                if (disinfection.gameObject.activeInHierarchy == true)
                {

                    if (temp14.x < 6000 && temp14.y < 6000 && temp14.z < 6000)
                    {
                        temp14.x += Time.deltaTime * 500f;
                        temp14.y += Time.deltaTime * 500f;
                        temp14.z += Time.deltaTime * 500f;
                        disinfection.transform.localScale = temp14;

                    }

                    else
                    {
                        disinfections = false;
                    }
                }
            }



            // TAP 2
            if (tap2mvmnt == true)
            {
                temp7 = tap2.transform.localPosition;
                print(temp7.y);
                temp7.y = Mathf.MoveTowards(temp7.y, 26.22f, Time.deltaTime * 1);
                tap2.transform.localPosition = temp7;
            }

            temp = sludge.transform.localScale;


            temp2 = tankWater2.transform.localScale;
            temp10 = tankWater3.transform.localScale;

            //// ARROW 1
            if (pip2 == true)
            {
                temparrow1 = arrow1.transform.localPosition;

                temparrow1.x = Mathf.MoveTowards(temparrow1.x, -11.88f, 1f * Time.deltaTime);

                if (arrow1.gameObject.activeInHierarchy == false)
                {
                    arrow1.gameObject.SetActive(true);
                }

                if (temparrow1.x == -11.88f)
                {
                    temparrow1.x = -12.95f;
                    arrow1.gameObject.SetActive(false);
                }

                arrow1.transform.localPosition = temparrow1;
            }




            // ARROW 2

            if (pip3 == true)
            {
                temparrow2 = arrow2.transform.localPosition;

                temparrow2.x = Mathf.MoveTowards(temparrow2.x, -8.45f, 1f * Time.deltaTime);

                if (arrow2.gameObject.activeInHierarchy == false)
                {
                    arrow2.gameObject.SetActive(true);
                }

                if (temparrow2.x == -8.45f)
                {
                    temparrow2.x = -9.27f;
                    arrow2.gameObject.SetActive(false);
                }

                arrow2.transform.localPosition = temparrow2;
            }




            // ARROW 3

            if (pip4 == true)
            {
                temparrow3 = arrow3.transform.localPosition;

                temparrow3.x = Mathf.MoveTowards(temparrow3.x, -4.8f, 1f * Time.deltaTime);

                if (arrow3.gameObject.activeInHierarchy == false)
                {
                    arrow3.gameObject.SetActive(true);
                }

                if (temparrow3.x == -4.8f)
                {
                    temparrow3.x = -5.8f;
                    arrow3.gameObject.SetActive(false);
                }

                arrow3.transform.localPosition = temparrow3;
            }





            // ARROW 4

            if (pip5 == true)
            {
                temparrow4 = arrow4.transform.localPosition;

                temparrow4.x = Mathf.MoveTowards(temparrow4.x, 0.08f, 1f * Time.deltaTime);

                if (arrow4.gameObject.activeInHierarchy == false)
                {
                    arrow4.gameObject.SetActive(true);
                }

                if (temparrow4.x == 0.08f)
                {
                    temparrow4.x = -0.93f;
                    arrow4.gameObject.SetActive(false);
                }

                arrow4.transform.localPosition = temparrow4;


            }


       






            if (waterfall22 == true)
            {
                //tankWater2.gameObject.SetActive(true);

                if (tankWater2.transform.localScale.z < 1 && tankWater2.transform.localScale.x < 1)
                {
                    tankWater2.gameObject.SetActive(true);
                    temp2.x += Time.deltaTime;
                    temp2.z += Time.deltaTime;
                    tankWater2.transform.localScale = temp2;


                }


                if (tankWater2.transform.localScale.z >= 1 && tankWater2.transform.localScale.x >= 1)
                {
                    temp18 = alum.transform.localScale;

                 


                        // SLUDGE
                        if (tankWater2.transform.localScale.y < 1)
                        {
                        if (temp18.x >= 0 && temp18.x >= 0 && temp18.x >= 0)
                        {
                            temp18.x -= Time.deltaTime * 1.3f;
                            temp18.y -= Time.deltaTime * 1f;
                            temp18.z -= Time.deltaTime * 1.5f;
                            alum.transform.localScale = temp18;
                        }
                           

                            if (temp2.y < 1.5)
                            {
                                sludge.gameObject.SetActive(true);

                                if (sludge.transform.localScale.y <= 1)
                                {
                                    temp.y += Time.deltaTime * 0.5f;
                                    sludge.transform.localScale = temp;
                                }



                            }
                        temp2.y += Time.deltaTime * 0.5f;
                        tankWater2.transform.localScale = temp2;


                    }


                    //// SLUDGE
                    //if (tankWater2.transform.localScale.y < 1)
                    //{

                    //    temp2.y += Time.deltaTime*0.5f;
                    //    tankWater2.transform.localScale = temp2;


                    //    if (temp2.y < 1.5)
                    //    {
                    //        sludge.gameObject.SetActive(true);

                    //        if (sludge.transform.localScale.y <= 1)
                    //        {
                    //            temp.y += Time.deltaTime;
                    //            sludge.transform.localScale = temp;
                    //        }



                    //    }
                    //}
                    if (tankWater2.transform.localScale.y >= 1)
                    {
                        pip2 = false;
                        waterFall2.Stop();
                        wasteFall.Stop();
                        waste.Stop();
                        arrow1.gameObject.SetActive(false);
                    }


                }


            }




            if (waterfall44 == true)
            {


                if (tankWater4.transform.localScale.z < 1 && tankWater4.transform.localScale.x < 1)
                {
                    tankWater4.gameObject.SetActive(true);
                    temp6.x += Time.deltaTime;
                    temp6.z += Time.deltaTime;
                    tankWater4.transform.localScale = temp6;


                }

                if (tankWater4.transform.localScale.z >= 1 && tankWater4.transform.localScale.x >= 1)
                {

                    if (tankWater4.transform.localScale.y < 2.3)
                    {

                        temp6.y += Time.deltaTime;
                        tankWater4.transform.localScale = temp6;
                    }
                    if (tankWater4.transform.localScale.y >= 2.3)
                    {
                        pip4 = false;
                        waterFall4.Stop();
                        arrow3.gameObject.SetActive(false);
                    }


                }


            }




            if (waterfall33 == true)
            {
                tankWater3.gameObject.SetActive(true);

                if (tankWater3.transform.localScale.z < 1 && tankWater3.transform.localScale.x < 1)
                {
                    temp10.x += Time.deltaTime;
                    temp10.z += Time.deltaTime;
                    tankWater3.transform.localScale = temp10;


                }

                if (tankWater3.transform.localScale.z >= 1 && tankWater3.transform.localScale.x >= 1)
                {

                    if (tankWater3.transform.localScale.y < 1)
                    {

                        temp10.y += Time.deltaTime;
                        tankWater3.transform.localScale = temp10;
                    }
                    if (tankWater3.transform.localScale.y >= 1)
                    {
                        pip3 = false;
                        waterFall3.Stop();
                        arrow2.gameObject.SetActive(false);
                    }

                }



            }


            if (waterfall55 == true)
            {
                tankWater5.gameObject.SetActive(true);


                if (tankWater5.transform.localScale.z < 1 && tankWater5.transform.localScale.x < 1)
                {
                    temp8.x += Time.deltaTime;
                    temp8.z += Time.deltaTime;
                    tankWater5.transform.localScale = temp8;
                    if (saltrxn == true)
                    {
                        clSalt.Play();
                        saltrxn = false;
                    }

                }

                if (tankWater5.transform.localScale.z >= 1 && tankWater5.transform.localScale.x >= 1)
                {



                    if (tankWater5.transform.localScale.y < 1)
                    {


                        temp8.y += Time.deltaTime;
                        tankWater5.transform.localScale = temp8;
                    }
                    if (tankWater5.transform.localScale.y >= 1)
                    {
                        pip5 = false;
                        waterFall5.Stop();
                        arrow4.gameObject.SetActive(false);
                    }


                }


            }


            if (waterset == true)
            {
               // float t = (Time.time - starttime) * 0.2f;
                tank4.GetComponent<Renderer>().material.color = Color.Lerp(tank4.GetComponent<Renderer>().material.color, water, 0.5f* Time.deltaTime);
            }


        }
    }


    void true1()
    {
        waterfall22 = true;
    }

   

    void true3()
    {
        waterfall33 = true;
    }


    void true4()
    {
        waterfall44 = true;
     }


    void true5()
    {
        waterfall55 = true;
    }


    void pipe2()
    {

        pip2 = true;
        pipelineWater2.Play();
        waste.Play();
    }

    void pipe3()
    {
        pip3 = true;
        pipelineWater3.Play();
    }

    void pipe4()
    {
        pip4 = true;
        pipelineWater4.Play();
    }


    void pipe51()
    {
        pip5 = true;
        pipelineWater51.Play();
    }


    void pipe52()
    {

        pipelineWater52.Play();
    }


    void pipe53()
    {

        pipelineWater53.Play();
    }

    void fall1()
    {
        waterFall1.Play();
    }

    void fall2()
    {

        waterFall2.Play();
        wasteFall.Play();
        coagulation.gameObject.SetActive(true);
        alums1 = false;
        alums2 = false;
        alums3 = false;


        alum1.gameObject.SetActive(true);
        alum2.gameObject.SetActive(true);
        alum3.gameObject.SetActive(true);

    }


    void fall3()
    {
        waterFall3.Play();
        sedimenation.gameObject.SetActive(true);
    }

 

    void fall4()
    {
        waterFall4.Play();
        filteration.gameObject.SetActive(true);
    }
   
 
    void fall5()
    {
        waterFall5.Play();
        disinfection.gameObject.SetActive(true);
    }

    void waters()
    {
        waterset = true;
      
    }


    void Tap2Movemnt()
    {
        tap2mvmnt = true;
    }


  
}

