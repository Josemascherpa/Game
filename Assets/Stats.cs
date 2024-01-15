
using UnityEngine;

[CreateAssetMenu(fileName = "Stats",menuName = "newStats")]
public class Stats : ScriptableObject
{
    public string nombre;
    public int kills = 0;
    public int loops = 0;
    public int runs = 0;
    public int deaths = 0;
    public int wins = 0;
    public int time = 0;
    public int unlocks = 0;

    public int meltinBR=0;

    public int killsBR=0;
    public int random=0;

}
