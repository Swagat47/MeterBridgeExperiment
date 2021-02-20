using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class experiment : MonoBehaviour
{
    
    public Slider jockeySlider;
    private bool isPressed = true;
    float currentValue;
    public float S;
    // Start is called before the first frame update
    void Start()
    {
     
    }
    public void makeConnectionClick(GameObject objects)
    {

        if (isPressed == true)
        {
            objects.SetActive(true);
            isPressed = false;
        }
        else
        {
            objects.SetActive(false);
            isPressed = true;
        }


    }



    
    // Update is called once per frame
    void Update()
    {
        currentValue = jockeySlider.value;
    }
    public void movement(GameObject jockey)
    {
        
        if (jockeySlider.value < currentValue)
        {
            jockey.transform.Translate(-Vector3.right * 0.2f * jockeySlider.value);
            
            //    jockeySlider.direction = Slider.Direction.LeftToRight;
        }
        else 
        {
            jockey.transform.Translate(Vector3.right * 0.2f * jockeySlider.value);
            
        }

        float p, q;
        p = jockeySlider.value*100;
        q = 100 - p;
        float R = ResistanceBox.ResSum;
        S = (float)R * q / p;
        Debug.Log("P = " + p + " , " + "Q = " + q + " R=" + R + " S = " + S) ;
    }

}

