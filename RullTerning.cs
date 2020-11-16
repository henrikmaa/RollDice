
namespace RullTerning
{
    public class RullTerning : BaseScript
    {

        public RullTerning()
        {
            RegisterCommand("rull", new Action<int, List<object>, string>((source, args, raw) =>
            {
                var numOfDices = "1";
                List<String> results = new List<String>();
                Random rand = new Random();


                if (args.Count > 0)
                {
                    numOfDices = args[0].ToString();
                }

    
             
                for (int i = 1; i < Int16.Parse(numOfDices) + 1; i++)
                {
                  
                    results.Add(rand.Next(1, 7).ToString());
                }

                StringBuilder builder = new StringBuilder();
               
                foreach (string diceResult in results)
                {
                    
                    builder.Append(diceResult).Append(" | ");
                }


                string diceResults = "| " + builder.ToString();

                TriggerEvent("chat:addMessage", new
                {
                    color = new[] { 255, 0, 0 },
                    args = new[] { "[Terning Rull]", $"{diceResults}" }
                });
            }), false);
        }

    }
}
