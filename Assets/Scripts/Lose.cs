using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
	public GameObject ClimberOne;
	public GameObject ClimberTwo;
    public float loseHeight = -15f;
	
	void Update ()
    {
	    if (transform.position.y <= loseHeight)
	    {
			ClimberOne.GetComponent<RopeSystem>().ResetRope();
			ClimberTwo.GetComponent<RopeSystem>().ResetRope();
	        SceneManager.LoadScene("Game");
	    }
	}
}
