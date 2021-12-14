using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaraan.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjamen = new HashSet<Peminjaman>();
        }

        public int IdCustomer { get; set; }
        [Required(ErrorMessage = "Nama Customer Tidak Boleh Kosong")]
        public string NamaCustomer { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public string Nik { get; set; }
        public string Alamat { get; set; }
        [MinLength(10, ErrorMessage = "No HP Minimal 10 angka")]
        [MaxLength(13, ErrorMessage = "No HP Maksimal 13 Angka")]
        public string NoHp { get; set; }
        public int IdGender { get; set; }

        public virtual Gender IdGenderNavigation { get; set; }
        public virtual ICollection<Peminjaman> Peminjamen { get; set; }
    }
}
