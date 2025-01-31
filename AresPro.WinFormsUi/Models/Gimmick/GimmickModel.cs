namespace AresPro.WinFormsUi.Models.Gimmick;

public class GimmickModel
{
    public string Name { get; set; } = string.Empty;
    public int CallMove { get; set; } = 3;
    public int TryPin { get; set; } = 3;
    public int RecStand { get; set; } = 4;
    public int Advantage { get; set; } = 2;
    public int TrySub { get; set; } = 4;
    public int CountOut { get; set; } = 10;
    public int StayOut { get; set; } = 5;
    public int Weapon { get; set; } = 3;
    public int Random { get; set; } = 3;
    public int DoTag { get; set; } = 3;
    public int ChangePos { get; set; } = 3;
    public int Strength { get; set; } = 6;
    public Dictionary<string, LocationModel> Locations { get; } = [];
    public Dictionary<string, WeaponModel> Weapons { get; } = [];
}
