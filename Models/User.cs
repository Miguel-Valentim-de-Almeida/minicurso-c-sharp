namespace HandsOnToDo .Models
{
    public class User
    {
        public int Id {get;set;}

        // user.getId()
        // user.setId("1234")

        public String Name {get;set;}

        public String Email {get;set;}

        public String Password {get;set;}

        // User user = new User();

        public User()
        {
            //this acessa o que eu defini lá em cima
            this.Id = 0;        
	        this.Name = "";
            this.Email = "";
            this.Password = "";
            //this.Role = "User";
        }

        public User(Int32 id, String name, String email, String password)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = password;
            //this.Role = "User";
        }
    }
}