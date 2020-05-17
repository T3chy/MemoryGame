using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullets : MonoBehaviour
{   
        public List<GameObject> Bullets;
        public List<string> forgottens;
    public float delayBetweenFires;
    [SerializeField]
    private int bulletsAmount = 10;
    [SerializeField]
    private float startAngle = 90f, endAngle = 270f;
    private Vector2 bulletMoveDirection;
    private int colorPosition = 0;
    public float speedModifier;
    private GameObject currentColor;
    void Start()
    {
        delayBetweenFires = (forgotten.forgottenList.Count / Bullets.Count)* 2f + 1;
        speedModifier = forgotten.forgottenList.Count + 1;
        InvokeRepeating("Fire",0f,delayBetweenFires);
    }
    private void Fire()
    {
        Debug.Log(colorPosition);
        Debug.Log(Bullets[colorPosition].name);
        if(forgotten.forgottenList.Contains(Bullets[colorPosition].name)){
        float angleStep = (endAngle - startAngle) / bulletsAmount;
        float angle = startAngle;
        for (int i = 0; i < bulletsAmount + 1; i++)
        {
            currentColor = Bullets[colorPosition]; 
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);
            Vector3 bulMoveVector = new Vector3(bulDirX,bulDirY,0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;
            // somne
            //Debug.Log(colorDictionary[currentColor.name] + "help");
            Debug.Log(Bullets[colorPosition]);
                GameObject bul = (GameObject)Instantiate(Bullets[colorPosition]);
                bul.transform.position = transform.position;
                bul.transform.rotation = transform.rotation;
                bul.SetActive(true);
                Debug.Log(bul);
                bul.GetComponent<Rigidbody2D>().velocity = bulDir* speedModifier ;
            
            angle += angleStep;

        }
    }
            colorPosition +=1;
            if (colorPosition > Bullets.Count -1 )
            {
                colorPosition = 0;
            }
    }
}
