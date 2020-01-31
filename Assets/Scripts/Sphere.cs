using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
		{
            Respawn();
		}
    }

    private void OnEnable()
    {
        Respawn();
    }

    private void Respawn()
	{
        float randomY = UnityEngine.Random.Range(6, 10);
        float randomX = UnityEngine.Random.Range(-10, 10);

        transform.position = new Vector3(randomX, randomY);

        // reset the velocity
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.zero;
	}
}
