using UnityEngine;
using UnityEngine.InputSystem; 

public class HoldRepair : MonoBehaviour
{ 
    public bool isHold = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        isHold = Input.GetMouseButtonDown(0);
        
    }
}
