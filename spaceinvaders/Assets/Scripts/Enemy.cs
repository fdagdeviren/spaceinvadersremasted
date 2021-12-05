using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    bool special;
    public static bool finish;
    Rigidbody2D m_Rigidbody;
    [Header("Düşman gemisi hızını gir:")]
    [SerializeField] float m_Speed;
    [Header("Düşman gemisi can değeri :")]
    [SerializeField] int can;
    [Header("Patlama animasyonu animator :")]
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        finish = false;
        special = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Bullet")
        {
            if (special == true)
            {
                Patlat();
            }
            else
            {
                Debug.Log(can);
                if (can == 0)
                {
                    Patlat();
                }
                else
                {
                    canAzalt();
                }
            }
        }
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Game Over");
            finish = true;
        }
        }
    public void canAzalt()
    {
          can -= 10;
    }
    public void Patlat()
    {
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        Debug.Log("Bommm!");
        animator.SetBool("Boom", true);
        StartCoroutine(ObjDestroy());
    }
    IEnumerator ObjDestroy()
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(this.gameObject);
    }
    IEnumerator Specialnum()
    {
        special = true;
        yield return new WaitForSeconds(5f);
        special = true;
    }
    // Update is called once per frame
    void Update()
    {
        m_Rigidbody.velocity = transform.up * -m_Speed;
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(Specialnum());
        }
    }
}
