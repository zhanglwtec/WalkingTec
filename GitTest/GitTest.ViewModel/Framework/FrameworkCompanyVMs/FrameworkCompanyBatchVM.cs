using WalkingTec.Mvvm.Core;
using GitTest.Model;

namespace GitTest.ViewModel.Framework.FrameworkCompanyVMs
{
    public class FrameworkCompanyBatchVM : BaseBatchVM<FrameworkCompany, BaseVM>
    {
        public FrameworkCompanyBatchVM()
        {
            ListVM = new FrameworkCompanyListVM();
        }
    }

}
