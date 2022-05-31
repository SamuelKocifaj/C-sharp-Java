package com.company;

public class PC {
    private String username;
    private String password;
    private double startup_time;
    private String input;
    private String[][] učty={{"Janko","neviem"},{"Peter","neviem123"}};


public PC(String user, String pass){
    username=user;
    password=pass;
}
public boolean auth(){
    if((username.equals(učty[0][0])) && (password.equals(učty[0][1])))
        return true;
    else
        return false;
}
}
