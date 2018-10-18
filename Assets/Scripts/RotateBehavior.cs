using UnityEngine;

public class RotateBehavior : MonoBehaviour
{
    [Tooltip("Determines the speed of the rotation")]
    public int speed = 100; 
	
	// Update is called once per frame
    public void Update ()
    {
        transform.Rotate(0f, speed * Time.deltaTime, 0f);
	}
}
