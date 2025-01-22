namespace AresPro.WinFormsUi.Models.Gimmick;

public class GimmickModel
{
    public string Name { get; set; }
    public int CallMove { get; set; }
    public int TryPin { get; set; }
    public int RecStand { get; set; }
    public int Advantage { get; set; }
    public int TrySub { get; set; }
    public int CountOut { get; set; }
    public int StayOut { get; set; }
    public int Weapon { get; set; }
    public int Random { get; set; }
    public int DoTag { get; set; }
    public int ChangePos { get; set; }
    public int Strength { get; set; }
    public Dictionary<string, LocationModel> Locations { get; } = [];
    public Dictionary<string, WeaponModel> Weapons { get; } = [];
}
