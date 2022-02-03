using System.Collections.Generic;


namespace Allergies
{
  public class AllergyScore
  {
    private Dictionary<int, string> Allergens = new Dictionary<int, string>() 
    {
      {1,"eggs"}, 
      {2, "peanuts"}, 
      {4, "shellfish"}, 
      {8, "strawberries"}, 
      {16, "tomatoes"}, 
      {32, "chocolate"}, 
      {64, "pollen"}, 
      {128, "cats"}
    };

    public string[] AllergiesFound(int score)
    {

      List<string> allergenList = new List<string> {};
      allergenList.Add(Allergens[1]);

      for (int index = 7; index > -1; index--)
      {
        int tempScore = Allergens.ElementAt(index).Key;
        if (score >= tempScore)
        {
          allergenList.Add(Allergens[tempScore]);
          score -= tempScore;
        }
      }

      string[] allergenArray = allergenList.ToArray();
      return allergenArray;
    }
  }
}