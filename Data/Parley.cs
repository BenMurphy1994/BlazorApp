using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class Parley
    {
        public List<GolfHole> CourseHoles =>
            new List<GolfHole>
            {
                new GolfHole(1, 4, 358),
                new GolfHole(2, 3, 119),
                new GolfHole(3, 4, 250),
                new GolfHole(4, 5, 547),
                new GolfHole(5, 4, 293),
                new GolfHole(6, 3, 133),
                new GolfHole(7, 4, 355),
                new GolfHole(8, 3, 143),
                new GolfHole(9, 4, 353),
                new GolfHole(10, 4, 382),
                new GolfHole(11, 3, 119),
                new GolfHole(12, 4, 223),
                new GolfHole(13, 5, 493),
                new GolfHole(14, 4, 223),
                new GolfHole(15, 3, 116),
                new GolfHole(16, 4, 313),
                new GolfHole(17, 3, 110),
                new GolfHole(18, 4, 308)
            };
    }
}
