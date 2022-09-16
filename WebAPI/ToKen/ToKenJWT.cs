using System;
using System.IdentityModel.Tokens.Jwt;

namespace WebAPI.ToKen
{
    public class ToKenJWT
    {
        private JwtSecurityToken token;

        internal ToKenJWT(JwtSecurityToken token)
        {
            this.token = token;
        }

        public DateTime ValidTo => token.ValidTo;

        public string value => new JwtSecurityTokenHandler().WriteToken(this.token);
    }
}
