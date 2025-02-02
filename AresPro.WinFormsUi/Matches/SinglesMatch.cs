using System.Text;

using AresPro.WinFormsUi.Enums;
using AresPro.WinFormsUi.Helpers;
using AresPro.WinFormsUi.Models;

namespace AresPro.WinFormsUi.Matches;

public class SinglesMatch(MatchModel match)
{
    // numbers seem to determine how often something will happen, with lower numbers being more often.
    // CallMove     How often commentators comment on the move being done - Tested
    // TryPin       How often a pin is attempted - Tested
    // RECStand     
    // Advantage    How often attacker/receiver switch, 99 creates a long match - Tested
    // TrySub       How often a submission is attempted - Guess
    // StayOut      How often they will stay out for the full count out - Guess
    // Weapon       How often they will use a weapon - Guess
    // Random       General random number or how often random things will happen, like ref bump
    // DoTag        How often a submission is attempted - Guess
    // ChangePos    How often they will change location - Guess

    // CountOut     Number the Ref counts to for a count out.
    // Strength     Seems to change length of match (higher = longer), multiplier on stats? - Guess

    private readonly MatchModel _match = match;

    private readonly string[] _finishes = ["Random", "Pin", "Submission", "Finisher", "DQ", "Count Out", "Double Count Out", "Double DQ"];

    private readonly Random _random = new();
    private readonly List<string> _output = [];

    private int _refBump;
    private int _escapeFinish;

    public StringBuilder Output = new();
    public List<WrestlerModel> Winners { get; } = [];
    public List<WrestlerModel> Losers { get; } = [];

