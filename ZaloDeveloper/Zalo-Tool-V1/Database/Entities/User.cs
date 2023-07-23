namespace Zalo_Tool_V1.Database.Entities
{
    public class User
    {
        public Guid _Id { get; set; }
        public string? _FullName { get; set; }
        public string? _Phone { get; set; }
        public string? _Password { get; set; }
        public bool? _Gender { get; set; }
        public DateTime? _Birtday { get; set; }
        public string? _Proxy { get; set; }
        public bool? _Backup { get; set; }

        public User() { }
    }
}
