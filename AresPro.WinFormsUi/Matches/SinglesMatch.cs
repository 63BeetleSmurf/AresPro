using System.Text;

namespace AresPro.WinFormsUi.Matches;

public class SinglesMatch
{
    private readonly string[] _mTypes = ["Normal", "Submission", "Hardcore", "Cage", "Ladder", "Hell in the Cell"]; // Match types
    private readonly string[] _finishes = ["Random", "Pin", "Submission", "Finisher", "DQ", "Count Out", "Double Count Out", "Double DQ"];

    private readonly Random _random = new();
    private readonly List<string> _match = [];

    private int _refBump;
    private int _escapeFinish;

    public StringBuilder Output = new();
    public List<Wrestler> Winners { get; } = [];
    public List<Wrestler> Losers { get; } = [];

    public void SimMatch(Wrestler w1, Wrestler w2, int type, Wrestler? winner, int finish)
    {
        int w1Score = 0;
        int w2Score = 0;

        Output.AppendLine($"{w1.Name} Vs. {w2.Name}");
        Output.AppendLine(_mTypes[type]);

        Wrestler loser;
        if (winner == w1)
        {
            loser = w2;
            Output.AppendLine("Booking Decission");
            Output.AppendLine($"Winner: {w1.Name}");
            Output.AppendLine("Scheduled Finish: {_finishes[finish]}");
            Output.AppendLine("");
            Match(w1, w2, finish);
        }
        else if (winner == w2) // CHANGE - Added else
        {
            loser = w1;
            Output.AppendLine("Booking Decission");
            Output.AppendLine($"Winner: {w2.Name}");
            Output.AppendLine("Scheduled Finish: {_finishes[finish]}");
            Match(w2, w1, finish);
        }
        else // CHANGE - winner is nullable so no longer uses "sim"
        {
            while (w1Score == w2Score)
            {
                w1Score = GetScore(w1, w2);
                w2Score = GetScore(w2, w1);
            }

            if (w1Score > w2Score)
            {
                winner = w1;
                loser = w2;
            }
            else
            {
                winner = w2;
                loser = w1;
            }
            Output.AppendLine($"{w1.Name} scored: {w1Score}");
            Output.AppendLine($"{w2.Name} scored: {w2Score}");
            Output.AppendLine($"Winner: {winner.Name}");
            Output.AppendLine($"Scheduled Finish: {_finishes[finish]}");
            Match(winner, loser, finish);
        }
        if (finish < 6)
        {
            Winners.Add(winner);
            Losers.Add(loser);
        }
    }

    private int GetScore(Wrestler w1, Wrestler w2)
    {
        int score = 0;
        if (w1.Str > w2.Str)
            score += 2;
        if (w1.Spe > w2.Spe)
            score++;
        if (w1.Vit > w2.Vit)
            score++;
        if (_random.Next(w1.Cha) > _random.Next(w2.Cha))
            score += 2;

        if (w1.Style == 0 && w2.Style == 2)
            score++;
        else if (w1.Style == 1 && w2.Style == 0) // CHANGE - Added else
            score++;
        else if (w1.Style == 2 && w2.Style == 1) // CHANGE - Added else
            score++;

        return score;
    }

    private bool Ch()
    {
        return (_random.Next(2) == 1);
    }

