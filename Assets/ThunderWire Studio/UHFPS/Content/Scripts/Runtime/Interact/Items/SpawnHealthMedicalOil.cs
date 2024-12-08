using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHealthMedicalOil : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 respawnPosition;
    public float respawnDelay = 10f;
    private bool isRespawning = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
        prefab.transform.position = respawnPosition;
        prefab.SetActive(true);
        isRespawning = false;
    }
}
