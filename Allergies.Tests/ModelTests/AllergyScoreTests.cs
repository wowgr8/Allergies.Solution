using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies;

namespace Allergies.TestTools
{
  [TestClass]
  public class AllergyScoreTests
  {
    [TestMethod]
    public void AllergiesFound_Score1_eggs()
    {
      AllergyScore score = new AllergyScore();
      string[] foods = {"eggs"};
      Assert.AreEqual("eggs",score.AllergiesFound(1)[0]);
    }
    [TestMethod]
    public void AllergiesFound_Score2_peanuts()
    {
      AllergyScore score = new AllergyScore();
      string [] foods = {"peanuts"};
      Assert.AreEqual("peanuts", score.AllergiesFound(1)[1]);
    }
  }
}