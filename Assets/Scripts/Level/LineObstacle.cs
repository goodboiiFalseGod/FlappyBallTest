using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineObstacle : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private BoxCollider2D _boxCollider2D;

    private GameDifficultySettings _difficulty;
    private WorldBorders _borders;

    public void Init(WorldBorders borders, GameDifficultySettings difficulty)
    {
        _borders = borders;
        _difficulty = difficulty;
        FitColliderWithSize(_borders);
    }

    private void Update()
    {
        transform.Translate(Vector2.left * _difficulty.GameSpeed * Time.deltaTime);
       
        if (transform.position.x > _borders.minX * 2f) return;

        transform.position = new Vector2(_borders.maxX * 2f, transform.position.y);
    }

    private void FitColliderWithSize(WorldBorders borders)
    {
        float lineLenght = (borders.maxX - borders.minX);
        Vector3 lineSize = new Vector3(lineLenght, transform.localScale.y,
            transform.localScale.z);

        _spriteRenderer.size = lineSize;
        _boxCollider2D.size = lineSize;
    }
}