    // MATCH OPTION FUNCTIONS
    private void Match(Wrestler w1, Wrestler w2, int finish)
    {
        if (finish == 0)
            finish = _random.Next(5) + 1;

        bool running = true; // CHANGE - continue is keyword so changed to running.
        int time = 0;
        while (running)
        {
            running = Wrestling(w1, w2, finish);

            if (_match.Count > 10)
                while (_match.Count > 10)
                    _match.RemoveAt(0);
        }

        int size = _match.Count;
        Output.AppendLine("(Match Joined in progress)");
        for (int x = 0; x < size; x++)
        {
            string line = _match[x];
            Output.AppendLine(line);
        }

        int min = _random.Next(6) + 4;
        int sec = _random.Next(60);

        if (finish == 1)
            Output.AppendLine($"{w2.Name} has been pinned.");
        if (finish == 2)
            Output.AppendLine($"{w2.Name} lost by submission.");
        if (finish == 3)
            Output.AppendLine($"{w2.Name} lost after {w1.Name}'s finisher.");
        if (finish == 4)
            Output.AppendLine($"{w2.Name} has been disqualified.");
        if (finish == 5)
            Output.AppendLine($"{w2.Name} has been counted out.");
        if (finish == 6)
            Output.AppendLine("The Referee calls for the bell and rules the match a double countout.");
        if (finish == 7)
            Output.AppendLine("The Referee calls for the bell and rules the match a double disqualification.");
        Output.AppendLine($"Match Length: {min} minutes and {sec} seconds");
        Output.AppendLine("");
        Output.AppendLine("");
    }

    private bool Wrestling(Wrestler w1, Wrestler w2, int finish)
    {
        _match.Add("...");
        if (Ch() && _refBump == 0) // ref bump
        {
            RefBump(w1, w2);
            _refBump = 1;
            if (Ch()) // w1 cheats
            {
                LeaveRing(w1, w2);
                Ringside(w2, w1);
                ReturnToRing(w2, null);
                string weap1 = Weapon(w1, w2);
                ReturnToRing(w1, weap1);
                UseWeapon(w1, w2, weap1);
                if (Ch() && (finish == 1 || finish == 3)) // w1 cheated to win
                {
                    RefUnbump(w1, w2);
                    if (finish == 1)
                    {
                        Pin(w1, w2);
                        Count(w1, w2, 1, 3);
                    }
                    else
                    {
                        Finisher(w1, w2);
                    }
                    _match.Add($"{w1.Name} used the {weap1} to win but the referee didn't see it.");
                    return false;
                }
                else // w2 comes back
                {
                    Comeback(w2);
                    RefUnbump(w1, w2);
                    return true;
                }
            }
            else // w1 does not cheat
            {
                Pin(w1, w2);
                _match.Add("The referee is down, there is no one to make the count.");
                RefUnbump(w1, w2);
                return true; // CHANGE - Added return to keep fighting
            }
        }
        else // NO ref bump
        {
            if (Ch()) // leave ring
            {
                LeaveRing(w1, w2);
                if (Ch() && finish == 6) //count out
                {
                    Ringside(w1, w2);
                    Count(w1, w2, 3, 6);
                    Ringside(w1, w2);
                    Count(w1, w2, 8, 10);
                    return false;
                }
                else
                {
                    if (Ch()) // w1 gets a weapon
                    {
                        string weap1 = Weapon(w1, w2);
                        if (Ch() && finish == 7) // double DQ
                        {
                            string weap2 = Weapon(w2, w1);
                            UseWeapon(w1, w2, weap1);
                            UseWeapon(w2, w1, weap2);
                            return false;
                        }
                        else // not a double DQ
                        {
                            UseWeapon(w1, w2, weap1);
                            ReturnToRing(w1, null);
                            _match.Add($"{w2.Name} is being counted out.");
                            if (Ch() && finish == 5) // w2 is counted out
                            {
                                Count(w1, w2, 3, 6);
                                _match.Add(".....");
                                Count(w1, w2, 8, 10);
                                return false;
                            }
                            else // w2 makes it back to the ring
                            {
                                Comeback(w2);
                                ReturnToRing(w2, null);
                                return true;
                            }
                        }
                    }
                    else // w1 did not get a weapon
                    {
                        if (Ch()) // w2 grabs a weapon
                        {
                            string weap2 = Weapon(w2, w1);
                            if (Ch() && finish == 4) // W2 is DQd
                            {
                                ReturnToRing(w2, weap2);
                                return false;
                            }
                            else // w2 is not DQd
                            {
                                ReturnToRing(w2, null);
                                return true;
                            }
                        }
                        else // w2 did not grab a weapon
                        {
                            Ringside(w1, w2);
                            Ringside(w2, w1);
                            ReturnToRing(w1, null);
                            ReturnToRing(w2, null);
                            return true;
                        }
                    }
                }
            }
            else // stay in ring
            {
                if (_escapeFinish == 0)
                {
                    if (Ch() && finish == 3) // w1 gets the finisher
                    {
                        Finisher(w1, w2);
                        return false;
                    }
                    else // w2 escapes w1s finisher
                    {
                        if (finish != 3)
                            _escapeFinish = 1;
                        Finisher(w1, w2);
                        EscapeFinisher(w2, w1);
                        return true;
                    }
                }
                else
                {
                    if (Ch() && finish == 1)
                    {
                        Pin(w1, w2);
                        Count(w1, w2, 1, 3);
                        return false;
                    }
                    else if (Ch() && finish == 2)
                    {
                        Submission(w1, w2);
                        _match.Add($"{w2.Name} taps out.");
                        return false;
                    }
                    else
                    {
                        Pin(w1, w2);
                        Count(w1, w2, 1, _random.Next(3));
                        return true;
                    }
                }
            }
        }
    }

