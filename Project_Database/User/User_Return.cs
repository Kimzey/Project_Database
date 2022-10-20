using System;
public class User_Return : User{
    private double time_return  ;
    private double location_return ; 
    public User_Return(string name,string sur_name,string phone_number,string student_ID,string citizen_ID,string mail,string username,string password,double time_return,double location_return)
    :base(name,sur_name,phone_number,student_ID,citizen_ID,mail,username,password){
        this.time_return = time_return;
        this.location_return = location_return;
    }
    public double Get_Time_return(){
       return this.time_return;
    }
    public double Get_Location_return(){
       return this.location_return;
    }
}