using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private _grid;
    [Range(0, 50)]
    private int numCol = 10;
    [Range(0, 50)]
    private int numLines = 10;

    [SerializeField]
    private GameObject _cellPreFab;
    private void Awake()
    {
        Debug.Log($"[{Time.frameCount}] Awake");

        GenerateGrid();
    }

    private void GenerateGrid()
    {
        _grid = new GameObject[numCol, numLines];

        for(int line = 0; line < numLines; line++)
        {
            for (int col = 0; col < numLines; col++)
            {
                Vector3 pos = new Vector3(col, line, 0);

                GameObject clone = Instantiate(_cellPrefab, pos, Quaternion.identity);
                _grid[col, line] = clone;


            }
        }
    }
}
