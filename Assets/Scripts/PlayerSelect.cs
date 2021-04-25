using UnityEngine;
using Cinemachine;
public class PlayerSelect : MonoBehaviour
{
    CinemachineVirtualCamera virtualCamera;
    public GameObject climberOne;
    public GameObject archeologist;
    public GameObject climberTwo;
    private bool climberOneSelected = false;
    private void Awake() 
    {
        virtualCamera = FindObjectOfType<CinemachineVirtualCamera>();
        ToggleClimber();       
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {            
            ToggleClimber();
        }
    }

    private void ToggleClimber() //TODO: Optimize in awake
    {
        if (!climberOneSelected) 
        {   
            climberOne.GetComponent<DistanceJoint2D>().enabled = true;           
            climberOne.GetComponent<PlayerMovement>().enabled = true;
            climberOne.GetComponent<RopeSystem>().SetActive(true);        

            climberTwo.GetComponent<RopeSystem>().ResetRope();
            climberTwo.GetComponent<RopeSystem>().SetActive(false);
            climberTwo.GetComponent<DistanceJoint2D>().enabled = false;
            climberTwo.GetComponent<PlayerMovement>().enabled = false;           
                      
            virtualCamera.LookAt = climberOne.transform;
            virtualCamera.Follow = climberOne.transform;
        }
        else 
        {
            climberOne.GetComponent<RopeSystem>().ResetRope();
            climberOne.GetComponent<DistanceJoint2D>().enabled = false;;           
            climberOne.GetComponent<PlayerMovement>().enabled = false;
            climberOne.GetComponent<RopeSystem>().SetActive(false); 

            climberTwo.GetComponent<DistanceJoint2D>().enabled = true;
            climberTwo.GetComponent<PlayerMovement>().enabled = true;
            climberTwo.GetComponent<RopeSystem>().SetActive(true);
         
            virtualCamera.LookAt = climberTwo.transform;
            virtualCamera.Follow = climberTwo.transform;
        }
        climberOneSelected = !climberOneSelected;
    }
}
