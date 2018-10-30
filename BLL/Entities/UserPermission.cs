namespace BLL.Entities
{
    public class UserPermission
    {
        public int Id { get; set; }
        public int PermissionId { get; set; }
        public PermissionType PermissionLevel { get; set; }

        public enum PermissionType
        {
            DENIED = 0,
            READ_ONLY = 1,
            READ_WRITE = 2
        }
    }
}
