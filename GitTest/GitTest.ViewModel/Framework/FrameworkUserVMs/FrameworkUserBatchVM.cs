using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using GitTest.Model;
using GitTest.Resource;

namespace GitTest.ViewModel.Framework.FrameworkUserVMs
{
    public class FrameworkUserBatchVM : BaseBatchVM<FrameworkUser, FrameworkUser_BatchEdit>
    {
        public FrameworkUserBatchVM()
        {
            ListVM = new FrameworkUserListVM();
            LinkedVM = new FrameworkUser_BatchEdit();
        }

    }

    /// <summary>
    /// 批量编辑字段类
    /// </summary>
    public class FrameworkUser_BatchEdit : BaseVM
    {
        [Display(Name = "Password", ResourceType = typeof(Language))]
        public string Password { get; set; }
        [Display(Name = "IsValid", ResourceType = typeof(Language))]
        public bool IsValid { get; set; }
    }
}
