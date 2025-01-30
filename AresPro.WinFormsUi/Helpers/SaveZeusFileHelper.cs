using AresPro.WinFormsUi.Enums;
using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Models.Gimmick;

namespace AresPro.WinFormsUi.Helpers;

public static class SaveZeusFileHelper
{
    public static void SaveFederation(FederationModel federation, StreamWriter writer)
    {
        /*
            [STRING:Federation.Name]
            [STRING:Fed.Owner]
            [STRING:Fed.Website]
            [STRING:Fed.FontColor]
            [STRING:Fed.BackgroundColor]
            [INT:Fed.WrestlerCount] [INT:Fed.TeamCount] [INT:Fed.TitleCount] [INT:Fed.CommentatorCount] [INT:Fed.RefereeCount] [BOOL(0/1):Fed.MovesInBlockFormat] [BOOL(0/1):Fed.IncludeCommentary] [INT:Fed.StatMax] [BOOL(0/1):Fed.IncludeMatchHeadings] [BOOL(0/1):Fed.ShowOnlyEndings]
            [LIST(DELIM=NewLine):WRESTLER:Fed.Wrestlers]
            [LIST(DELIM=NewLine):TEAM:Fed.Teams]
            [LIST(DELIM=NewLine):TITLE:Fed.Titles]
            [LIST(DELIM=NewLine):COMMENTATOR:Fed.Commentators]
            [LIST(DELIM=NewLine):REFEREE:Fed.Referees]
         */

        writer.WriteLine(federation.Name);
        writer.WriteLine(federation.Owner);
        writer.WriteLine(federation.Website);
        writer.WriteLine(federation.FontColor);
        writer.WriteLine(federation.BackgroundColor);

        writer.WriteLine(
            string.Join(
                ' ',
                [
                    federation.Wrestlers.Count.ToString(),
                    federation.Teams.Count.ToString(),
                    federation.Titles.Count.ToString(),
                    federation.Commentators.Count.ToString(),
                    federation.Referees.Count.ToString(),
                    (federation.MovesInBlockFormat) ? "1" : "0",
                    (federation.IncludeCommentary) ? "1" : "0",
                    federation.StatMax.ToString(),
                    (federation.IncludeMatchHeading) ? "1" : "0",
                    (federation.ShowOnlyEndings) ? "1" : "0"
                ]
            )
        );

        foreach (WrestlerModel wrestler in federation.Wrestlers.Values)
            SaveWrestler(wrestler, writer);

        foreach (TeamModel team in federation.Teams.Values)
            SaveTeam(team, writer);

        foreach (TitleModel title in federation.Titles.Values)
            SaveTitle(title, writer);

        foreach (CommentatorModel commentator in federation.Commentators.Values)
            SaveCommentator(commentator, writer);

        foreach (RefereeModel referee in federation.Referees.Values)
            SaveReferee(referee, writer);
    }

    public static void SaveWrestler(WrestlerModel wrestler, StreamWriter writer)
    {
        /*
            [LIST(DELIM=;):STRING::Wrestler.Names]|[STRING:Wrestler.Hometown]|[STRING:Wrestler.Stable]|[STRING:Wrestler.RingIntro]|[STRING:Wrestler.EscortName]
            [BOOL(0/1):Wrestler.EscortInterferes] [INT:Wrestler.Strength] [INT:Wrestler.Speed] [INT:Wrestler.Vitality] [INT:Wrestler.Charisma] [INT:Wrestler.Wins] [INT:Wrestler.Loses] [INT:Wrestler.Affiliation{0=Face,1=Neutral,2=Heel}] [INT:Wrestler.Push]
            [INT:Wrestler.Weight]
            [STRING:Wrestler.Height]
            [INT:Wrestler.MoveCount]
            [LIST(DELIM=NewLine):MOVE:Wrestler.Moves]
            [LIST(DELIM=|,MAX=10,TRAIL=|):STRING:Wrestler.TitleNames]
        */

        writer.WriteLine(
            string.Join(
                '|',
                [
                    string.Join(';', wrestler.Names),
                    wrestler.Hometown,
                    wrestler.Stable,
                    wrestler.RingIntro,
                    wrestler.EscortName
                ]
            )
        );

        writer.WriteLine(
            string.Join(
                ' ',
                [
                    (wrestler.EscortInterferes) ? "1" : "0",
                    wrestler.Strength.ToString(),
                    wrestler.Speed.ToString(),
                    wrestler.Vitality.ToString(),
                    wrestler.Charisma.ToString(),
                    wrestler.Wins.ToString(),
                    wrestler.Loses.ToString(),
                    ((int)wrestler.Affiliation).ToString(),
                    wrestler.Push.ToString()
                ]
            )
        );

        writer.WriteLine(wrestler.Weight.ToString());
        writer.WriteLine(wrestler.Height);

        SaveMoveList(wrestler.Moves.Values, writer);

        writer.WriteLine(string.Join('|', wrestler.TitleNames));
    }

