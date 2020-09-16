using System;
using System.Threading.Tasks;
using Microsoft.AppCenter;

namespace AppCenterIssue.Core
{
    public class MyClass
    {
        public async Task<Guid?> MyMethod()
        {
            var id = await AppCenter.GetInstallIdAsync();

            return id;
        }
    }
}
