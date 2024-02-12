namespace Models.Enums
{
    public enum MotorStat
    {
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Healthy))]
        Healthy = 1,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.NeedForRepair))]
        NeedForRepair = 2,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Changed))]
        Changed = 3
    }
    public enum ChasisStat
    {
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.BothHealthy))]
        BothHealthy = 1,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.BackGotHit))]
        BackGotHit = 2,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.BackPainted))]
        BackPainted = 3,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.FrontGotHit))]
        FrontGotHit = 4,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.FrontPainted))]
        FrontPainted = 5,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.BackGotHitFrontPainted))]
        BackGotHitFrontPainted = 6,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.FrontGotHitBackPainted))]
        FrontGotHitBackPainted = 7,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.BothGotHit))]
        BothGotHit = 8,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.BothPainted))]
        BothPainted = 9
    }
    public enum InsuranceTimeRemained
    {
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.OneMonth))]
        OneMonth = 1,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.TwoMonths))]
        TwoMonths = 2,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.ThreeMonths))]
        ThreeMonths = 3,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.FourMonths))]
        FourMonths = 4,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.FiveMonths))]
        FiveMonths = 5,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.SixMonths))]
        SixMonths = 6,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.SevenMonths))]
        SevenMonths = 7,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.EightMonths))]
        EightMonths = 8,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.NineMonths))]
        NineMonths = 9,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.TenMonths))]
        TenMonths = 10,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.ElevenMonths))]
        ElevenMonths = 11,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.TwelveMonths))]
        TwelveMonths = 12
    }

    public enum GearBoxStat
    {
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.ManualGear))]
        Manual = 1,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.AutomaticGear))]
        Auto = 2
    }
}
