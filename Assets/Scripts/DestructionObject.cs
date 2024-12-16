using UnityEngine;

public class DestructionObject : MonoBehaviour
{
    public GameObject destroyedVersion;
    
    private void OnMouse()
    {
       
        Instantiate (destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
