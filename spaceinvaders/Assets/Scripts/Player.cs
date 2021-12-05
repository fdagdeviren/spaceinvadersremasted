using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject finishTMP;
    [Header("Kullanmak istediğin mermi prefabı:")]
    [SerializeField] GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            for (int i = 0; i < 5; i++)
            {
                Instantiate(bullet, new Vector3(this.transform.position.x, -4.0f+i, 0), Quaternion.identity);
            }
        }
        if(Enemy.finish==true)
        {
            finishTMP.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
