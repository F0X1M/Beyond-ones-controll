using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public enum Side{
        LEFT,
        RIGHT,
        UP,
        DOWN,
        NONE
    };
    // Start is called before the first frame update
    [SerializeField]
    private GameObject structure_prefab = null;
    [SerializeField]
    private bool isTownHall = false;
    void Start()
    {
        if(isTownHall)
        {
            ConstructNewSites(Side.NONE);
        }
    }

    public void ConstructNewSites(Building.Side pSide){
        GameObject temp = null;
        if(pSide != Building.Side.RIGHT)
        {
        temp = Instantiate(structure_prefab, transform.position + new Vector3(10, 0, 0), new Quaternion(0, 0, 0, 0));
        temp.GetComponent<BuildingSystem>().setSide(Building.Side.LEFT);
        }
        if(pSide != Building.Side.LEFT){
        temp =Instantiate(structure_prefab, transform.position + new Vector3(-10, 0, 0), new Quaternion(0, 0, 0, 0));
        temp.GetComponent<BuildingSystem>().setSide(Building.Side.RIGHT);
        }
        if(pSide != Building.Side.DOWN){
        temp = Instantiate(structure_prefab, transform.position + new Vector3(0, 0, 10), new Quaternion(0, 0, 0, 0));
        temp.GetComponent<BuildingSystem>().setSide(Building.Side.UP);
        }
        if(pSide != Building.Side.UP){
        temp = Instantiate(structure_prefab, transform.position + new Vector3(0, 0, -10), new Quaternion(0, 0, 0, 0));
        temp.GetComponent<BuildingSystem>().setSide(Building.Side.DOWN);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
