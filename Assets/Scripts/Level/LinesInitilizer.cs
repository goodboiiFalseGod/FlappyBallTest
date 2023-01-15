using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinesInitilizer : MonoBehaviour
{
    [SerializeField] private LineObstacle _lineObstaclePrefab;

    public void Init(WorldBorders borders, GameSettings difficulty)
    {
        List<Vector2> _linesPositions = new List<Vector2>();
        
        _linesPositions.Add(new Vector2(borders.maxX, borders.maxY - _lineObstaclePrefab.transform.localScale.y / 2));
        _linesPositions.Add(new Vector2(borders.maxX, borders.minY + _lineObstaclePrefab.transform.localScale.y / 2));
        _linesPositions.Add(new Vector2(borders.minX, borders.maxY - _lineObstaclePrefab.transform.localScale.y / 2));
        _linesPositions.Add(new Vector2(borders.minX, borders.minY + _lineObstaclePrefab.transform.localScale.y / 2));

        foreach (var position in _linesPositions)
        {
            LineObstacle line = Instantiate(_lineObstaclePrefab, position, new Quaternion());
            line.Init(borders, difficulty.GetCurrentDifficulty());
        }
    }
}
