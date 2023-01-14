using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameDifficultySettings _difficulty;
    private WorldBorders _borders;

    public void Init(WorldBorders borders, GameDifficultySettings difficulty)
    {
        _borders = borders;
        _difficulty = difficulty;
    }

    private void Update()
    {
        transform.Translate(Vector2.left * _difficulty.GameSpeed * Time.deltaTime);

        if (transform.position.x > _borders.minX * 2f) return;

        Destroy(gameObject);
    }
}
