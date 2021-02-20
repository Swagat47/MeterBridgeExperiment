using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class ResistanceBox : MonoBehaviour
{

    public GameObject meterBridge;
    public Canvas resbox;
    private GameObject[] pins;
    private GameObject[] resistorpin;
    private string[] resistorPinName = { "resistor_Pin_L1", "resistor_Pin_L5", "resistor_Pin_L10", "resistor_Pin_L50", "resistor_Pin_L100", "resistor_Pin_L500",
                                           "resistor_Pin_R1", "resistor_Pin_R5", "resistor_Pin_R10", "resistor_Pin_R50", "resistor_Pin_R100", "resistor_Pin_R500" };
    private string[] pinName = { "L1", "L5", "L10", "L50", "L100", "L500", "R1", "R5", "R10", "R50", "R100", "R500" };
    public int numberOfPins = 12;
    
    
    public  static float ResSum = 0;
    public  Dictionary<GameObject, GameObject> myDictionary = new Dictionary<GameObject, GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
        resistorpin = new GameObject[numberOfPins];
        pins = new GameObject[numberOfPins];
        
        for (int i=0; i<numberOfPins; i++)
        {
            pins[i] = meterBridge.transform.Find("main menu canvas").Find("resistanceCheckBox").Find(pinName[i]).gameObject;
           
            resistorpin[i] = meterBridge.transform.Find("ResistanceBox").Find(resistorPinName[i]).gameObject;
            myDictionary.Add(pins[i], resistorpin[i]);

        }
        meterBridge.transform.Find("main menu canvas").Find("resistanceCheckBox").gameObject.SetActive(false);
        
    }
    
    public void showstatus()
    {
        GameObject currentTogglePin = EventSystem.current.currentSelectedGameObject;
        string name = currentTogglePin.name;
        float value = float.Parse(name.Substring(1));
        
        if (currentTogglePin.GetComponent<Toggle>().isOn)
        {
            myDictionary[currentTogglePin].SetActive(false);
            //resistancebox.transform.Find("resistor_Pin_" + name).gameObject.SetActive(false);
            ResSum += value;
            Debug.Log(name + "on" + " sum=" + ResSum );
        }
        else
        {
            myDictionary[currentTogglePin].SetActive(true);
            //resistancebox.transform.Find("resistor_Pin_" + name).gameObject.SetActive(true);
            ResSum -= value;
            Debug.Log(name + "off" + " sum=" + ResSum);
        }
       
    }
   
   

  

    // Update is called once per frame
    void Update()
    {
    }

   

}
