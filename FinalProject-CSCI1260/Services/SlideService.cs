using FinalProject_CSCI1260.Data;
namespace FinalProject_CSCI1260.Services
{
    public class SlideService : ISlideService
    {
        public Tiles alltiles { get; set; }
        /// <summary>
        /// pulls all the data from the excel sheet and puts it into tiles
        /// </summary>
        public SlideService() 
        {
            alltiles = new Tiles();
            using (StreamReader reader = new StreamReader("Data/CSCI1260077FinalProjectFile.csv"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] tileValues = line.Split(',');
                    Tile tile = new Tile(int.Parse(tileValues[0]), tileValues[1], tileValues[2]);
                    alltiles.AddTile(tile);
                }
            }
        }
    }
}
