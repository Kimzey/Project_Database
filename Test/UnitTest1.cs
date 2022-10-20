using System.Collections.Generic;
using System;

namespace Test;

public class UnitTest1
{
    //สร้างไว้เทส
    public Database data = new Database();
    public User user = new User("Pan","Nitiyohtihn","0954821811","64120501003","บัตรประชาชน XXX","kimkung0914@gmail.com","Memox","1234");
    public User_Borrow user_borrow = new User_Borrow("Pan","Nitiyohtihn","0954821811","64120501003","บัตรประชาชน XXX","kimkung0914@gmail.com","Memox","1234",14.00,1);
    public User_Return user_return = new User_Return("Pan","Nitiyohtihn","0954821811","64120501003","บัตรประชาชน XXX","kimkung0914@gmail.com","Memox","1234",16.00,2);

    [Fact]
    public void Test_Get_Name()
    { 
        Assert.IsType<string>(user.Get_Name());
    }

        [Fact]
    public void Test_Get_Sur_Name()
    { 
        Assert.IsType<string>(user.Get_Sur_name());
    }

        [Fact]
    public void Test_Get_Phone_number()
    { 
        Assert.IsType<string>(user.Get_Phone_number());
    }

        [Fact]
    public void Test_Get_Mail()
    { 
        Assert.IsType<string>(user.Get_Mail());
    }

        [Fact]
    public void Test_Get_Student_ID()
    { 
        Assert.IsType<string>(user.Get_Student_ID());
    }

            [Fact]
    public void Test_Get_Citizen_ID()
    { 
        Assert.IsType<string>(user.Get_Citizen_ID());
    }

            [Fact]
    public void Test_Get_Username()
    { 
        Assert.IsType<string>(user.Get_Username());
    }

            [Fact]
    public void Test_Get_Password()
    { 
        Assert.IsType<string>(user.Get_Password());
    }

    [Fact]
        public void Test_Get_Time_borrow()
    { 
        Assert.IsType<double>(user_borrow.Get_Time_borrow());
    }

    [Fact]
        public void Test_Get_Location_borrow()
    { 
        Assert.IsType<double>(user_borrow.Get_Location_borrow());
    }

    [Fact]
            public void Test_Get_Time_return()
    { 
        Assert.IsType<double>(user_return.Get_Time_return());
    }

    [Fact]
        public void Test_Get_Location_return()
    { 
        Assert.IsType<double>(user_return.Get_Location_return());
    }

    [Fact]
        public void Test_Get_UserList()
    { 
        Assert.IsType<List<User>>(data.Get_UserList());
    }

    [Fact]
        public void Test_Get_User_BorrowList()
    { 
       Assert.IsType<List<User_Borrow>>(data.Get_User_BorrowList());
    }

    [Fact]
        public void Test_Get_ReturnList()
    { 
       Assert.IsType<List<User_Return>>(data.Get_User_ReturnList());
    }

    [Fact]
        public void Test_Get_Status_Bike()
    { 
       Assert.IsType<int[]>(data.Get_Status_Bike());
    }

    [Fact]
        public void Test_Set_Status_Bike()
    { 
        int[] testArray = {1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1};
        int[] Status_Bike =  data.Set_Status_Bike(2,0);
        Assert.Equal(testArray,Status_Bike);
    }

}