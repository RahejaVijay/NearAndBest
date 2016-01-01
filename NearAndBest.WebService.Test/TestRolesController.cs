using Microsoft.VisualStudio.TestTools.UnitTesting;
using NearAndBest.WebServices;
using NearAndBest.WebServices.Controllers;
using NearAndBest.Models.Admin;
using NearAndBest.Models.Common;

namespace NearAndBest.WebService.Test
{
    [TestClass]
    public class TestRolesController
    {
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            AutoMapperConfiguration.Configure();
        }

        [TestMethod]
        public void GetById()
        {
            RolesController controller = new RolesController();
            int roleId = 6;
           // ResponseResult<RoleModel> result = controller.GetById(roleId);

            //Assert.AreEqual<int>(roleId, result.First.Id);
        }

        [TestMethod]
        public void GetAll()
        {
            RolesController controller = new RolesController();
            int roleId = 6;

           // ResponseResult<RoleModel> result = controller.GetAll();

            //Assert.AreEqual<int>(roleId, result.First.Id);
        }
    }
}
