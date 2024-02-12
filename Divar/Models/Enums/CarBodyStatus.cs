namespace Models.Enums
{

    public enum CarBodyStatus
    {
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.NoScratches))]
        NoScratches = 1,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.MinorScratches))]
        MinorScratches = 2,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.ColorLessSmoothing))]
        ColorLessSmoothing = 3,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.ColoredSmoothing))]
        ColoredSmoothing = 4,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Painted))]
        Painted = 5,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.CompletelyPainted))]
        CompletelyPainted = 6,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Crashed))]
        Crashed = 7,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Scrap))]
        Scrap = 8
    }

}