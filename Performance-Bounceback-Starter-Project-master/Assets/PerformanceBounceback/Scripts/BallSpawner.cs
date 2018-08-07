using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    ObjectPooler objectPooler;

    private float cooldown;
    private float cooldownLength = 0.5f;

    void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }

    void FixedUpdate()
    {
        cooldown -= Time.deltaTime;
        if (cooldown <= 0)
        {
            cooldown = cooldownLength;
            SpawnBall();
        }
    }

    void SpawnBall()
    {
        GameObject selectedBall = objectPooler.SpawnFromPool("Ball", transform.position, Quaternion.identity);
        selectedBall.transform.position = transform.position;
        Rigidbody selectedRigidbody = selectedBall.GetComponent<Rigidbody>();
        selectedRigidbody.velocity = Vector3.zero;
        selectedRigidbody.angularVelocity = Vector3.zero;
        selectedBall.SetActive(true);
    }
}
