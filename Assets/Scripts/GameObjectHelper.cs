using UnityEngine;

public static class GameObjectHelper
{
    public static GameObject GetGameController()
    {
        return GameObject.FindGameObjectWithTag("Game Controller");
    }
    public static GameObject GetScoreController()
    {
        return GameObject.FindGameObjectWithTag("Score Controller");
    }
}
