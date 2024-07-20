using Microsoft.AspNetCore.Mvc;
using SHA.ApplicationService.Models;

namespace SHA.ApplicationService.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HeroManagerController : ControllerBase
    {
        [HttpGet(Name = "GetRandomHero")]
        public IActionResult GetRandomHero()
        {
            try
            {
                var heros = GetStoredHerosList();

                var random = new Random();
                var randomIndex = random.Next(0, heros.Count);

                var randomHero = heros[randomIndex];
                
                Thread.Sleep(3000); //TODO: Used to simulate delayed response time for requests from the interface. Remove when going to production.

                return Ok(new
                {
                    Ok = true,
                    Message = "Hero retrieved successfully.",
                    Result = randomHero
                });
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while processing your request."); //TODO: Implement application-level logging.
            }
        }

        [HttpGet(Name = "GetHerosList")]
        public IActionResult GetHerosList()
        {
            try
            {
                var heros = GetStoredHerosList();

                Thread.Sleep(3000); //TODO: Used to simulate delayed response time for requests from the interface. Remove when going to production.

                return Ok(new
                {
                    Ok = true,
                    Message = "Successfully retrieved the list of heros.",
                    Result = heros
                });
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while processing your request."); //TODO: Implement application-level logging
            }
        }

        private List<Hero> GetStoredHerosList()
        {
            var heros = new List<Hero>()
            {
                new Hero
                {
                    ID = new Guid("485412C6-6F6D-4DB3-87A6-F18D7E082AD5"),
                    Name = "Shoei D' GreenWood",
                    History = "Shoei was born in the mountains, where he learned the art of earthbending from ancient masters. Always smiling, her red hair shone in the sunlight. He traveled the world, helping villages and defeating tyrants. With the strength of the land and the wisdom of the monks, Arak became a legend, defending justice and peace in every corner he visited.",
                    Skill = "Whenever Shoei attacks, he can choose to deal 12 points of damage to one enemy, or deal 6 points of damage to up to two different enemies.",
                    Attack = 12,
                    Health = 35
                },
                new Hero
                {
                    ID = new Guid("849CC877-CC26-4BEA-A5A6-7F151DE4251F"),
                    Name = "Elliot Arthurus",
                    History = "Elliot Arthurus, a skilled rogue who abandoned the monarchy in search of his childhood love, Elara, reunites with her after years of separation, discovering that she has become a ruthless commander in an endless war. Determined to end the cycle of conflict plaguing his world, Elliot uses his rogue skills to infiltrate behind the scenes of the war and dismantle the networks of power that perpetuate the conflict. With Elara initially suspicious of her intentions, Elliot shows her not only the horrors of war, but also a vision of a conflict-free future where her childhood love and ideals can finally flourish in peace. As they work together to challenge the status quo and unite rival factions for peace, Elliot and Elara become symbols of hope and change in a war-torn world.",
                    Skill = "Whenever Elliot takes damage from an enemy, he has the ability to partially dodge the attack, dividing the damage in half with any enemy present on the table. This allows Elliot to reduce the impact of enemy attacks by sharing the damage with nearby opponents, demonstrating his agility and ability to dodge at critical moments.",
                    Attack = 10,
                    Health = 30
                },
                new Hero
                {
                    ID = new Guid("3B7DCAE2-6F9D-46F6-9E14-4D136F3713F9"),
                    Name = "Theodora Aura",
                    History = "Theodora Aura was born under the light of a rare celestial event, where the skies shimmered with colors unseen before. From a young age, she displayed a unique affinity for manipulating the energy of the cosmos, harnessing it into powerful bursts of light and energy. Trained by mystical sages in the hidden temples of her homeland, Theodora mastered the art of channeling celestial energies to heal the wounded and shield the innocent from harm. With her shimmering silver hair and eyes that sparkled like stars, she journeyed across realms, offering aid to those in need and confronting dark forces that threatened the balance of the universe.",
                    Skill = "Whenever Theodora Aura uses her celestial powers, she can heal herself for 5 health or release a blast of radiant energy that deals 12 damage to all enemies.",
                    Attack = 8,
                    Health = 26
                }
            };

            return heros;
        }
    }
}