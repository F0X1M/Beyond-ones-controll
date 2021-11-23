using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{
    public Slider slider;
    public int cycle;
    // Start is called before the first frame update
    void Start()
    {
        cycle = 0;
    }

    // Update is called once per frame
    void Update(){
        
    }

    private int NextCycle(){
        cycle++;
        slider.maxValue++;
        return cycle;
    }

    public void GetCycle(){
        slider.value = (float)NextCycle();
    }




}
