using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ClimberOne;
    public GameObject Archeologist;
    public GameObject ClimberTwo;
    private bool climberOneSelected = false;
    private void Awake() 
    {
        ToggleClimber();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown("tab"))
        {
            print("tab key was pressed");
            ToggleClimber();
        }
    }

    private void ToggleClimber()
    {
        if (!climberOneSelected) 
        {
            ClimberOne.GetComponent<DistanceJoint2D>().enabled = true;           
            ClimberOne.GetComponent<PlayerMovement>().enabled = true;
            ClimberOne.GetComponent<RopeSystem>().enabled = true;        

            ClimberTwo.GetComponent<RopeSystem>().ResetRope();
            ClimberTwo.GetComponent<DistanceJoint2D>().enabled = false;
            ClimberTwo.GetComponent<PlayerMovement>().enabled = false;
            ClimberTwo.GetComponent<RopeSystem>().enabled = false;
            
            this.GetComponent<CameraLerpToTransform>().target = ClimberOne.transform;           
        }
        else
        {
            ClimberOne.GetComponent<RopeSystem>().ResetRope();
            ClimberOne.GetComponent<DistanceJoint2D>().enabled = false;;           
            ClimberOne.GetComponent<PlayerMovement>().enabled = false;
            ClimberOne.GetComponent<RopeSystem>().enabled = false;   

            ClimberTwo.GetComponent<DistanceJoint2D>().enabled = true;
            ClimberTwo.GetComponent<PlayerMovement>().enabled = true;
            ClimberTwo.GetComponent<RopeSystem>().enabled = true;

            this.GetComponent<CameraLerpToTransform>().target = ClimberTwo.transform;            
        }
        climberOneSelected = !climberOneSelected;
    }
}
