using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    [Header("Mermi hızını gir:")]
    [SerializeField] float m_Speed;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        StartCoroutine(ObjDestroy());
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
    IEnumerator ObjDestroy()
    {
        yield return new WaitForSeconds(3f);
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        m_Rigidbody.velocity = transform.up * m_Speed;
    }
}
