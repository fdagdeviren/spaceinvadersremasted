using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [Header("Enemy prefabı :")]
    [SerializeField] GameObject enemyPrefab;
    [Header("Sütun değeri gir :")]
    [SerializeField] int Columns;
    [Header("Satır değeri gir :")]
    [SerializeField] int Rows;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = -3; i < Columns-3; i++)
        {
            for (int j = 1; j < Rows+1; j++)
            {
                    Instantiate(enemyPrefab, new Vector3(i+1F, j+1.3f, 0), Quaternion.identity);
            }
        }
    }
}