    private void RefBump(Wrestler w1, Wrestler w2)
    {
        string[] bumps = [
            "w1 whips w2 into the referee. The referee goes down.",
            "w1 clotheslines w2, w2 ducks. w1 takes out the ref.",
            "w2 misses with a clothesline and takes down the referee.",
            "w1 sends w2 into the corner crushing the referee."
        ];

        int size = bumps.Length;
        string text = bumps[_random.Next(size)];
        text = text.Replace("w1", w1.Name);
        text = text.Replace("w2", w2.Name);
        _match.Add(text);
    }

    private void LeaveRing(Wrestler w1, Wrestler w2)
    {
        string[] texts = [
            "w1 takes w2 out to the floor.",
            "w1 and w2 go to the floor.",
            "w1 leaves the ring and w2 follows.",
            "w2 and w1 fight to the floor."
        ];

        int size = texts.Length;
        string text = texts[_random.Next(size)];
        text = text.Replace("w1", w1.Name);
        text = text.Replace("w2", w2.Name);
        _match.Add(text);
    }

    private void Pin(Wrestler w1, Wrestler w2)
    {
        string[] texts = [
            "w1 makes the cover on w2.",
            "w1 rolls up w2.",
            "w1 hooks the leg of w2 for a cover.",
            "w1 is able to cover w2."
        ];

        int size = texts.Length;
        string text = texts[_random.Next(size)];
        text = text.Replace("w1", w1.Name);
        text = text.Replace("w2", w2.Name);
        _match.Add(text);
    }

    private void Submission(Wrestler w1, Wrestler w2)
    {
        string[] texts = [
            "w1 puts w2 in anklelock submission.",
            "w1 locks a chickenwing on w2.",
            "w1 rolls w2 over into a Boston crab.",
            "w1 has w2 in a figure-four leg lock."
        ];

        int size = texts.Length;
        string text = texts[_random.Next(size)];
        text = text.Replace("w1", w1.Name);
        text = text.Replace("w2", w2.Name);
        _match.Add(text);
    }

    private void Count(Wrestler w1, Wrestler w2, int c1, int c2)
    {
        string[] texts = [
            "The referee counts ",
            "the count "
        ];

        int size = texts.Length;
        string text = texts[_random.Next(size)];
        text = text.Replace("w1", w1.Name);
        text = text.Replace("w2", w2.Name);
        for (int x = c1; x < c2; x++)
            text = $"{text}{x}, ";
        text = $"{text}{c2}";
        _match.Add(text);
    }

    private void RefUnbump(Wrestler w1, Wrestler w2)
    {
        string[] texts = [
            "The referee has regained consisness.",
            "The referee is back to his feet.",
            "The referee recovers from that blow.",
            "The referee sees w1 and w2."
        ];

        int size = texts.Length;
        string text = texts[_random.Next(size)];
        text = text.Replace("w1", w1.Name);
        text = text.Replace("w2", w2.Name);
        _match.Add(text);
    }

