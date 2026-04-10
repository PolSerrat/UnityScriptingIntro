using UnityEngine;

public class Move : MonoBehaviour
{
    private float movementSpeed = 20f;
    public Space space = Space.World;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, movementSpeed) * Time.deltaTime, space);
    }
}
