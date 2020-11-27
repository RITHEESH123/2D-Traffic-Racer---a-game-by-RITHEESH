using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public float min_X = -2.6f, max_X = 2.6f;

    public float delayTimer = 0.5f;
    private float timer;

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Vector3 temp = transform.position;
            temp.x = Random.Range(min_X, max_X);

            int rand = Random.Range(0, enemies.Length);
            Instantiate(enemies[rand], temp, enemies[rand].transform.rotation);

            timer = delayTimer;
        }
    }
}
