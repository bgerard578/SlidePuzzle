namespace FinalProject_CSCI1260.Data
{
    public class Tile
    {
        int tileOrder {  get; set; }
        string tileData {  get; set; }
        string tileColor { get; set; }
        /// <summary>
        /// A tile for the puzzle
        /// </summary>
        /// <param name="tileOrder">the position that the tile is suposed to be in</param>
        /// <param name="tileData">the thing that is displayed in the tile</param>
        /// <param name="tileColor">the background color of the tile</param>
        public Tile(int tileOrder, string tileData, string tileColor)
        {
            this.tileOrder = tileOrder;
            this.tileData = tileData;
            this.tileColor = tileColor;
        }
        /// <summary>
        /// Makes a tile for the puzzle
        /// </summary>
        /// <param name="tileOrder">The order of the tiles in the puzzle</param>
        /// <param name="tileData">The contence of the tile, either the number/display of the tile or the path to the image on the tile</param>
        /// <param name="tileColor">The background color of the tile, black signifies the blank tile</param>
        public void MakeTile(int tileOrder, string tileData, string tileColor)
        {
            Tile tile = new Tile(tileOrder, tileData, tileColor);
        }
        /// <summary>
        /// Gives the color of the tile
        /// </summary>
        /// <returns>Returns the tile color</returns>
        public string GiveColor()
        {
            return tileColor;
        }
        /// <summary>
        /// Gives the data of the tile
        /// </summary>
        /// <returns> Returns whatever data goes into the tile</returns>
        public string GiveNum()
        {
            return tileData;
        }
        /// <summary>
        /// Gives the order number in the tile
        /// </summary>
        /// <returns>Returns where the tile is suposed to be</returns>
        public int GiveOrder()
        {
            return tileOrder;
        }
    }
}
