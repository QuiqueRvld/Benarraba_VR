using UnityEngine;

public class DestructionObject : MonoBehaviour
{
    public GameObject destroyedVersion;
    
    private void OnMouseUp()
    {
       
        Instantiate (destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
