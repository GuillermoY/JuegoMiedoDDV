using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHealth : MonoBehaviour
{
    public GameObject prefab;
    //public Vector3 respawnPosition;
    public float respawnDelay = 10f;

    [SerializeField] private bool isRespawning = false;
    // Update is called once per frame
    void Update()
    {
        if (!prefab.activeSelf && !isRespawning)
        {
            StartCoroutine(RespawnWithDelay(respawnDelay));
        }
    }

    IEnumerator RespawnWithDelay(float delay)
    {
        isRespawning = true;
        yield return new WaitForSeconds(delay);
        prefab.transform.position = transform.position;
        prefab.transform.rotation = transform.rotation;
        prefab.SetActive(true);
        isRespawning = false;
    }
}
