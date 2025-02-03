using AresPro.WinFormsUi.Enums;
using AresPro.WinFormsUi.Models;

namespace AresPro.WinFormsUi.Helpers;

public static class MatchHelper
{
    public static MoveModel GetRandomMove(Random random, WrestlerModel wrestler, params MoveTypes[] moveTypes)
    {
        List<MoveModel> moves = wrestler.Moves.Where(m => moveTypes.Contains(m.Value.Type)).Select(m => m.Value).ToList();
        return moves[random.Next(moves.Count)];
    }

    public static string GetRandomText(Random random, string[] texts, Dictionary<string, string?>? placeholders = null)
    {
        string text = texts[random.Next(texts.Length)];
        if (placeholders == null)
            return text;
        else
            return StringHelper.ReplacePlaceholders(text, placeholders);
    }

    public static bool WrestlerHasMoves(WrestlerModel wrestler, params MoveTypes[] moveTypes)
    {
        return wrestler.Moves.Any(m => moveTypes.Contains(m.Value.Type));
    }
}
