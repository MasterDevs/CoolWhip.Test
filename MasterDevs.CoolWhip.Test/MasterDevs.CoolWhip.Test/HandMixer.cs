namespace MasterDevs.CoolWhip.Test
{
    public class HandMixer
    {
        public string Mix(string ingredient1, string ingredient2)
        {
            if (ingredient1 == "cream" && ingredient2 == "sugar")
            {
            return "Cool Whip";
            }

            return "That's not how you make cool whip!";
        }
    }
}