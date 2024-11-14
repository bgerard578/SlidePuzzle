namespace FinalProject_CSCI1260.Data
{
    public class Tiles
    {
        /// <summary>
        /// A dictionary that holds all the tiles
        /// </summary>
        public Dictionary<string, Tile> tiles { get; set; }
        public Tiles()
        {
            tiles = new Dictionary<string, Tile>();
        }
        /// <summary>
        /// adds a tile to the dictionary
        /// </summary>
        /// <param name="tile">the tile that is added to the dictionary</param>
        public void AddTile(Tile tile)
        {
            tiles.Add((tiles.Count+1).ToString(), tile);
        }
    }
}
