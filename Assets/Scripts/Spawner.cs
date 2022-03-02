using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private float interval;

    private float _time = 0f;
    private float _randTime = 0f;
    private int _randY = 0;

    // Start is called before the first frame update
    private void Start()
    {
        _randTime = Random.Range(2f, interval);
        _randY = Random.Range(-20, 20);
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;

        if (_time >= _randTime)
        {
            _time = 0f;
            _randTime = Random.Range(1f, interval);
            _randY = Random.Range(-20, 20);

            var obj = Instantiate(enemy,new Vector3(80,_randY,0), Quaternion.identity);
        }
    }
}
