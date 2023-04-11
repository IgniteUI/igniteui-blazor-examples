using System;
using System.Collections.Generic;
public class RoadblocksToSuccessItem
{
    public double Index { get; set; }
    public double FirstChoice { get; set; }
    public double TopChoices { get; set; }
    public string FirstChoiceLabel { get; set; }
    public string TopChoicesLabel { get; set; }
    public string Category { get; set; }
}

public class RoadblocksToSuccess
    : List<RoadblocksToSuccessItem>
{
    public RoadblocksToSuccess()
    {
        this.Add(new RoadblocksToSuccessItem()
        {
            Index = 0,
            FirstChoice = 6,
            TopChoices = 22,
            FirstChoiceLabel = @"6%",
            TopChoicesLabel = @"22%",
            Category = @"Poor Prioritization of Tasks"
        });
        this.Add(new RoadblocksToSuccessItem()
        {
            Index = 1,
            FirstChoice = 8,
            TopChoices = 25,
            FirstChoiceLabel = @"8%",
            TopChoicesLabel = @"25%",
            Category = @"Poor Data Literacy"
        });
        this.Add(new RoadblocksToSuccessItem()
        {
            Index = 2,
            FirstChoice = 10,
            TopChoices = 35,
            FirstChoiceLabel = @"10%",
            TopChoicesLabel = @"35%",
            Category = @"Lack of Relevant Skills"
        });
        this.Add(new RoadblocksToSuccessItem()
        {
            Index = 3,
            FirstChoice = 14,
            TopChoices = 37,
            FirstChoiceLabel = @"14%",
            TopChoicesLabel = @"37%",
            Category = @"Lack of Resources"
        });
        this.Add(new RoadblocksToSuccessItem()
        {
            Index = 4,
            FirstChoice = 20,
            TopChoices = 46,
            FirstChoiceLabel = @"20%",
            TopChoicesLabel = @"46%",
            Category = @"Cultural Challenges"
        });
    }
}
