using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerLoc;
    public Vector3 displacement = new Vector3(0, 0, -10);

    // Update is called once per frame
    void Update()
    {
        transform.position = playerLoc.position + displacement;
    }
}
