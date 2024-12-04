namespace ConsoleApp1
{
    public class Player

        {

             public string Name { get; set; }
             [Skill(nameof(BallControl), 1, 10)]
             public int BallControl { get; set; }
             [Skill(nameof(Dribbling), 1, 20)]
             public int Dribbling { get; set; }
             [Skill(nameof(Power), 1, 1000)]
             public int Power { get; set; }
             [Skill(nameof(Speed), 1, 100)]
             public int Speed { get; set; }
             [Skill(nameof(Passing), 1, 4)]
             public int Passing { get; set; }
        }
}

