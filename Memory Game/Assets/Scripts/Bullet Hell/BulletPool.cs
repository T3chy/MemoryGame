using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class BulletPool : MonoBehaviour
// {
//     public List<GameObject> forgottenBullets;
//     public static BulletPool bulletPoolInstance;
//     [SerializeField]
//     public GameObject pooledBullet;
//     private bool notEnoughBulletsInPool = true;

//     private List<GameObject> bullets;
//     private void Awake()
//     {
//         bulletPoolInstance = this;
//     }
//     public BulletPool (int bulletIndex)
//     {

//     }
//     void Start()
//     {
//         bullets = new List<GameObject>();
//     }
//     public GameObject GetBullet(GameObject bullet) 
//     {
//         Debug.Log(bullet);
//         if (bullets.Count > 0)
//         {
//             for (int i = 0; i < bullets.Count; i++)
//             {
//                 if (!bullets[i].activeInHierarchy)
//                 {
//                     Debug.Log(bullets[i]);
//                     return bullets[i];
//                 }
//             }
//         }
//         if (notEnoughBulletsInPool)
//         {
//             GameObject bul = (GameObject)Instantiate(bullet);
//             bul.SetActive(false);
//             bullets.Add(bul);
//             return bul;
//         }
//         return null;
//     }

// // }
// public class BulletPool : MonoBehaviour {
//     public static BulletPool bulletPoolInstance;
//     private void Awake ()
//     {
//         bulletPoolInstance = this;
//     }
//     public GameObject GetBullet (GameObject bullet)
//     {
//         GameObject bul = (GameObject)Instantiate(bullet);
//         return bul;
//     }
// }