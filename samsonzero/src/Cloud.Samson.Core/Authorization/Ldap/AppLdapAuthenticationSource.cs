using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Cloud.Samson.Authorization.Users;
using Cloud.Samson.MultiTenancy;

namespace Cloud.Samson.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}