    public static void SaveMoveList(IEnumerable<MoveModel> moves, StreamWriter writer)
    {
        /*
            [INT:MoveList.MoveCount]
            [LIST(DELIM=NewLine):MOVE:MoveList.Moves]
        */

        writer.WriteLine(moves.Count().ToString());

        foreach (MoveModel move in moves)
            SaveMove(move, writer);
    }

    public static void SaveGimmick(GimmickModel gimmick, StreamWriter writer)
    {
        /*
            [STRING:Gimmick.Name]
            [INT:Gimmick.CallMove] [INT:Gimmick.TryPin] [INT:Gimmick.RecStand] [INT:Gimmick.Advantage] [INT:Gimmick.TrySub] [INT:Gimmick.ChangePos] [INT:Gimmick.StayOut] [INT:Gimmick.Weapon] [INT:Gimmick.Random] [INT:Gimmick.DoTag] [INT:Gimmick.CountOut] [INT:Gimmick.Strength]
            [LIST(DELIM=NewLine,COUNT=10):LOCATION:Gimmick.Locations]
            [LIST(DELIM=NewLine,COUNT=10):WEAPON:Gimmick.Weapons]
        */

        writer.WriteLine(gimmick.Name);

        writer.WriteLine(
            string.Join(
                ' ',
                [
                    gimmick.CallMove.ToString(),
                    gimmick.TryPin.ToString(),
                    gimmick.RecStand.ToString(),
                    gimmick.Advantage.ToString(),
                    gimmick.TrySub.ToString(),
                    gimmick.ChangePos.ToString(),
                    gimmick.StayOut.ToString(),
                    gimmick.Weapon.ToString(),
                    gimmick.Random.ToString(),
                    gimmick.DoTag.ToString(),
                    gimmick.CountOut.ToString(),
                    gimmick.Strength.ToString()
                ]
            )
        );

        foreach (LocationModel location in gimmick.Locations.Values)
            SaveLocation(location, writer);

        foreach (WeaponModel weapon in gimmick.Weapons.Values)
            SaveWeapon(weapon, writer);
    }

    private static void SaveMove(MoveModel move, StreamWriter writer)
    {
        /*
            [STRING:Move.Name]
            [STRING:Move.Text1]
            [STRING:Move.Text2]
            [STRING:Move.Text3]
            [BOOL(0/1):Move.AttackerStandingBefore] [BOOL(0/1):Move.AttackerStandingAfter] [BOOL(0/1):Move.RecieverStandingBefore] [BOOL(0/1):Move.RecieverStandingAfter] [BOOL(0/1):Move.Lift] [INT:Move.Damage] [INT:Move.Type] [BOOL(0/1):Move.Illegal] [BOOL(0/1):Move.HighRisk]
        */

        writer.WriteLine(move.Name);
        writer.WriteLine(move.Texts[0]);
        writer.WriteLine(move.Texts[1]);
        writer.WriteLine(move.Texts[2]);

        writer.WriteLine(
            string.Join(
                ' ',
                [
                    (move.AttStandingBefore) ? "1" : "0",
                    (move.AttStandingAfter) ? "1" : "0",
                    (move.RecStandingBefore) ? "1" : "0",
                    (move.RecStandingAfter) ? "1" : "0",
                    (move.IsLift) ? "1" : "0",
                    move.Damage.ToString(),
                    ((int)move.Type).ToString(),
                    (move.IsIllegal) ? "1" : "0",
                    (move.IsHighRisk) ? "1" : "0"
                ]
            )
        );
    }

    private static void SaveTeam(TeamModel team, StreamWriter writer)
    {
        /*
            [STRING:Team.Name]|[STRING:Team.Finisher]|[STRING:Team.Introduction]|[STRING:Team.EscortName]
            [INT:Team.Wins] [INT:Team.Loses] [BOOL(0/1):Team.EscortInterferes]
            [LIST(DELIM=|,MAX=100,TRAIL=|):STRING:Team.MemberNames]
            [LIST(DELIM=|,MAX=10,TRAIL=|):STRING:Team.TitleNames]
        */

        writer.WriteLine(
            string.Join(
                '|',
                [
                    team.Name,
                    team.Finisher,
                    team.Introduction,
                    team.EscortName
                ]
            )
        );

        writer.WriteLine(
            string.Join(
                ' ',
                [
                    team.Wins.ToString(),
                    team.Loses.ToString(),
                    (team.EscortInterferes) ? "1" : "0"
                ]
            )
        );

        writer.WriteLine(string.Join('|', team.MemberNames));

        writer.WriteLine(string.Join('|', team.TitleNames));
    }

