using Microsoft.EntityFrameworkCore;

namespace Models;

[Owned]
public class CarAdditionalInfo
{
    [Display(ResourceType = typeof(DataDictionary)
        , Name = nameof(DataDictionary.CarMotorStatus))]
    public MotorStat MotorStatus { get; set; }
    [Display(ResourceType = typeof(DataDictionary)
        , Name = nameof(DataDictionary.CarChassisStatus))]
    public ChasisStat ChassisStatus { get; set; }
    [Display(ResourceType = typeof(DataDictionary)
        , Name = nameof(DataDictionary.CarInsuranceTimeRemained))]
    public InsuranceTimeRemained InsuranceTimeRemained { get; set; }
    [Display(ResourceType = typeof(DataDictionary)
        , Name = nameof(DataDictionary.CarGearBoxStatus))]
    public GearBoxStat GearBoxStatus { get; set; }

    [Display(ResourceType = typeof(DataDictionary)
        , Name = nameof(DataDictionary.CanBeExchanged))]
    public bool CanBeExchanged { get; set; }

}
