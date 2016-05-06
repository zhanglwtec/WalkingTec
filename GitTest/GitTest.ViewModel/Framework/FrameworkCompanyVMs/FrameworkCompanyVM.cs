using System;
using WalkingTec.Mvvm.Abstraction;
using WalkingTec.Mvvm.Core;
using GitTest.Model;

namespace GitTest.ViewModel.Framework.FrameworkCompanyVMs
{
    public class FrameworkCompanyVM : BaseCRUDVM<FrameworkCompany>
    {
        public Guid? TestFileID { get; set; }

        public FrameworkCompanyVM()
        {
            SetInclude(x => x.Departments, x => x.Photos);
        }

        public override DuplicatedInfo<FrameworkCompany> SetDuplicatedCheck()
        {
            var rv = this.CreateFieldsInfo(SimpleField(x => x.CompanyCode));
            rv.AddGroup(SubField(x => x.MLContents, y => y.CompanyName, y => y.LanguageCode));
            return rv;
        }

    }
}