    private void Ringside(Wrestler w1, Wrestler w2)
    {
        string[] texts = [
            "w1 sends w2 into the steel steps.",
            "w2 irish whips w1 into the guard railing.",
            "w1 and w2 fight around the ring.",
            "w2 send w1 into the steel ring post."
        ];

        int size = texts.Length;
        string text = texts[_random.Next(size)];
        text = text.Replace("w1", w1.Name);
        text = text.Replace("w2", w2.Name);
        _match.Add(text);
    }

    private string Weapon(Wrestler w1, Wrestler w2)
    {
        string[] weapons = [
            "chair",
            "bell",
            "steel chair",
            "frying pan",
            "monkey wrench"
        ];
        string[] texts = [
            "w1 has gotten ahold of a weap.",
            "w1 grabs a weap.",
            "w1 now has a weap.",
            "w1 has a weap."
        ];
        int size;
        size = weapons.Length;
        string weap = weapons[_random.Next(size)];

        size = texts.Length;
        string text = texts[_random.Next(size)];
        text = text.Replace("w1", w1.Name);
        text = text.Replace("w2", w2.Name);
        text = text.Replace("weap", weap);
        _match.Add(text);
        return weap;
    }

    private void UseWeapon(Wrestler w1, Wrestler w2, string weap)
    {
        string[] texts = [
            "w1 hits w2 with the weap.",
            "w2 was hit by w1 with the weap.",
            "w1 uses that weap.",
            "w2 takes a blow from the weap."
        ];

        int size = texts.Length;
        string text = texts[_random.Next(size)];
        text = text.Replace("w1", w1.Name);
        text = text.Replace("w2", w2.Name);
        text = text.Replace("weap", weap);
        _match.Add(text);
    }

    private void ReturnToRing(Wrestler w1, string? weap = null)
    {
        string[] texts = [
            "w1 climbs back into the ring.",
            "w1 moves back into the ring.",
            "w1 slides into the ring.",
            "w1 returns to the ring."
        ];

        int size = texts.Length;
        string text = texts[_random.Next(size)];
        if (!string.IsNullOrWhiteSpace(weap))
            text = $"w1 takes the {weap} into the ring.";
        text = text.Replace("w1", w1.Name);

        _match.Add(text);
    }

    private void Finisher(Wrestler w1, Wrestler w2)
    {
        string[] kos = [
            "w1 executes the fin on w2.",
            "w2 takes the fin from w1.",
            "w1 delivers the fin to w2!"
        ];
        string[] subs = [
            "w1 locks the fin on w2.",
            "w2 is locked in the fin!!",
            "w1 has w2 in the fin."
        ];


        int size;
        string text;
        if (w1.mType == 0) // ko
        {
            size = kos.Length;
            text = kos[_random.Next(size)];
        }
        else
        {
            size = subs.Length;
            text = subs[_random.Next(size)];
        }

        text = text.Replace("w1", w1.Name);
        text = text.Replace("w2", w2.Name);
        text = text.Replace("fin", w1.Move);
        _match.Add(text);

        if (w1.mType == 0) // ko
        {
            Pin(w1, w2);
            Count(w1, w2, 1, 3);
        }
        else
        {
            _match.Add($"{w2.Name} taps out.");
        }
    }

    private void EscapeFinisher(Wrestler w1, Wrestler w2)
    {
        string[] texts = [
            "NO!! w1 escapes the fin!!!",
            "w1 breaks away before the fin was completed!!"
        ];

        int size = texts.Length;
        string text = texts[_random.Next(size)];

        text = text.Replace("w1", w1.Name);
        text = text.Replace("w2", w2.Name);
        text = text.Replace("fin", w2.Move);
        _match.Add(text);
    }

    private void Comeback(Wrestler w1)
    {
        string[] texts = [
            "w1 has managed to get up.",
            "Somehow w1 is up!",
            "w1 is back to his feet.",
            "w1 is making a comeback after that!"
        ];

        int size = texts.Length;
        string text = texts[_random.Next(size)];
        text = text.Replace("w1", w1.Name);
        _match.Add(text);
    }
}