    public void SimMatch(WrestlerModel w1, WrestlerModel w2, int type, WrestlerModel? winner, int finish)
    {
        int w1Score = 0;
        int w2Score = 0;

        Output.AppendLine($"{w1.Name} Vs. {w2.Name}");
        Output.AppendLine(_match.Gimmick.Name);

        WrestlerModel loser;
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

    private int GetScore(WrestlerModel w1, WrestlerModel w2)
    {
        int score = 0;
        if (w1.Strength > w2.Strength)
            score += 2;
        if (w1.Speed > w2.Speed)
            score++;
        if (w1.Vitality > w2.Vitality)
            score++;
        if (_random.Next(w1.Charisma) > _random.Next(w2.Charisma))
            score += 2;

        // Don't have a Style property
        //if (w1.Style == 0 && w2.Style == 2)
        //    score++;
        //else if (w1.Style == 1 && w2.Style == 0) // CHANGE - Added else
        //    score++;
        //else if (w1.Style == 2 && w2.Style == 1) // CHANGE - Added else
        //    score++;

        // Adding more scoring based on tho Zeus Pro Help stating;
        // Push: Affects wrestlers ability to win. Of course a 100 lbs weak guy still won't have a chance against a 400 lbs 10' guy with maxed out stats.
        // Probably need to look at changing Weight and Height to ints or pharsing them someway.
        if (w1.Push > w2.Push)
            score++;
        else
            score--;

        return score;
    }

    private bool Ch(int chance)
    {
        return (_random.Next(chance) == 0);
    }

    // MATCH OPTION FUNCTIONS
    private void Match(WrestlerModel w1, WrestlerModel w2, int finish)
    {
        if (finish == 0)
            finish = _random.Next(5) + 1;

        bool running = true; // CHANGE - continue is keyword so changed to running.
        while (running)
            running = Wrestling(w1, w2, finish);

        foreach (string line in _output)
            Output.AppendLine(line);

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
        Output.AppendLine("");
        Output.AppendLine("");
    }

    private bool Wrestling(WrestlerModel w1, WrestlerModel w2, int finish)
    {
        _output.Add("...");
        if (Ch(_match.Gimmick.Random) && _refBump == 0) // ref bump
        {
            RefBump(w1, w2);
            _refBump = 1;
            if (Ch(_match.Gimmick.Random)) // w1 cheats
            {
                LeaveRing(w1, w2);
                Ringside(w2, w1);
                ReturnToRing(w2, null);
                string weap1 = Weapon(w1, w2);
                ReturnToRing(w1, weap1);
                UseWeapon(w1, w2, weap1);
                if (Ch(_match.Gimmick.Random) && (finish == 1 || finish == 3)) // w1 cheated to win
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
                    _output.Add($"{w1.Name} used the {weap1} to win but the referee didn't see it.");
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
                _output.Add("The referee is down, there is no one to make the count.");
                RefUnbump(w1, w2);
                return true; // CHANGE - Added return to keep fighting
            }
        }
        else // NO ref bump
        {
            if (Ch(_match.Gimmick.ChangePos)) // leave ring
            {
                LeaveRing(w1, w2);
                if (Ch(_match.Gimmick.StayOut) && finish == 6) //count out
                {
                    Ringside(w1, w2);
                    Count(w1, w2, 3, 6);
                    Ringside(w1, w2);
                    Count(w1, w2, 8, 10);
                    return false;
                }
                else
                {
                    if (Ch(_match.Gimmick.Weapon)) // w1 gets a weapon
                    {
                        string weap1 = Weapon(w1, w2);
                        if (Ch(_match.Gimmick.Random) && finish == 7) // double DQ
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
                            _output.Add($"{w2.Name} is being counted out.");
                            if (Ch(_match.Gimmick.StayOut) && finish == 5) // w2 is counted out
                            {
                                Count(w1, w2, 3, 6);
                                _output.Add(".....");
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
                        if (Ch(_match.Gimmick.Weapon)) // w2 grabs a weapon
                        {
                            string weap2 = Weapon(w2, w1);
                            if (Ch(_match.Gimmick.Random) && finish == 4) // W2 is DQd
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
                    if (Ch(_match.Gimmick.Random) && finish == 3) // w1 gets the finisher
                    {
                        Finisher(w1, w2);
                        return false;
                    }
                    else // w2 escapes w1s finisher
                    {
                        if (finish != 3)
                            _escapeFinish = 1;
                        MoveModel finisherMove = Finisher(w1, w2);
                        EscapeFinisher(w2, w1, finisherMove);
                        return true;
                    }
                }
                else
                {
                    if (Ch(_match.Gimmick.TryPin) && finish == 1)
                    {
                        Pin(w1, w2);
                        Count(w1, w2, 1, 3);
                        return false;
                    }
                    else if (Ch(_match.Gimmick.TrySub) && finish == 2)
                    {
                        Submission(w1, w2);
                        _output.Add($"{w2.Name} taps out.");
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

    private void RefBump(WrestlerModel w1, WrestlerModel w2)
    {
        _output.Add(
            GetRandomText(
                [
                    "#ATT# whips #REC# into the referee. The referee goes down.",
                    "#ATT# clotheslines #REC#, #REC# ducks. #ATT# takes out the ref.",
                    "#REC# misses with a clothesline and takes down the referee.",
                    "#ATT# sends #REC# into the corner crushing the referee."
                ],
                new() {
                    { "#ATT#", w1.Name },
                    { "#REC#", w2.Name },
                }
            )
        );
    }

    private void LeaveRing(WrestlerModel w1, WrestlerModel w2)
    {
        _output.Add(
            GetRandomText(
                [
                    "#ATT# takes #REC# out to the floor.",
                    "#ATT# and #REC# go to the floor.",
                    "#ATT# leaves the ring and #REC# follows.",
                    "#REC# and #ATT# fight to the floor."
                ],
                new() {
                    { "#ATT#", w1.Name },
                    { "#REC#", w2.Name },
                }
            )
        );
    }

    private void Pin(WrestlerModel w1, WrestlerModel w2)
    {
        _output.Add(
            GetRandomText(
                [
                    "#ATT# makes the cover on #REC#.",
                    "#ATT# rolls up #REC#.",
                    "#ATT# hooks the leg of #REC# for a cover.",
                    "#ATT# is able to cover #REC#."
                ],
                new() {
                    { "#ATT#", w1.Name },
                    { "#REC#", w2.Name },
                }
            )
        );
    }

    private void Submission(WrestlerModel w1, WrestlerModel w2)
    {
        _output.Add(
            GetRandomText(
                [
                    "#ATT# puts #REC# in anklelock submission.",
                    "#ATT# locks a chickenwing on #REC#.",
                    "#ATT# rolls #REC# over into a Boston crab.",
                    "#ATT# has #REC# in a figure-four leg lock."
                ],
                new() {
                    { "#ATT#", w1.Name },
                    { "#REC#", w2.Name },
                }
            )
        );
    }

    private void Count(WrestlerModel w1, WrestlerModel w2, int c1, int c2)
    {
        string text = GetRandomText(
            [
                "The referee counts",
                "the count"
            ],
            new() {
                { "#ATT#", w1.Name },
                { "#REC#", w2.Name },
            }
        );

        for (int i = c1; i < c2; i++)
            text = $"{text} {i},";
        text = $"{text} {c2}";

        _output.Add(text);
    }

    private void RefUnbump(WrestlerModel w1, WrestlerModel w2)
    {
        _output.Add(
            GetRandomText(
                [
                    "The referee has regained consisness.",
                    "The referee is back to his feet.",
                    "The referee recovers from that blow.",
                    "The referee sees #ATT# and #REC#."
                ],
                new() {
                    { "#ATT#", w1.Name },
                    { "#REC#", w2.Name },
                }
            )
        );
    }

    private void Ringside(WrestlerModel w1, WrestlerModel w2)
    {
        _output.Add(
            GetRandomText(
                [
                    "#ATT# sends #REC# into the steel steps.",
                    "#REC# irish whips #ATT# into the guard railing.",
                    "#ATT# and #REC# fight around the ring.",
                    "#REC# send #ATT# into the steel ring post."
                ],
                new() {
                    { "#ATT#", w1.Name },
                    { "#REC#", w2.Name },
                }
            )
        );
    }

    private string Weapon(WrestlerModel w1, WrestlerModel w2)
    {
        string weap = GetRandomText(
            [
                "chair",
                "bell",
                "steel chair",
                "frying pan",
                "monkey wrench"
            ]
        );

        _output.Add(
            GetRandomText(
                [
                    "#ATT# has gotten ahold of a #WEP#.",
                    "#ATT# grabs a #WEP#.",
                    "#ATT# now has a #WEP#.",
                    "#ATT# has a #WEP#."
                ],
                new() {
                    { "#ATT#", w1.Name },
                    { "#REC#", w2.Name },
                    { "#WEP#", weap }
                }
            )
        );

        return weap;
    }

    private void UseWeapon(WrestlerModel w1, WrestlerModel w2, string weap)
    {
        _output.Add(
            GetRandomText(
                [
                    "#ATT# hits #REC# with the #WEP#.",
                    "#REC# was hit by #ATT# with the #WEP#.",
                    "#ATT# uses that #WEP#.",
                    "#REC# takes a blow from the #WEP#."
                ],
                new() {
                    { "#ATT#", w1.Name },
                    { "#REC#", w2.Name },
                    { "#WEP#", weap }
                }
            )
        );
    }

    private void ReturnToRing(WrestlerModel w1, string? weap = null)
    {
        if (!string.IsNullOrWhiteSpace(weap))
            _output.Add(
                StringHelper.ReplacePlaceholders(
                    "#ATT# takes the #WEP# into the ring.",
                    new() {
                        { "#ATT#", w1.Name },
                        { "#WEP#", weap }
                    }
                )
            );
        else
            _output.Add(
                GetRandomText(
                    [
                        "#ATT# climbs back into the ring.",
                        "#ATT# moves back into the ring.",
                        "#ATT# slides into the ring.",
                        "#ATT# returns to the ring."
                    ],
                    new() {
                        { "#ATT#", w1.Name }
                    }
                )
            );
    }

    private MoveModel Finisher(WrestlerModel w1, WrestlerModel w2)
    {
        MoveModel finisherMove = GetRandomMove(w1, MoveTypes.SubmissionFinisher, MoveTypes.KnockoutFinisher);

        _output.Add(
            GetRandomText(
                finisherMove.Texts,
                new() {
                    { "#ATT#", w1.Name },
                    { "#REC#", w2.Name },
                    { "#MOV#", finisherMove.Name }
                }
            )
        );

        if (finisherMove.Type == MoveTypes.KnockoutFinisher)
        {
            Pin(w1, w2);
            Count(w1, w2, 1, 3);
        }
        else
        {
            _output.Add($"{w2.Name} taps out.");
        }

        return finisherMove;
    }

    private void EscapeFinisher(WrestlerModel w1, WrestlerModel w2, MoveModel finisherMove)
    {
        _output.Add(
            GetRandomText(
                [
                    "NO!! #ATT# escapes the #MOV#!!!",
                    "#ATT# breaks away before the #MOV# was completed!!"
                ],
                new() {
                    { "#ATT#", w1.Name },
                    { "#REC#", w2.Name },
                    { "#MOV#", finisherMove.Name }
                }
            )
        );
    }

    private void Comeback(WrestlerModel w1)
    {
        _output.Add(
            GetRandomText(
                [
                    "#ATT# has managed to get up.",
                    "Somehow #ATT# is up!",
                    "#ATT# is back to his feet.",
                    "#ATT# is making a comeback after that!"
                ],
                new() {
                    { "#ATT#", w1.Name }
                }
            )
        );
    }

    private MoveModel GetRandomMove(WrestlerModel wrestler, params MoveTypes[] moveTypes)
    {
        List<MoveModel> moves = wrestler.Moves.Where(m => moveTypes.Contains(m.Value.Type)).Select(m => m.Value).ToList();
        return moves[moves.Count];
    }

    private string GetRandomText(string[] texts, Dictionary<string, string?>? placeholders = null)
    {
        string text = texts[_random.Next(texts.Length)];
        if (placeholders == null)
            return text;
        else
            return StringHelper.ReplacePlaceholders(text, placeholders);
    }
}