    private static void SaveTitle(TitleModel title, StreamWriter writer)
    {
        /*
            [STRING:Title.Name]
            [INT:Title.Type{0=Singles,1=Team}]
        */

        writer.WriteLine(title.Name);
        writer.WriteLine(((int)title.Type).ToString());
    }

    private static void SaveCommentator(CommentatorModel commentator, StreamWriter writer)
    {
        /*
            [STRING:Commentator.Name]
            [INT:Commentator.Affiliation{0=Face,1=Neutral,2=Heel}]
            [STRING:Commentator.FileName]
        */

        writer.WriteLine(commentator.Name);
        writer.WriteLine(((int)commentator.Affiliation).ToString());
        writer.WriteLine(commentator.FileName);
    }

    private static void SaveReferee(RefereeModel referee, StreamWriter writer)
    {
        /*
            [STRING:Referee.Name]
            [INT:Referee.CountSpeed] [INT:Referee.Stringency]
        */

        writer.WriteLine(referee.Name);

        writer.WriteLine(
            string.Join(
                ' ',
                [
                    referee.CountSpeed.ToString(),
                    referee.Stringency.ToString()
                ]
            )
        );
    }

    private static void SaveLocation(LocationModel location, StreamWriter writer)
    {
        /*
            [STRING:Location.Name]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc1Text]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc2Text]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc3Text]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc4Text]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc5Text]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc6Text]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc7Text]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc8Text]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc9Text]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc10Text]|[STRING:Location.Floor]|[BOOL(0/1):Location.PinfallsAtLoc] [BOOL(0/1):Location.SubmissionsAtLoc] [BOOL(0/1):Location.AttackerWinsIfHere] [BOOL(0/1):Location.CanfightHere] [BOOL(0/1):Location.CountOutAtLoc] [BOOL(0/1):Location.WeaponsAtLoc] [BOOL(0/1):Location.CanTagHere] [BOOL(0/1):Location.DQAtLoc]
        */

        List<string> locationData = [
            location.Name
        ];

        foreach (TransitionModel transition in location.Transitions)
        {
            locationData.AddRange(
                [
                    "",
                    transition.Texts[0],
                    transition.Texts[1],
                    transition.Texts[2]
                ]
            );
        }

        locationData.Add(location.Floor);

        locationData.Add(
            string.Join(
                ' ',
                [
                    (location.PinfallsAtLoc) ? "1" : "0",
                    (location.SubmissionsAtLoc) ? "1" : "0",
                    (location.AttackerWinsIfHere) ? "1" : "0",
                    (location.CanFightHere) ? "1" : "0",
                    (location.CountOutAtLoc) ? "1" : "0",
                    (location.WeaponsAtLoc) ? "1" : "0",
                    (location.CanTagHere) ? "1" : "0",
                    (location.DQAtLoc) ? "1" : "0"
                ]
            )
        );

        writer.WriteLine(string.Join('|', locationData));
    }

    private static void SaveWeapon(WeaponModel weapon, StreamWriter writer)
    {
        /*
            [STRING:Weapon.Name]|[INT:Weapon.Settings] [STRING:Weapon.IsAt] 0 0 0 0
                --	1024 - SwingAtOpponent
                --	512 - UsedToCutOpponent
                --	256 - ThrownAtOpponent
                --	128 - UsedAsAWhip
                --	64 - UsedToChoke
                --	32 - CausesBleeding
                --	16 - WillBreak
                --	8 - ThrownInto
                --	4 - ShootsAtOpponent
                --	2 - SlammedOn
        */

        List<string> weaponData = [
            weapon.Name
        ];

        int settingsValue = 0;
        if (weapon.SwingAtOpponent)
            settingsValue |= 1024;
        if (weapon.UsedToCutOpponent)
            settingsValue |= 512;
        if (weapon.ThrownAtOpponent)
            settingsValue |= 256;
        if (weapon.UsedAsAWhip)
            settingsValue |= 128;
        if (weapon.UsedToChoke)
            settingsValue |= 64;
        if (weapon.CausesBleeding)
            settingsValue |= 32;
        if (weapon.WillBreak)
            settingsValue |= 16;
        if (weapon.ThrownInto)
            settingsValue |= 8;
        if (weapon.ShootsAtOpponent)
            settingsValue |= 4;
        if (weapon.SlammedOn)
            settingsValue |= 2;

        weaponData.Add(
            string.Join(
                ' ',
                [
                    settingsValue.ToString(),
                    weapon.AvailableAtLocation.ToString(),
                    "0",
                    "0",
                    "0",
                    "0",
                ]
            )
        );

        writer.WriteLine(string.Join('|', weaponData));
    }
}
