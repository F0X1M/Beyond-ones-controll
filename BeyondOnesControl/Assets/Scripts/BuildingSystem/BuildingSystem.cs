using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSystem : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void setSide(Building.Side pSide)
    {
        side = pSide;
    }
    public LayerMask layer;
    public GameObject obcjectToPlace;

    [SerializeField]
    private GameObject building;
    
    // Update is called once per frame
    private Building.Side side = Building.Side.NONE;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layer))
            {
                if(hit.collider.gameObject == gameObject)
                {
                    //Menu
                    GameObject temp = Instantiate(building, transform.position, transform.rotation);
                    temp.GetComponent<Building>().ConstructNewSites(side);
                    Destroy(gameObject);
                    //Debug.Log("This hit at " + hit.point);
                }
              
            }
        }
    }
}
