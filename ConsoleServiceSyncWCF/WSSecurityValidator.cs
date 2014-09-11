using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel;
using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace Xtime.ServiceSync
{
    /* CustomUserNameValidator implements a trivial user/password validation. Hook to actual implementation here.
     */
    public class CustomUserNameValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName != "LETMEIN" )
            {
                // This throws an informative fault to the client.
                throw new FaultException("Incorrect username or password");
            }
        }
    }
}
