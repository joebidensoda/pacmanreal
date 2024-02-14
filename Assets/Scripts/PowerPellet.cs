using UnityEngine;

public class PowerPellet : Pellet
{
    public float duration = 8.0f;

    protected virtual void Eat()
    {
        FindObjectOfType<GameManager>().PowerPelletEaten(this);
    }
}
