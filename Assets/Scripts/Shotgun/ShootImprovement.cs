using UnityEngine;
using System.Collections;

public class ShootImprovement : MonoBehaviour
{
    public Vector3 currentPosition;
    public Vector3 currentVelocity;

    public GameObject destroyedVersion;

    Vector3 newPosition = Vector3.zero;
    Vector3 newVelocity = Vector3.zero;

    void Awake()
    {
        currentPosition = transform.position;
    }

    void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    void FixedUpdate()
    {
        MoveBullet();
    }

    //Did we hit a target
    void CheckHit()
    {
        Vector3 fireDirection = (newPosition - currentPosition).normalized;
        float fireDistance = Vector3.Distance(newPosition, currentPosition);


        if (Physics.Raycast(currentPosition, fireDirection, out RaycastHit hit, fireDistance))
        {
            if (hit.collider.CompareTag("Target"))
            {
                Debug.Log("Hit target!");
                //Destroy(gameObject);
                //Destroy(hit.collider.gameObject);

                GameObject jarronRoto = Instantiate(destroyedVersion, hit.collider.transform.position, hit.collider.transform.rotation);
                Destroy(hit.collider.gameObject);
                Destroy(gameObject);
                Destroy(jarronRoto, 1f);
                


            }
        }
    }

    void MoveBullet()
    {
        //Use an integration method to calculate the new position of the bullet
        float h = Time.fixedDeltaTime;
        TutorialBallistics.CurrentIntegrationMethod(h, currentPosition, currentVelocity, out newPosition, out newVelocity);

        //First we need these coordinates to check if we have hit something
        CheckHit();

        currentPosition = newPosition;
        currentVelocity = newVelocity;

        //Add the new position to the bullet
        transform.position = currentPosition;
    }

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
        yield return null;
        
    }
}
