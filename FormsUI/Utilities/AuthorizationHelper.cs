using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Core.Entities.Concrete;
using Core.Utilities.Extensions;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FormsUI.Utilities
{
    public class AuthorizationHelper
    {
        private static IUserService _userService = InstanceFactory.GetInstance<IUserService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        private static IUserClaimService _userClaimService = InstanceFactory.GetInstance<IUserClaimService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        private static IMainClaimService _mainClaimService = InstanceFactory.GetInstance<IMainClaimService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        private static ISubsidiaryClaimService _subsidiaryClaimService = InstanceFactory.GetInstance<ISubsidiaryClaimService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        private static IProjectObjectClaimService _projectObjectClaimService = InstanceFactory.GetInstance<IProjectObjectClaimService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        private static IProjectObjectService _projectObjectService = InstanceFactory.GetInstance<IProjectObjectService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });

        public static bool BigPermission { get; set; }

        static AuthorizationHelper()
        {
            BigPermission = false;
        }

        private static List<string> GetMainClaims(User user) => _userClaimService.GetUserMainClaimNames(user.Id).Select(c => c.ClaimName).ToList();

        private static List<string> GetControlNamesToUse(IEnumerable<Control> collection) => collection.Select(c => c.GetType().FullName).Where(c => c.GetType().Name.ToLower().StartsWith(true, "tbx", "btn", "cmb", "dgw")).ToList();

        private static List<string> GetCurrentUserSubsidiaryRoles(User user) => _userClaimService.GetUserSubsidiaryClaimNames(user.Id).Select(c => c.ClaimName).ToList();

        private static List<string> GetAllProjectObjectsOfUser(User user) => _projectObjectService.GetByUserId(user.Id).Select(p => string.Join(".", new string[] { p.NameSpace, p.ClassName, p.ObjectName })).ToList();

        private static List<string> GetCurrentUserMainRoles(User user) => _userClaimService.GetUserMainClaimNames(user.Id).Select(c => c.ClaimName).ToList();

        private static void AuthorizeSpeciality(User user, System.Windows.Forms.Form.ControlCollection collection)
        {
            var roles = GetAllProjectObjectsOfUser(user);

            var namesCollection = GetControlNamesToUse(GetControlFromControlCollection(collection));

            roles.ForEach(role =>
            {
                if (!namesCollection.Contains(role))
                {
                    namesCollection.ForEach(n =>
                    {
                        GetControlByFullName(n, collection).Visible = false;
                    });
                }
                else
                {
                    namesCollection.ForEach(n =>
                    {
                        GetControlByFullName(n, collection).Visible = true;
                    });
                }
            });
        }

        private static string AuthorizeCommonality(User user) => GetPermissionLevel(_mainClaimService.GetOrderedMainClaims().Select(c => c.Name).ToArray(), GetMainClaims(user));


        private static string GetPermissionLevel(string[] keys, List<string> claims, int n = 0)
        {
            var key = keys[n];
            if (claims.Contains(key))
                return key;
            else if (n + 1 == keys.Length)
                return "";
            else GetPermissionLevel(keys, claims, n + 1);

            return "default";
        }

        private static List<Control> GetControlFromControlCollection(System.Windows.Forms.Form.ControlCollection collection) => new List<Control>(collection.OfType<Control>());


        private static Control GetControlByFullName(string fullName, System.Windows.Forms.Form.ControlCollection collection)
        {
            var parameter = fullName.Split('.');
            return collection.Find(parameter[parameter.Length - 1], true).FirstOrDefault();
        }

        public static void Authorize(User user, System.Windows.Forms.Form.ControlCollection collection)
        {
            var commonality = AuthorizeCommonality(user);
            if (AuthorizeBigPermission(commonality))
            {
                BigPermission = true;
                return;
            }
            else if (commonality == "Moderator")
                return;

            var namesCollection = GetControlNamesToUse(GetControlFromControlCollection(collection));

            if (commonality == "Helper")
            {
                namesCollection.ForEach(n =>
                {
                    if (n.Contains(false, "Add", "Update", "Delete"))
                        GetControlByFullName(n, collection).Visible = false;
                });
            }
            else if (commonality == "StandardUser")
            {

            }

            AuthorizeSpeciality(user, collection);
        }

        private static bool AuthorizeBigPermission(string permissionLevel) => permissionLevel == "Admin";



    }
}
