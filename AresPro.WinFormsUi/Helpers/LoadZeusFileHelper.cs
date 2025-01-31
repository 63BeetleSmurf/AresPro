using AresPro.WinFormsUi.Enums;
using AresPro.WinFormsUi.Models;
using AresPro.WinFormsUi.Models.Gimmick;

namespace AresPro.WinFormsUi.Helpers;

public static class LoadZeusFileHelper
{
    private static string ReadLine(StreamReader reader)
        => reader.ReadLine() ?? throw new FileFormatException();

    public static FederationModel LoadFederation(StreamReader reader)
    {
        // Used to populate title.holder properties
        Dictionary<string, string> titlesToWrestlersMap = [];
        Dictionary<string, string> titlesToTeamsMap = [];

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

        FederationModel federation = new();

        federation.Name = ReadLine(reader);
        federation.Owner = ReadLine(reader);
        federation.Website = ReadLine(reader);
        federation.FontColor = ReadLine(reader);
        federation.BackgroundColor = ReadLine(reader);

        string[] settingsData = ReadLine(reader).Split(' ');
        int wrestlerCount = int.Parse(settingsData[0]);
        int teamCount = int.Parse(settingsData[1]);
        int titleCount = int.Parse(settingsData[2]);
        int commentatorCount = int.Parse(settingsData[3]);
        int refereeCount = int.Parse(settingsData[4]);
        federation.MovesInBlockFormat = (settingsData[5] == "1");
        federation.IncludeCommentary = (settingsData[6] == "1");
        federation.StatMax = int.Parse(settingsData[7]);
        federation.IncludeMatchHeading = (settingsData[8] == "1");
        federation.ShowOnlyEndings = (settingsData[9] == "1");

        for (int i = 0; i < wrestlerCount; i++)
        {
            WrestlerModel wrestler = LoadWrestler(reader);
            federation.Wrestlers.Add(wrestler.Name, wrestler);

            // Add reference for when titles are loaded
            foreach (string titleName in wrestler.TitleNames)
                titlesToWrestlersMap.Add(titleName, wrestler.Name);
        }

        for (int i = 0; i < teamCount; i++)
        {
            TeamModel team = LoadTeam(reader);
            federation.Teams.Add(team.Name, team);

            // Add team references to wresters
            List<string> phantomMembers = [];
            foreach (string memberName in team.MemberNames)
            {
                if (!federation.Wrestlers.ContainsKey(memberName))
                    phantomMembers.Add(memberName);
                else
                    federation.Wrestlers[memberName].Teams.Add(team.Name);
            }
            // Remove any phantom members that were found
            foreach (string phantomMember in phantomMembers)
                team.MemberNames.Remove(phantomMember);

            // Add reference for when titles are loaded
            foreach (string titleName in team.TitleNames)
                titlesToTeamsMap.Add(titleName, team.Name);
        }

        for (int i = 0; i < titleCount; i++)
        {
            TitleModel title = LoadTitle(reader);
            federation.Titles.Add(title.Name, title);

            // Set holder property based on reference data
            if (title.Type == TitleTypes.Singles && titlesToWrestlersMap.ContainsKey(title.Name))
                title.Holder = titlesToWrestlersMap[title.Name];
            else if (title.Type == TitleTypes.Singles && titlesToWrestlersMap.ContainsKey(title.Name))
                title.Holder = titlesToWrestlersMap[title.Name];
        }
        // Check singles titles referenced when loading wrestlers
        foreach (string titleName in titlesToWrestlersMap.Keys)
            if (!federation.Titles.ContainsKey(titleName))
                federation.Wrestlers[titlesToWrestlersMap[titleName]].TitleNames.Remove(titleName);
        // Check team titles referenced when loading team
        foreach (string titleName in titlesToTeamsMap.Keys)
            if (!federation.Titles.ContainsKey(titleName))
                federation.Teams[titlesToTeamsMap[titleName]].TitleNames.Remove(titleName);

        for (int i = 0; i < commentatorCount; i++)
        {
            CommentatorModel commentator = LoadCommentator(reader);
            federation.Commentators.Add(commentator.Name, commentator);
        }

        for (int i = 0; i < refereeCount; i++)
        {
            RefereeModel referee = LoadReferee(reader);
            federation.Referees.Add(referee.Name, referee);
        }

        return federation;
    }

    public static WrestlerModel LoadWrestler(StreamReader reader)
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

        WrestlerModel wrestler = new();

