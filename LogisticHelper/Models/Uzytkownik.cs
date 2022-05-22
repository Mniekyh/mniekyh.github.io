using Microsoft.OData.Edm;
using System.ComponentModel.DataAnnotations;

namespace LogisticHelper.Models
{
    public class Uzytkownik
    {
        [Key]
        public int ID;
        [Required]
        public string NAZWISKO;
        [Required]
        public string IMIE; 
        [Required]
        public DateTime DATA_URODZENIA;
        [Required]
        public string MAIL;

        public int TELEFON;

    }
}
