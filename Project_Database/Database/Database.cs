using System.Collections.Generic;
using System;

public class Database{
    private List<User> userList ;
    private List<User_Borrow> user_BorrowList ;
    private List<User_Return> user_ReturnList ;

    // ใส่จำนวนจักรยาน (สเตตัสการว่างคือ 1 ไม่ว่างคือ 0)
    private int[] Status_Bike = new int [16] {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1};
    
        public Database(){
            this.userList = new List<User>();
            this.user_BorrowList = new List<User_Borrow>();
            this.user_ReturnList = new List<User_Return>();
        }

        public void AddNewUser(User user) {
        this.userList.Add(user);
    }
        public void AddNewUser_Borrow(User_Borrow user_Borrow) {
        this.userList.Add(user_Borrow);
    }
        public void AddNewUser_Return(User_Return user_Return) {
        this.userList.Add(user_Return);
    }
        public List<User> Get_UserList(){
        return this.userList;
    }
        public List<User_Borrow> Get_User_BorrowList(){
        return this.user_BorrowList;
    }
        public List<User_Return> Get_User_ReturnList(){
        return this.user_ReturnList;
    }

        public void ShowData(User userList ){
        Console.Clear();
        Console.WriteLine("List User");
        Console.WriteLine("************");
        foreach(User user in this.userList) {
            Console.WriteLine("Name : {0}",user.Get_Name());
            Console.WriteLine("Surname : {0}",user.Get_Sur_name());
            Console.WriteLine("Phone_Number : {0}",user.Get_Phone_number());
            Console.WriteLine("Mail : {0}",user.Get_Mail());
            Console.WriteLine("Student_ID : {0}",user.Get_Student_ID());
            Console.WriteLine("Citizen_ID : {0}",user.Get_Citizen_ID());
            Console.WriteLine("Username : {0}",user.Get_Username());
            Console.WriteLine("Password : {0}",user.Get_Password());
            Console.WriteLine("************");
        }
        }

        public void ShowData(User_Borrow user_BorrowList ){
        Console.Clear();
        Console.WriteLine("List User Borrow");
        Console.WriteLine("************");
        foreach(User_Borrow user in this.user_BorrowList) {
            Console.WriteLine("Name : {0}",user.Get_Name());
            Console.WriteLine("Surname : {0}",user.Get_Sur_name());
            Console.WriteLine("Phone_Number : {0}",user.Get_Phone_number());
            Console.WriteLine("Mail : {0}",user.Get_Mail());
            Console.WriteLine("Student_ID : {0}",user.Get_Student_ID());
            Console.WriteLine("Citizen_ID : {0}",user.Get_Citizen_ID());
            Console.WriteLine("Username : {0}",user.Get_Username());
            Console.WriteLine("Password : {0}",user.Get_Password());
            Console.WriteLine("Time Borrow : {0}",user.Get_Time_borrow());
            Console.WriteLine("Location borrow : {0}",user.Get_Location_borrow());
            Console.WriteLine("************");
        }
        }
        public void ShowData(User_Return user_ReturnList ){
        Console.Clear();
        Console.WriteLine("List User Return");
        Console.WriteLine("************");
        foreach(User_Return user in this.user_ReturnList) {
            Console.WriteLine("Name : {0}",user.Get_Name());
            Console.WriteLine("Surname : {0}",user.Get_Sur_name());
            Console.WriteLine("Phone_Number : {0}",user.Get_Phone_number());
            Console.WriteLine("Mail : {0}",user.Get_Mail());
            Console.WriteLine("Student_ID : {0}",user.Get_Student_ID());
            Console.WriteLine("Citizen_ID : {0}",user.Get_Citizen_ID());
            Console.WriteLine("Username : {0}",user.Get_Username());
            Console.WriteLine("Password : {0}",user.Get_Password());
            Console.WriteLine("Time Return : {0}",user.Get_Time_return());
            Console.WriteLine("Location Return : {0}",user.Get_Location_return());
            Console.WriteLine("************");
        }
        }

    public int[] Set_Status_Bike(int i ,int Status){
        this.Status_Bike[i] = Status; 
        return this.Status_Bike;
    }
    public int[] Get_Status_Bike(){
        return this.Status_Bike;
    }
    



}