        string[] wrestlerStringsData = ReadLine(reader).Split('|');
        wrestler.Names = wrestlerStringsData[0].Split(';');
        wrestler.Hometown = wrestlerStringsData[1];
        wrestler.Stable = wrestlerStringsData[2];
        wrestler.RingIntro = wrestlerStringsData[3];
        wrestler.EscortName = wrestlerStringsData[4];

        string[] wrestlerSettingsData = ReadLine(reader).Split(' ');
        wrestler.EscortInterferes = (wrestlerSettingsData[0] == "1");
        wrestler.Strength = int.Parse(wrestlerSettingsData[1]);
        wrestler.Speed = int.Parse(wrestlerSettingsData[2]);
        wrestler.Vitality = int.Parse(wrestlerSettingsData[3]);
        wrestler.Charisma = int.Parse(wrestlerSettingsData[4]);
        wrestler.Wins = int.Parse(wrestlerSettingsData[5]);
        wrestler.Loses = int.Parse(wrestlerSettingsData[6]);
        wrestler.Affiliation = (Affiliations)int.Parse(wrestlerSettingsData[7]);
        wrestler.Push = int.Parse(wrestlerSettingsData[8]);

        wrestler.Weight = int.Parse(ReadLine(reader));
        wrestler.Height = ReadLine(reader);

        wrestler.Moves = LoadMoveList(reader);

        wrestler.TitleNames.AddRange(ReadLine(reader).Split('|', StringSplitOptions.RemoveEmptyEntries));

