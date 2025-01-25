using AresPro.WinFormsUi.Enums;
using AresPro.WinFormsUi.Models.Common;

namespace AresPro.WinFormsUi.Helpers;

public static class CommonListsHelper
{
    public static SelectionListItem[] AffiliationsList = [
        new SelectionListItem(Affiliations.Face.GetDisplayName(), Affiliations.Face),
        new SelectionListItem(Affiliations.Neutral.GetDisplayName(), Affiliations.Neutral),
        new SelectionListItem(Affiliations.Heel.GetDisplayName(), Affiliations.Heel),
    ];
}
