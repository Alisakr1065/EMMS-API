namespace DTOs.User
{
    public class UserDto: CreateUserDto
    {
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }



    }
}