        return wrestler;
    }

    public static Dictionary<string, MoveModel> LoadMoveList(StreamReader reader)
    {
        /*
            [INT:MoveList.MoveCount]
            [LIST(DELIM=NewLine):MOVE:MoveList.Moves]
        */

        Dictionary<string, MoveModel> moves = new();

        int moveCount = int.Parse(ReadLine(reader));
        for (int i = 0; i < moveCount; i++)
        {
            MoveModel move = LoadMove(reader);
            moves.Add(move.Name, move);
        }

        return moves;
    }

    public static GimmickModel LoadGimmick(StreamReader reader)
    {
        /*
            [STRING:Gimmick.Name]
            [INT:Gimmick.CallMove] [INT:Gimmick.TryPin] [INT:Gimmick.RecStand] [INT:Gimmick.Advantage] [INT:Gimmick.TrySub] [INT:Gimmick.ChangePos] [INT:Gimmick.StayOut] [INT:Gimmick.Weapon] [INT:Gimmick.Random] [INT:Gimmick.DoTag] [INT:Gimmick.CountOut] [INT:Gimmick.Strength]
            [LIST(DELIM=NewLine,COUNT=10):LOCATION:Gimmick.Locations]
            [LIST(DELIM=NewLine,COUNT=10):WEAPON:Gimmick.Weapons]
        */

        GimmickModel gimmick = new();

        gimmick.Name = ReadLine(reader);

        string[] gimmickSettingsData = ReadLine(reader).Split(' ');
        gimmick.CallMove = int.Parse(gimmickSettingsData[0]);
        gimmick.TryPin = int.Parse(gimmickSettingsData[1]);
        gimmick.RecStand = int.Parse(gimmickSettingsData[2]);
        gimmick.Advantage = int.Parse(gimmickSettingsData[3]);
        gimmick.TrySub = int.Parse(gimmickSettingsData[4]);
        gimmick.ChangePos = int.Parse(gimmickSettingsData[5]);
        gimmick.StayOut = int.Parse(gimmickSettingsData[6]);
        gimmick.Weapon = int.Parse(gimmickSettingsData[7]);
        gimmick.Random = int.Parse(gimmickSettingsData[8]);
        gimmick.DoTag = int.Parse(gimmickSettingsData[9]);
        gimmick.CountOut = int.Parse(gimmickSettingsData[10]);
        gimmick.Strength = int.Parse(gimmickSettingsData[11]);

        for (int i = 0; i < 10; i++)
        {
            LocationModel location = LoadLocation(reader);
            gimmick.Locations.Add(location.Name, location);
        }

        for (int i = 0; i < 10; i++)
        {
            WeaponModel weapon = LoadWeapon(reader);
            gimmick.Weapons.Add(weapon.Name, weapon);
        }

        return gimmick;
    }

    private static MoveModel LoadMove(StreamReader reader)
    {
        /*
            [STRING:Move.Name]
            [STRING:Move.Text1]
            [STRING:Move.Text2]
            [STRING:Move.Text3]
            [BOOL(0/1):Move.AttackerStandingBefore] [BOOL(0/1):Move.AttackerStandingAfter] [BOOL(0/1):Move.RecieverStandingBefore] [BOOL(0/1):Move.RecieverStandingAfter] [BOOL(0/1):Move.Lift] [INT:Move.Damage] [INT:Move.Type] [BOOL(0/1):Move.Illegal] [BOOL(0/1):Move.HighRisk]
        */

        MoveModel move = new();

        move.Name = ReadLine(reader);
        move.Texts[0] = ReadLine(reader);
        move.Texts[1] = ReadLine(reader);
        move.Texts[2] = ReadLine(reader);

        string[] moveSettingsData = ReadLine(reader).Split(' ');
        move.AttStandingBefore = (moveSettingsData[0] == "1");
        move.AttStandingAfter = (moveSettingsData[1] == "1");
        move.RecStandingBefore = (moveSettingsData[2] == "1");
        move.RecStandingAfter = (moveSettingsData[3] == "1");
        move.IsLift = (moveSettingsData[4] == "1");
        move.Damage = int.Parse(moveSettingsData[5]);
        move.Type = (MoveTypes)int.Parse(moveSettingsData[6]);
        move.IsIllegal = (moveSettingsData[7] == "1");
        move.IsHighRisk = (moveSettingsData[8] == "1");

        return move;
    }

    private static TeamModel LoadTeam(StreamReader reader)
    {
        /*
            [STRING:Team.Name]|[STRING:Team.Finisher]|[STRING:Team.Introduction]|[STRING:Team.EscortName]
            [INT:Team.Wins] [INT:Team.Loses] [BOOL(0/1):Team.EscortInterferes]
            [LIST(DELIM=|,MAX=100,TRAIL=|):STRING:Team.MemberNames]
            [LIST(DELIM=|,MAX=10,TRAIL=|):STRING:Team.TitleNames]
        */

        TeamModel team = new();

        string[] teamStringsData = ReadLine(reader).Split('|');
        team.Name = teamStringsData[0];
        team.Finisher = teamStringsData[1];
        team.Introduction = teamStringsData[2];
        team.EscortName = teamStringsData[3];

        string[] teamSettingsData = ReadLine(reader).Split(' ');
        team.Wins = int.Parse(teamSettingsData[0]);
        team.Loses = int.Parse(teamSettingsData[1]);
        team.EscortInterferes = (teamSettingsData[2] == "1");

        team.MemberNames.AddRange(ReadLine(reader).Split('|', StringSplitOptions.RemoveEmptyEntries));

        team.TitleNames.AddRange(ReadLine(reader).Split('|', StringSplitOptions.RemoveEmptyEntries));

        return team;
    }

    private static TitleModel LoadTitle(StreamReader reader)
    {
        /*
            [STRING:Title.Name]
            [INT:Title.Type{0=Singles,1=Team}]
        */

        TitleModel title = new();

        title.Name = ReadLine(reader);
        title.Type = (TitleTypes)int.Parse(ReadLine(reader));

        return title;
    }

    private static CommentatorModel LoadCommentator(StreamReader reader)
    {
        /*
            [STRING:Commentator.Name]
            [INT:Commentator.Affiliation{0=Face,1=Neutral,2=Heel}]
            [STRING:Commentator.FileName]
        */

        CommentatorModel commentator = new();

        commentator.Name = ReadLine(reader);
        commentator.Affiliation = (Affiliations)int.Parse(ReadLine(reader));
        commentator.FileName = ReadLine(reader);

        return commentator;
    }

    private static RefereeModel LoadReferee(StreamReader reader)
    {
        /*
            [STRING:Referee.Name]
            [INT:Referee.CountSpeed] [INT:Referee.Stringency]
        */

        RefereeModel referee = new();

        referee.Name = ReadLine(reader);

        string[] refereeSettingsDate = ReadLine(reader).Split(' ');
        referee.CountSpeed = int.Parse(refereeSettingsDate[0]);
        referee.Stringency = int.Parse(refereeSettingsDate[1]);

        return referee;
    }

    private static LocationModel LoadLocation(StreamReader reader)
    {
        /*
            [STRING:Location.Name]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc1Text]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc2Text]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc3Text]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc4Text]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc5Text]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc6Text]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc7Text]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc8Text]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc9Text]||[LIST(DELIM=|,COUNT=3):STRING:Location.TransitionToLoc10Text]|[STRING:Location.Floor]|[BOOL(0/1):Location.PinfallsAtLoc] [BOOL(0/1):Location.SubmissionsAtLoc] [BOOL(0/1):Location.AttackerWinsIfHere] [BOOL(0/1):Location.CanfightHere] [BOOL(0/1):Location.CountOutAtLoc] [BOOL(0/1):Location.WeaponsAtLoc] [BOOL(0/1):Location.CanTagHere] [BOOL(0/1):Location.DQAtLoc]
        */

        LocationModel location = new();

        string[] locationData = ReadLine(reader).Split("|");

        location.Name = locationData[0];

        for (int i = 0; i < 10; i++)
        {
            TransitionModel transition = new();

            int indexBase = 4 * i;
            // locationData[indexBase + 1] -- First index unused
            transition.Texts[0] = locationData[indexBase + 2];
            transition.Texts[1] = locationData[indexBase + 3];
            transition.Texts[2] = locationData[indexBase + 4];
        }

        location.Floor = locationData[41];

        string[] locationSettingsData = locationData[42].Split(' ');
        location.PinfallsAtLoc = (locationSettingsData[0] == "1");
        location.SubmissionsAtLoc = (locationSettingsData[1] == "1");
        location.AttackerWinsIfHere = (locationSettingsData[2] == "1");
        location.CanFightHere = (locationSettingsData[3] == "1");
        location.CountOutAtLoc = (locationSettingsData[4] == "1");
        location.WeaponsAtLoc = (locationSettingsData[5] == "1");
        location.CanTagHere = (locationSettingsData[6] == "1");
        location.DQAtLoc = (locationSettingsData[7] == "1");

        return location;
    }

    private static WeaponModel LoadWeapon(StreamReader reader)
    {
        /*
            -- Zeus 3 version
            [STRING:Weapon.Name]|[BOOL(0/1):Weapon.SwingAtOpponent] [BOOL(0/1):Weapon.UsedToChoke] [BOOL(0/1):Weapon.UsedAsAWhip] [BOOL(0/1):Weapon.ThrownAtOpponent] [BOOL(0/1):Weapon.UsedToCutOpponent] [BOOL(0/1):Weapon.CausesBleeding]
            -- Zeus Pro version
            [STRING:Weapon.Name]|[INT:Weapon.Settings] [STRING:Weapon.IsAt] 0 0 0 0
                -- 1024 - SwingAtOpponent
                -- 512 - UsedToCutOpponent
                -- 256 - ThrownAtOpponent
                -- 128 - UsedAsAWhip
                -- 64 - UsedToChoke
                -- 32 - CausesBleeding
                -- 16 - WillBreak
                -- 8 - ThrownInto
                -- 4 - ShootsAtOpponent
                -- 2 - SlammedOn
        */

        WeaponModel weapon = new();

        string[] weaponData = ReadLine(reader).Split('|');
        weapon.Name = weaponData[0];

        string[] weaponSettingsData = weaponData[1].Split(' ');
        if (int.Parse(weaponSettingsData[2]) < 2) // Zeus 3 version
        {
            weapon.SwingAtOpponent = (weaponSettingsData[0] == "1");
            weapon.UsedToChoke = (weaponSettingsData[1] == "1");
            weapon.UsedAsAWhip = (weaponSettingsData[2] == "1");
            weapon.ThrownAtOpponent = (weaponSettingsData[3] == "1");
            weapon.UsedToCutOpponent = (weaponSettingsData[4] == "1");
            weapon.CausesBleeding = (weaponSettingsData[5] == "1");
        }
        else // Zeus Pro version
        {
            int settings = int.Parse(weaponSettingsData[0]);
            weapon.SwingAtOpponent = (settings & 1024) == 1024;
            weapon.UsedToCutOpponent = (settings & 512) == 512;
            weapon.ThrownAtOpponent = (settings & 256) == 256;
            weapon.UsedAsAWhip = (settings & 128) == 128;
            weapon.UsedToChoke = (settings & 64) == 64;
            weapon.CausesBleeding = (settings & 32) == 32;
            weapon.WillBreak = (settings & 16) == 16;
            weapon.ThrownInto = (settings & 8) == 8;
            weapon.ShootsAtOpponent = (settings & 4) == 4;
            weapon.SlammedOn = (settings & 2) == 2;

            weapon.AvailableAtLocation = int.Parse(weaponSettingsData[1]) - 2;

            // weaponSettingsData[2] to weaponSettingsData[5] are unused (always 0) in Zeus Pro version
        }

        return weapon;
    }
}
