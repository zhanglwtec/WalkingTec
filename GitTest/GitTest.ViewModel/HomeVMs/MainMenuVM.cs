using System.Collections.Generic;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.UI.Data;

namespace GitTest.ViewModel.HomeVMs
{
    public class MainMenuVM : BaseVM
    {
        public List<TreeItem> MenuData { get; set; }
    }
}