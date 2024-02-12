namespace Models.Enums;

public enum ObjectStatus
{
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.New))]
    New = 1,
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.GoodAsNew))]
    GoodAsNew = 2,
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.SecondHand))]
    SecondHand = 3,
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.NeedForRepair))] 
    NeedForRepair = 4
}