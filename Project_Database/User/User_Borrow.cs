using System;
public class User_Borrow :User{
    private double time_borrow ;
    private double location_borrow; 

    public User_Borrow(string name,string sur_name,string phone_number,string student_ID,string citizen_ID,string mail,string username,string password,double time_borrow,double location_borrow)
    :base(name,sur_name,phone_number,student_ID,citizen_ID,mail,username,password){
        this.time_borrow = time_borrow;
        this.location_borrow = location_borrow;
    }

    public double Get_Time_borrow(){
       return this.time_borrow;
    }
    public double Get_Location_borrow(){
       return this.location_borrow;
    }
}