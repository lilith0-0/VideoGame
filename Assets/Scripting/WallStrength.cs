using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class WallStrength : MonoBehaviour
{ public HoldRepair HoldRepair;
    public Slider wallStrength;
    public float repairAmount = 20f; 
    public float damage = 15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        DecreaseWallStrength();
        RepairWall();



    }
    void DecreaseWallStrength()
        {
            wallStrength.value -= damage * Time.deltaTime;
        } 
    void RepairWall()
        {
           if (HoldRepair.isHold)
        {
            wallStrength.value += repairAmount * Time.deltaTime;
            if (wallStrength.value == wallStrength.maxValue)
            {
                HoldRepair.isHold = false;
            }
            if (wallStrength.value <= wallStrength.minValue)
            {
                SceneManager.LoadScene("GameLost");
            }
           }
        }

}
