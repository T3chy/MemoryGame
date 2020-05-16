using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialBulletController : MonoBehaviour
{
    [Header("Projectile Settings")]
    public int numberOfProjectiles;
    public float projectileSpeed;
    public GameObject ProjectilePrefab;
    [Header("Private Variables")]
    private Vector3 startPoint;
    private const float radius = 1f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
        startPoint = transform.position;
        SpawnProjectiles(numberOfProjectiles);
    }}
    private void SpawnProjectiles(int _numberOfProjectiles)
    {
        float angleSetp = 360f / _numberOfProjectiles;
        float angle = 0f;
        for (int i=0; i <= _numberOfProjectiles -1; i++)
        {
            float projectileDirXPosition = startPoint.x + Mathf.Sin((angle * Mathf.PI)/180) * radius;
            float projectileDirYPosition = startPoint.y + Mathf.Cos((angle * Mathf.PI)/180) * radius;
            Vector3 projectileVector = new Vector3(projectileDirXPosition,projectileDirYPosition,0);
            Vector3 projectileMoveDirection = (projectileVector - startPoint).normalized * projectileSpeed;
            GameObject tmpObj = Instantiate(ProjectilePrefab,startPoint,Quaternion.identity) as GameObject;
            tmpObj.GetComponent<Rigidbody2D>().velocity = new Vector3(projectileMoveDirection.x,0,projectileMoveDirection.y);
            angle += angleSetp;
            Debug.Log("Shot");
            tmpObj.SetActive(true);
        }

    }
}
//a 