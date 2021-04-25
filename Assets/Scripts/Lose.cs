using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Lose : MonoBehaviour
{
	public GameObject climberOne;
	public GameObject climberTwo;
    public float loseHeight = -15f;
	
	void Update ()
    {
	    if (transform.position.y <= loseHeight)
	    {
			//climberOne.GetComponent<RopeSystem>().ResetRope();
			//climberTwo.GetComponent<RopeSystem>().ResetRope();
	        SceneManager.LoadScene("Game");
	    }
	}
}
