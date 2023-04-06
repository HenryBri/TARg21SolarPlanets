namespace TARge21SolarPlanets.Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the smallest planet in the Solar System and the closest to the Sun. Its orbit around the Sun takes 87.97 Earth days, the shortest of all the Sun's planets. It is named after the Roman god Mercurius (Mercury), god of commerce, messenger of the gods, and mediator between gods and mortals, corresponding to the Greek god Hermes (Ἑρμῆς). Like Venus, Mercury orbits the Sun within Earth's orbit as an inferior planet; its apparent distance from the Sun as viewed from Earth never exceeds 28°.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://en.wikipedia.org/wiki/Mercury_(planet)#/media/File:Mercury_in_true_color.jpg",
                    "https://en.wikipedia.org/wiki/Mercury_(planet)#/media/File:EW1027346412Gnomap.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
                }
            }
        };


        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizedPlanets = planets.OrderBy(item => random.Next());

            return randomizedPlanets.Take(2).ToList();
        }

        public static List<Planet> GetAllPlanets() 
            => planets;
    }
}
