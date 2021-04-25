using UnityEngine;

[RequireComponent(typeof(DistanceJoint2D))]
public class AttachTo : MonoBehaviour
{    
    public GameObject target;
    private DistanceJoint2D distanceJoint2D;
    private void Awake() 
    {
        distanceJoint2D = this.GetComponent<DistanceJoint2D>();            
    }
        
    void Update()
    {
        if (target != null)
        {
            // DistanceJoint2D.connectedAnchor = new Vector2(
            //     Target.transform.position.x, 
            //     Target.transform.position.y);

            distanceJoint2D.enabled = true;
            distanceJoint2D.autoConfigureDistance = false;
        }
    }
}
