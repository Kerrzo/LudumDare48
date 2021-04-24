using UnityEngine;

[RequireComponent(typeof(DistanceJoint2D))]
public class AttachTo : MonoBehaviour
{   
    public GameObject Target;
    private DistanceJoint2D DistanceJoint2D;
    private void Awake() 
    {
        DistanceJoint2D = this.GetComponent<DistanceJoint2D>();            
    }
        
    void Update()
    {
        if (Target != null)
        {
            DistanceJoint2D.connectedAnchor = new Vector2(
                Target.transform.position.x, 
                Target.transform.position.y);
        }
    }
}
