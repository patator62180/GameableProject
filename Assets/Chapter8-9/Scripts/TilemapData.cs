using System;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "TilemapData", menuName = "Scriptable Objects/TilemapData")]
public class TilemapData : ScriptableObject
{
    public Tile[] GrassTiles;
    public Tile[] SnowTiles;
    public Tile[] IceTiles;
    public Tile[] DirtTiles;
    public Tile[] WoodTiles;

    public EFloortype GetFloortype(Tile tile)
    {
        if(Array.Exists(SnowTiles, t => t == tile))
        {
            return EFloortype.Snow;
        }

        if (Array.Exists(IceTiles, t => t == tile))
        {
            return EFloortype.Ice;
        }

        if (Array.Exists(DirtTiles, t => t == tile))
        {
            return EFloortype.Dirt;
        }

        if (Array.Exists(WoodTiles, t => t == tile))
        {
            return EFloortype.Wood;
        }

        return EFloortype.Grass;
    }
}
