namespace Pharmacy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Receipts = new HashSet<Receipt>();
        }

        public User(User user)
        {
            this.Username = user.Username;
            this.Password = user.Password;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.PID = user.PID;
            this.AddressId = user.AddressId;
            this.AppSettingsId = user.AppSettingsId;
            this.Email = user.Email;
            this.PhoneNumber = user.PhoneNumber;
            this.UserRole = user.UserRole;
            this.IsDeleted = IsDeleted;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [StringLength(40)]
        public string FirstName { get; set; }

        [StringLength(40)]
        public string LastName { get; set; }

        [StringLength(13)]
        public string PID { get; set; }

        public int? AddressId { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(40)]
        public string Username { get; set; }

        [StringLength(250)]
        public string Password { get; set; }

        public byte? UserRole { get; set; }

        public int? AppSettingsId { get; set; }

        [DefaultValue((byte)0)]
        public byte? IsDeleted { get; set; }

        public virtual Address Address { get; set; }

        public virtual AppSettings AppSettings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt> Receipts { get; set; }
    }
}
