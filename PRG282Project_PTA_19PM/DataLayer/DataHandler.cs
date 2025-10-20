using PRG282Project_PTA_19PM.BusinessProcessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PRG282Project_PTA_19PM.DataLayer;


namespace PRG282Project_PTA_19PM.DataLayer
{
    
        public class FileHandler
        {

            private const string SUPERHERO_FILE = "superheroes.txt";
            private const string SUMMARY_FILE = "summary.txt";

            /// <summary>
            /// Reads all superhero records from the file
            /// </summary>
            public List<Superhero> ReadSuperheroes()
            {
                List<Superhero> heroes = new List<Superhero>();

                try
                {
                    // Create file if it doesn't exist
                    if (!File.Exists(SUPERHERO_FILE))
                    {
                        File.Create(SUPERHERO_FILE).Close();
                        return heroes;
                    }

                    // Read all lines from file
                    List<string> lines = File.ReadAllLines(SUPERHERO_FILE).ToList();

                    // Parse each line into a Superhero object
                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            try
                            {
                                Superhero hero = Superhero.FromString(line);
                                heroes.Add(hero);
                            }
                            catch (Exception)
                            {
                                // Skip invalid lines
                                continue;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error reading superhero file: {ex.Message}");
                }

                return heroes;
            }

            /// <summary>
            /// Writes all superhero records to the file
            /// </summary>
            public void WriteSuperheroes(List<Superhero> heroes)
            {
                try
                {
                    List<string> lines = new List<string>();

                    // Convert each superhero to string format
                    foreach (Superhero hero in heroes)
                    {
                        lines.Add(hero.ToString());
                    }

                    // Write all lines to file
                    File.WriteAllLines(SUPERHERO_FILE, lines);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error writing to superhero file: {ex.Message}");
                }
            }

            /// <summary>
            /// Adds a new superhero to the file
            /// </summary>
            public void AddSuperhero(Superhero hero)
            {
                try
                {
                    // Read existing heroes
                    List<Superhero> heroes = ReadSuperheroes();

                    // Check for duplicate ID
                    if (heroes.Any(h => h.HeroID == hero.HeroID))
                    {
                        throw new Exception($"Hero ID {hero.HeroID} already exists!");
                    }

                    // Add new hero
                    heroes.Add(hero);

                    // Write all heroes back to file
                    WriteSuperheroes(heroes);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error adding superhero: {ex.Message}");
                }
            }

            /// <summary>
            /// Updates an existing superhero record
            /// </summary>
            public void UpdateSuperhero(int heroId, Superhero updatedHero)
            {
                try
                {
                    // Read all heroes
                    List<Superhero> heroes = ReadSuperheroes();

                    // Find the hero to update
                    int index = heroes.FindIndex(h => h.HeroID == heroId);

                    if (index == -1)
                    {
                        throw new Exception($"Hero ID {heroId} not found!");
                    }

                    // Update the hero
                    heroes[index] = updatedHero;

                    // Write back to file
                    WriteSuperheroes(heroes);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error updating superhero: {ex.Message}");
                }
            }

            /// <summary>
            /// Deletes a superhero record
            /// </summary>
            public void DeleteSuperhero(int heroId)
            {
                try
                {
                    // Read all heroes
                    List<Superhero> heroes = ReadSuperheroes();

                    // Find and remove the hero
                    Superhero heroToRemove = heroes.FirstOrDefault(h => h.HeroID == heroId);

                    if (heroToRemove == null)
                    {
                        throw new Exception($"Hero ID {heroId} not found!");
                    }

                    heroes.Remove(heroToRemove);

                    // Write back to file
                    WriteSuperheroes(heroes);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error deleting superhero: {ex.Message}");
                }
            }

            /// <summary>
            /// Generates and saves a summary report
            /// </summary>
            public string GenerateSummary()
            {
                try
                {
                    List<Superhero> heroes = ReadSuperheroes();

                    if (heroes.Count == 0)
                    {
                        return "No superheroes in database.";
                    }

                    // Calculate statistics
                    int totalHeroes = heroes.Count;
                    double avgAge = heroes.Average(h => h.Age);
                    double avgScore = heroes.Average(h => h.ExamScore);

                    int sRankCount = heroes.Count(h => h.Rank == "S-Rank");
                    int aRankCount = heroes.Count(h => h.Rank == "A-Rank");
                    int bRankCount = heroes.Count(h => h.Rank == "C-Rank");
                    int cRankCount = heroes.Count(h => h.Rank == "F-Rank");

                    // Build summary text
                    string summary = "===== SUPERHERO SUMMARY REPORT =====\n";
                    summary += $"Generated: {DateTime.Now}\n\n";
                    summary += $"Total Superheroes: {totalHeroes}\n";
                    summary += $"Average Age: {avgAge:F2}\n";
                    summary += $"Average Exam Score: {avgScore:F2}\n\n";
                    summary += "Heroes Per Rank:\n";
                    summary += $"  S-Rank: {sRankCount}\n";
                    summary += $"  A-Rank: {aRankCount}\n";
                    summary += $"  C-Rank: {cRankCount}\n";
                    summary += $"  F-Rank: {fRankCount}\n";
                    summary += "====================================";

                    // Save to file
                    File.WriteAllText(SUMMARY_FILE, summary);

                    return summary;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error generating summary: {ex.Message}");
                }
            }
        }
    }



