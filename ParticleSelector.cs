//Ben Michael and Tristan Hildahl
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSelector : MonoBehaviour
{
    enum particleType { Sand, Water, Mud} // could just use an int, but this makes things clear
    public static int particleTypeNum;
    public GameObject sandSelector;
    public GameObject waterSelector;
    public GameObject mudSelector;
    GameObject[] selectors;

    void Start()
    {
        selectors = new GameObject[] { sandSelector, waterSelector, mudSelector};
    }

    void ActivateSelector(GameObject activeSelector)//this functions is for expandability purposes and simplifies the below functions
    {
        for(int i = 0; i < selectors.Length; i++)
        {
            GameObject curSelector = selectors[i];
            if (curSelector == activeSelector)
                curSelector.SetActive(true);
            else
                curSelector.SetActive(false);
        }
    }

    public void setSand()//these functions should be consolidated if more particles added in future
    {
        particleTypeNum = (int)particleType.Sand;
        ActivateSelector(sandSelector);
    }

    public void setWater()
    {
        particleTypeNum = (int)particleType.Water;
        ActivateSelector(waterSelector);
    }

    public void setMud()
    {
        particleTypeNum = (int)particleType.Mud;
        ActivateSelector(mudSelector);
    }
}
