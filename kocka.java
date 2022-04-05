package com.company;
import java.util.Random;

public class kocka {
    private Random random;
    private int pocetStien;

    public kocka(int pocetSten){
        pocetStien=pocetSten;
        random= new Random();
    }
    public kocka(){
        pocetStien=6;
        random= new Random();
    }
    public int vratPocetStien(){
        return pocetStien;
    }
    public int hod(){
        return random.nextInt(pocetStien)+1;
    }
}
