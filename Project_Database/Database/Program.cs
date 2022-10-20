using System;
public class Program{
    public static void Main(string[] args){
         Database data = new Database();
         User user1 = new User("Pan","Nitiyohtihn","0954821811","64120501003","บัตรประชาชน XXX","kimkung0914@gmail.com","Memox","1234");
         data.AddNewUser(user1);
    }

}