using BuildVision.Common;
using BuildVision.UI.Models;
using BuildVision.UI.Settings.Models.BuildProgress;

namespace BuildVision.UI.Settings.Models
{
  public class GeneralSettings : SettingsBase
  {
    public BuildProgressSettings BuildProgressSettings { get; set; }

    public bool EnableStatusBarOutput { get; set; }

    public bool IndicatorsPanelVisible { get; set; }

    public bool StopBuildAfterFirstError { get; set; }

    public NavigateToBuildFailureReasonCondition NavigateToBuildFailureReason { get; set; }

    public bool FillProjectListOnBuildBegin { get; set; }

    public GeneralSettings()
    {
      BuildProgressSettings = new BuildProgressSettings();
      EnableStatusBarOutput = true;
      IndicatorsPanelVisible = true;
    }
  }
}