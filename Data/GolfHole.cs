namespace BlazorApp.Data
{
    public class GolfHole
    {
        public GolfHole(int holeNumber = 0, int par = 0, int yardage = 0)
        {
            HoleNumber = holeNumber;
            Par = par;
            Yardage = yardage;
        }

        public int HoleNumber { get; set; }
        public int Par { get; set; }
        public int Yardage { get; set; }
    }
}
