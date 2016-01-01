
namespace NearAndBest.Facade.UnitTest.Admin
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using IFacade.Admin;
    using DTOs.Admin;
    using NearAndBest.Facade.Admin;
    using NearAndBest.DTOs.Common;
   

    [TestClass]
    public class RoleFacadeUnitTest : IFacadeUnitTest
    {
        IRoleFacade facade = new RoleFacade();

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            Configuration.Configure();
        }

        [TestMethod]
        public void GetById()
        {
            int roleId = 6;
            var role = facade.GetById(roleId);

            Assert.IsNotNull(role);
        }

        [TestMethod]
        public void GetAll()
        {
            var roles = facade.GetAll();
            Assert.IsNotNull(roles);
        }

        [TestMethod]
        public void Insert()
        {
            RoleDTO role = new RoleDTO
            {
                RoleName = "Supplier"
            };

            facade.Insert(role);
            Assert.AreNotEqual<int>(0, role.Id);
        }

        [TestMethod]
        public void Update()
        {
            RoleDTO role = new RoleDTO
            {
                Id = 6,
                RoleName = "Supplier User"
            };

            facade.Update(role);
            Assert.AreNotEqual<int>(0, role.Id);
        }

        [TestMethod]
        public void Delete()
        {
           int roleId = 6;

           facade.Delete(6);
            //Assert.AreNotEqual<bool>(true, );
        }
    }
}
