using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DokkanGameEF.Entities
{
    public class Player
    {
        private byte[] _playerPassword;
        public int PlayerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Pseudo { get; set; }
        public string Email { get; set; }
        public List<CardPlayer> Cards { get; set; }
        public byte[] PlayerPassword
        {
            get { return _playerPassword; }
            set { _playerPassword = value; }
        }

        public bool CheckPassword(string password)
        {
            bool IsValidPassword = Regex.IsMatch(password, "^(?=.*[A-Z].*[A-Z])(?=.*[!@#$&*])(?=.*[0-9].*[0-9])(?=.*[a-z].*[a-z].*[a-z]).{8}$");
            return IsValidPassword;
        }

    }
}
